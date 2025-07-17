using Microsoft.AspNetCore.SignalR;

using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;

using Microsoft.Extensions.DependencyInjection;
using Domain.models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Infrastructure.Persistence;
using Infrastructure.Hubs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Domain.DTOs;
using Humanizer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Application.Interfaces.IRepository;

namespace Infrastructure.SignalR
{
    public class RefreshDatabaseSubscription : BackgroundService


    {

        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<RefreshHub> _hubContext;
        private SqlTableDependency<Refresh> _tableDependency;
        private static readonly Dictionary<string, HashSet<int>> _activeAlertsByEquipment =
            new Dictionary<string, HashSet<int>>();



        public RefreshDatabaseSubscription(IServiceScopeFactory scopeFactory,
                                           IHubContext<RefreshHub> hubContext,
                                           IConfiguration configuration )
        {
            _scopeFactory = scopeFactory;
            _hubContext = hubContext;
            var connStr = configuration.GetConnectionString("DefaultConnection");


            try
            {
                using (var testConn = new SqlConnection(connStr))
                {
                    testConn.Open();
                }
                _tableDependency = new SqlTableDependency<Refresh>(

                    connStr, tableName: "Refresh", schemaName: "dbo", executeUserPermissionCheck: false);
                _tableDependency.OnChanged += OnTableChanged;
                _tableDependency.OnError += (_, e) => Console.WriteLine(e.Error.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error initializing table dependencies: {ex.Message}");
                throw;
            }


        }


        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _tableDependency.Start();
            return Task.CompletedTask;
        }




        private async void OnTableChanged(object sender, RecordChangedEventArgs<Refresh> e)
        {
            if (e.ChangeType != ChangeType.Insert && e.ChangeType != ChangeType.Update)
                return;

            var r = e.Entity;
            using var scope = _scopeFactory.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AirLiquideContext>();
            var refreshRepository = scope.ServiceProvider.GetRequiredService<IRefreshRepository>();


            // 1) Récupérer la config de seuils
            var tp = await db.TankPumps
                .FirstOrDefaultAsync(t => t.Equipment == r.Equipment);
            if (tp == null) return;

            var customer = await db.Customers.FirstOrDefaultAsync(c => c.Id == tp.Customer);
            var tankPump = await db.TankPumps.FirstOrDefaultAsync(tp => tp.Equipment == r.Equipment);


            // 2) Détecter l'ensemble des types d'alerte sur CE refresh
            var activeTypes = new List<int>();

            if (tp.Type == "T")
            {
                if (r.Level1 < tp.VeryLowLevel) activeTypes.Add(12);
                else if (r.Level1 < tp.LowLevel) activeTypes.Add(11);

                if (r.Pressure1 > tp.VeryHighPression) activeTypes.Add(22);
                else if (r.Pressure1 > tp.HighPression) activeTypes.Add(21);
                else if (r.Pressure1 < tp.VeryLowPression) activeTypes.Add(24);
                else if (r.Pressure1 < tp.LowPression) activeTypes.Add(23);
            }
            else if (tp.Type == "V")
            {
                if (r.LastAlertType.HasValue && r.LastAlertType != 0)
                {
                    activeTypes.Add(r.LastAlertType.Value);
                }
            }

            // Type D ou A : défauts pompe A
            else if (tp.Type == "D" || tp.Type == "A")
            {

                // Défauts pompe A
                if (r.PreAlarmTempPumpA == true) activeTypes.Add(2032);               // Pré-alarme température A
                if (r.AuxiliaryFaultA == true) activeTypes.Add(2040);                 // Défaut auxiliaire A
                if (r.DisjonctionFaultA == true) activeTypes.Add(2046);               // Défaut disjoncteur A
                if (r.OilLvlFaultA == true) activeTypes.Add(40010);                   // Défaut niveau huile (Pression régulation hypothétique)
                if (r.HighTempFaultA == true) activeTypes.Add(40400);                 // Défaut température haute
                if (r.OffScaleTempPompA == true) activeTypes.Add(40106);              // Alarme hors échelle température
                if (r.LowTempFaultA == true) activeTypes.Add(40200);                  // Défaut température basse
                if (r.CompressorProblemAlarmA == true) activeTypes.Add(40002);        // Défaut compresseur A
                if (r.TrapBekoProblemA == true) activeTypes.Add(40001);               // Défaut purgeur BEKO A (hypothétique)
                if (r.DryerTemperatureProblemA == true) activeTypes.Add(40031);       // Défaut température base A
                if (r.HygrometryLineA == true) activeTypes.Add(40800);                // Défaut hygrométrie ligne A


                // Défauts pompe B
               if (r.PreAlarmTempPumpB == true) activeTypes.Add(2033);               // Pré-alarme température B
                if (r.AuxiliaryFaultB == true) activeTypes.Add(2041);                 // Défaut auxiliaire B
                if (r.DisjonctionFaultB == true) activeTypes.Add(2047);               // Défaut disjoncteur B
                if (r.OilLvlFaultB == true) activeTypes.Add(40011);                   // Défaut niveau huile B (hypothétique)
                if (r.HighTempFaultB == true) activeTypes.Add(40401);                 // Défaut température haute B
                if (r.OffScaleTempPompB == true) activeTypes.Add(40107);              // Alarme hors échelle température B
                if (r.LowTempFaultB == true) activeTypes.Add(40201);                  // Défaut température basse B
                if (r.CompressorProblemAlarmB == true) activeTypes.Add(40003);        // Défaut compresseur B
                if (r.TrapBekoProblemB == true) activeTypes.Add(40004);               // Défaut purgeur BEKO B
                if (r.DryerTemperatureProblemB == true) activeTypes.Add(40032);       // Défaut température base B
                if (r.HygrometryLineB == true) activeTypes.Add(40801);                // Défaut hygrométrie ligne B

                // Défauts pompe C
                if (r.PreAlarmTempPumpC == true) activeTypes.Add(2034);               // Pré-alarme température C
                if (r.AuxiliaryFaultC == true) activeTypes.Add(2042);                 // Défaut auxiliaire C
                if (r.DisjonctionFaultC == true) activeTypes.Add(2048);               // Défaut disjoncteur C
                if (r.OilLvlFaultC == true) activeTypes.Add(40012);                   // Défaut niveau huile C (hypothétique)
                if (r.HighTempFaultC == true) activeTypes.Add(40402);                 // Défaut température haute C
                if (r.OffScaleTempPompC == true) activeTypes.Add(40108);              // Alarme hors échelle température C
                if (r.LowTempFaultC == true) activeTypes.Add(40202);                  // Défaut température basse C
                if (r.CompressorProblemAlarmC == true) activeTypes.Add(40005);        // Défaut compresseur C
                if (r.TrapBekoProblemC == true) activeTypes.Add(40006);               // Défaut purgeur BEKO C
                if (r.DryerTemperatureProblemC == true) activeTypes.Add(40033);       // Défaut température base C
                if (r.HygrometryLineC == true) activeTypes.Add(40802);                // Défaut hygrométrie ligne C


                // Défauts pompe D
                if (r.PreAlarmTempPumpD == true) activeTypes.Add(2035);               // Pré-alarme température D
                if (r.AuxiliaryFaultD == true) activeTypes.Add(2043);                 // Défaut auxiliaire D
                if (r.DisjonctionFaultD == true) activeTypes.Add(2049);               // Défaut disjoncteur D
                if (r.OilLvlFaultD == true) activeTypes.Add(40013);                   // Défaut niveau huile D (hypothétique)
                if (r.HighTempFaultD == true) activeTypes.Add(40403);                 // Défaut température haute D
                if (r.OffScaleTempPompD == true) activeTypes.Add(40109);              // Alarme hors échelle température D
                if (r.LowTempFaultD == true) activeTypes.Add(40203);                  // Défaut température basse D
                if (r.CompressorProblemAlarmD == true) activeTypes.Add(40007);        // Défaut compresseur D
                if (r.TrapBekoProblemD == true) activeTypes.Add(40008);               // Défaut purgeur BEKO D
                if (r.DryerTemperatureProblemD == true) activeTypes.Add(40034);       // Défaut température base D
                if (r.HygrometryLineD == true) activeTypes.Add(40803);                // Défaut hygrométrie ligne D

            }

            for (int i = 1; i <= 7; i++)
            {
                var voieActive = (bool?)tp.GetType().GetProperty($"Voie{i}")?.GetValue(tp) == true;
                var voieValue = (double?)r.GetType().GetProperty($"Voie{i}")?.GetValue(r);


                if (!voieActive || voieValue == null) continue;

                var veryLowLevel = (double?)tp.GetType().GetProperty($"VeryLowLevelVoie{i}")?.GetValue(tp);
                var lowLevel = (double?)tp.GetType().GetProperty($"LowLevelVoie{i}")?.GetValue(tp);
                var veryLowPression = (double?)tp.GetType().GetProperty($"VeryLowPressionVoie{i}")?.GetValue(tp);
                var lowPression = (double?)tp.GetType().GetProperty($"LowPressionVoie{i}")?.GetValue(tp);
                var highPression = (double?)tp.GetType().GetProperty($"HighPressionVoie{i}")?.GetValue(tp);
                var veryHighPression = (double?)tp.GetType().GetProperty($"VeryHighPressionVoie{i}")?.GetValue(tp);

                int baseBasNiveau = 2148 + (i - 1);
                int baseTresBasNiveau = 2169 + (i - 1);
                int baseBasPression = 2162 + (i - 1);
                int baseTresBasPression = 2183 + (i - 1);
                int baseHautPression = 2155 + (i - 1);
                int baseTresHautPression = 2176 + (i - 1);

                if (veryLowLevel != null && voieValue < veryLowLevel)
                    activeTypes.Add(baseTresBasNiveau);
                else if (lowLevel != null && voieValue < lowLevel)
                    activeTypes.Add(baseBasNiveau);

                else if (veryLowPression != null && voieValue < veryLowPression)
                    activeTypes.Add(baseTresBasPression);
                else if (lowPression != null && voieValue < lowPression)
                    activeTypes.Add(baseBasPression);

                else if (veryHighPression != null && voieValue > veryHighPression)
                    activeTypes.Add(baseTresHautPression);
                else if (highPression != null && voieValue > highPression)
                    activeTypes.Add(baseHautPression);


            }

             

        
            

            var alert = new List<object>();
            foreach (var t in activeTypes)
            {
                var desc = await db.AlertTypes
                                 .Where(at => at.Id == t)
                                 .Select(at => at.Description)
                                 .FirstOrDefaultAsync() ?? "";
                if (tp.Type == "T")
                {
                    alert.Add(new AlertDivaDto
                    {
                        Equipment = tp.Equipment,
                        AcquisitionTime = r.AcquisitionTime,
       
                        EquipmentType = tp.Type,
                        Customer = tp.Customer,
                        EquipmentName = tp.Name,
                        Pressure1 = r.Pressure1,
                        Level1 = r.Level1

                    });
                }
                else if (tp.Type == "V")
                {
                    alert.Add(new AlertVigiDto
                    {
                        Equipment = tp.Equipment,
                        AcquisitionTime = r.AcquisitionTime,

                        EquipmentType = tp.Type,
                        Customer = tp.Customer,
                        EquipmentName = tp.Name,
                        Voie1 = r.Voie1,
                        Voie2 = r.Voie2,
                        Voie3 = r.Voie3,
                        Voie4 = r.Voie4,
                        Voie5 = r.Voie5,
                        Voie6 = r.Voie6,
                        Voie7 = r.Voie7,
                        NameVoie1 = tp.NameVoie1,
                        NameVoie2 = tp.NameVoie2,
                        NameVoie3 = tp.NameVoie3,
                        NameVoie4 = tp.NameVoie4,
                        NameVoie5 = tp.NameVoie5,
                        NameVoie6 = tp.NameVoie6,
                        NameVoie7 = tp.NameVoie7
                    });
                }
                else if (tp.Type == "D" || tp.Type == "A")
                {
                    alert.Add(new AlertProDto
                    {
                        Equipment = tp.Equipment,
                        AcquisitionTime = r.AcquisitionTime,

                        EquipmentType = tp.Type,
                        Customer = tp.Customer,
                        EquipmentName = tp.Name,
                        TempPompA = r.TempPompA,
                        HourCounterPompA = r.HourCounterPompA,
                        TempPompB = r.TempPompB,
                        HourCounterPompB = r.HourCounterPompB,
                        TempPompC = r.TempPompC,
                        HourCounterPompC = r.HourCounterPompC,
                        TempPompD = r.TempPompD,
                        HourCounterPompD = r.HourCounterPompD,





                    });
                }

                else
                {
                    // Si type inconnu
                    return;
                }

                db.Alerts.Add(new Alert
                {
                    AcquisitionTime = r.AcquisitionTime,
                    AlertType = t,
                    Equipment = r.Equipment,
                    Latitude = r.Latitude,
                    Longitude = r.Longitude,
                    Customer = tp.Customer,
                    Level1 = r.Level1,
                    Pressure1 = r.Pressure1,
                    Voie1=r.Voie1,
                    Voie2 = r.Voie2,
                    Voie3 = r.Voie3,
                    Voie4 = r.Voie4,
                    Voie5 = r.Voie5,
                    Voie6 = r.Voie6,
                    Voie7 = r.Voie7,
                    TempPompA = r.TempPompA,
                    HourCounterPompA = r.HourCounterPompA,
                    TempPompB = r.TempPompB,
                    HourCounterPompB = r.HourCounterPompB,
                    TempPompC = r.TempPompC,
                    HourCounterPompC = r.HourCounterPompC,
                    TempPompD = r.TempPompD,
                    HourCounterPompD = r.HourCounterPompD,


                });

                await _hubContext.Clients.Group(r.Equipment)
                        .SendAsync("ReceiveAlert", new
                        {
                            AcquisitionTime = r.AcquisitionTime,
                            AlertType = t,
                            Equipment = r.Equipment,
                            Latitude = r.Latitude,
                            Longitude = r.Longitude,
                            Customer = tp.Customer,
                            Level1 = r.Level1,
                            Pressure1 = r.Pressure1,
                            Description = desc,
                            CustomerName = customer?.Name,
                            EquipmentName = tp.Name,
                            r.Voie1,
                            r.Voie2,
                            r.Voie3,
                            r.Voie4,
                            r.Voie5,
                            r.Voie6,
                            r.Voie7,
                            tp.NameVoie1,
                            tp.NameVoie2,
                            tp.NameVoie3,
                            tp.NameVoie4,
                            tp.NameVoie5,
                            tp.NameVoie6,
                            tp.NameVoie7,
                            r.TempPompA,
                            r.HourCounterPompA,
                            r.TempPompB,
                            r.HourCounterPompB,
                            r.TempPompC,
                            r.HourCounterPompC,
                            r.TempPompD,
                            r.HourCounterPompD,




                        });

            }
            db.SaveChanges();



            // 4) **Diffuser la liste COMPLÈTE et à jour** des alertes ACTIVES
            // 4) Diffuser la liste COMPLÈTE et à jour des alertes ACTIVES
            var activeDtos = new List<AlertDto>();

            if (activeTypes != null && activeTypes.Any())
            {
                foreach (var t in activeTypes)
                {
                    var desc = await db.AlertTypes
                                         .Where(at => at.Id == t)
                                         .Select(at => at.Description)
                                         .FirstOrDefaultAsync() ?? "";

                    activeDtos.Add(new AlertDto
                    {
                        Equipment = r.Equipment,
                        Customer = r.Customer,
                        AlertType = t,
                        Description = desc,
                        AcquisitionTime = r.AcquisitionTime,
                        CustomerName = customer?.Name,
                        EquipmentName = tp.Name,
                        
                    });
                }
            }
            else
            {
                // Important : forcer envoi d’une liste vide si aucune alerte active
                activeDtos = new List<AlertDto>();
            }


            // Toujours envoyer quelque chose
            await _hubContext.Clients.Group(r.Equipment)
                .SendAsync("ReceiveActiveAlerts", activeDtos);



            await _hubContext.Clients.Group(r.Equipment)
                .SendAsync("ReceivedRefresh", new
                {
                    r.Equipment,
                    r.Customer,
                    CustomerName = customer?.Name,
                    EquipmentName = tankPump?.Name,

                    r.AcquisitionTime,
                    tp.NameVoie1,
                    tp.NameVoie2,
                    tp.NameVoie3,
                    tp.NameVoie4,
                    tp.NameVoie5,
                    tp.NameVoie6,
                    tp.NameVoie7,
                    r.Direction,
                    r.Latitude,
                    r.Longitude,
                    r.Pressure1,
                    r.Level1,
                    r.Voie1,
                    r.Voie2,
                    r.Voie3,
                    r.Voie4,
                    r.Voie5,
                    r.Voie6,
                    r.Voie7,
                    EquipmentType = tp.Type,
                    r.TempPompA,
                    r.HourCounterPompA,
                    r.TempPompB,
                    r.HourCounterPompB,
                    r.TempPompC,
                    r.HourCounterPompC,
                    r.TempPompD,
                    r.HourCounterPompD,
                });

            var data = await refreshRepository.GetProductsByTypeForAllCustomers(tp.Type);

            await _hubContext.Clients.All.SendAsync("ReceiveCustomerEquipementByType", data);




            var updatedEquip = await refreshRepository.GetProductsByCustomer(customer.Id);

            await _hubContext.Clients.All.SendAsync("Receivedcustomer", updatedEquip);

        }

    }
}

