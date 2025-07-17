//using Application.Interfaces.IRepository;
//using Domain.DTOs;
//using Domain.models;
//using Infrastructure.Hubs;
//using Infrastructure.Persistence;
//using Microsoft.AspNetCore.SignalR;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.Repository
//{
//    public class AlertNewRepository : IAlertRepository, IDisposable
//    {
//        private readonly IHubContext<AlertHub> _hubContext;
//        private readonly AirLiquideContext _context;
//        private readonly Dictionary<string, int> _alertTypeMap;
//        private static readonly ConcurrentDictionary<(string Equipment, AlertSource Source), AlertDto> _activeAlerts = new();

//        public AlertNewRepository(
//            IHubContext<AlertHub> hubContext,
//            AirLiquideContext context,
//            Infrastructure.SignalR.RefreshDatabaseSubscription subscription)
//        {
//            _hubContext = hubContext;
//            _context = context;
//            _alertTypeMap = _context.AlertTypes.ToDictionary(a => a.Description, a => a.Id);

//            // Souscrire à l'événement de rafraîchissement
//            subscription.RefreshReceived += async (sender, refresh) =>
//            {
//                await ProcessRefreshAsync(refresh);
//            };
//        }

//        public async Task ProcessRefreshAsync(Refresh refresh)
//        {
//            var tank = await _context.TankPumps
//                .FirstOrDefaultAsync(t => t.Equipment == refresh.Equipment);
//            if (tank == null)
//                return;

//            if (tank.Type == "T")
//            {
//                // Diva : niveau et pression
//                await CheckAndSendAlert(refresh, tank,
//                    AlertSource.Level, refresh.Level1 ?? 0, "LowLevel", "VeryLowLevel");
//                await CheckAndSendAlert(refresh, tank,
//                    AlertSource.Pressure, refresh.Pressure1 ?? 0, "HighPression", "VeryHighPression");
//            }
//            else if (tank.Type == "V")
//            {
//                // Vigi : boucler sur les voies actives
//                for (int i = 1; i <= 7; i++)
//                {
//                    var propVoieEnabled = tank.GetType().GetProperty($"Voie{i}");
//                    if (propVoieEnabled == null) continue;

//                    int enabled = (int)propVoieEnabled.GetValue(tank);
//                    if (enabled == 0) continue;

//                    var propValue = refresh.GetType().GetProperty($"voie{i}");
//                    if (propValue == null) continue;
//                    double value = (double?)propValue.GetValue(refresh) ?? 0;

//                    // Seuils bas
//                    await CheckAndSendAlert(refresh, tank,
//                        (AlertSource)Enum.Parse(typeof(AlertSource), $"Voie{i}"),
//                        value,
//                        $"LowLevelVoie{i}",
//                        $"VeryLowLevelVoie{i}");

//                    // Seuils haut
//                    await CheckAndSendAlert(refresh, tank,
//                        (AlertSource)Enum.Parse(typeof(AlertSource), $"Voie{i}"),
//                        value,
//                        $"HighPressionVoie{i}",
//                        $"VeryHighPressionVoie{i}");
//                }
//            }
//        }

//        private async Task CheckAndSendAlert(
//            Refresh refresh,
//            TankPump tank,
//            AlertSource source,
//            double value,
//            string lowTypeName,
//            string veryLowTypeName)
//        {
//            var key = (refresh.Equipment, source);

//            // Récupérer dynamiquement les seuils
//            var lowProp = tank.GetType().GetProperty(lowTypeName);
//            var veryLowProp = tank.GetType().GetProperty(veryLowTypeName);
//            if (lowProp == null || veryLowProp == null)
//            {
//                Console.WriteLine($"Propriété '{lowTypeName}' ou '{veryLowTypeName}' introuvable dans TankPump");
//                return;
//            }

//            double lowThreshold = (double?)(lowProp.GetValue(tank)) ?? double.MaxValue;
//            double veryLowThreshold = (double?)(veryLowProp.GetValue(tank)) ?? double.MaxValue;

//            // Comparaison des valeurs
//            string alertDesc = null;
//            if (value <= veryLowThreshold) alertDesc = veryLowTypeName;
//            else if (value <= lowThreshold) alertDesc = lowTypeName;

//            if (alertDesc != null && _alertTypeMap.TryGetValue(alertDesc, out var typeId))
//            {
//                // Créer DTO et mettre à jour le cache
//                var dto = new AlertDto
//                {
//                    Equipment = refresh.Equipment,
//                    Source = source,
//                    AlertTypeId = typeId,
//                    AlertTypeDescription = alertDesc,
//                    AcquisitionTime = refresh.AcquisitionTime
//                };
//                _activeAlerts.AddOrUpdate(key, dto, (k, e) => dto);

//                // Envoyer via SignalR
//                await _hubContext.Clients.All.SendAsync("ReceiveAlert", dto);

//                // Historiser
//                _context.Alerts.Add(new Alert
//                {
//                    Equipment = refresh.Equipment,
//                    Customer = tank.Customer,
//                    AcquisitionTime = refresh.AcquisitionTime,
//                    Level1 = refresh.Level1,
//                    Pressure1 = refresh.Pressure1,
//                    AlertType = typeId
//                });
//                await _context.SaveChangesAsync();
//            }
//            else
//            {
//                // Suppression de l'alerte active en temps réel
//                if (_activeAlerts.TryRemove(key, out _))
//                {
//                    await _hubContext.Clients.All.SendAsync("RemoveAlert", refresh.Equipment, source);
//                }
//            }
//        }

//        public IReadOnlyCollection<AlertDto> GetActiveAlerts()
//            => _activeAlerts.Values.ToList().AsReadOnly();

//        public void Dispose() { /* aucun disposé nécessaire */ }
//    }
//}