using Application.Interfaces.IRepository;
using Domain.DTOs;
using Domain.models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;
using Infrastructure.Hubs;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using AutoMapper;
using System.Data.SqlTypes;

namespace Infrastructure.Repository
{
    public class AlertRepository : IAlertRepository

    {
        private readonly AlertHub _hubContext;

        private readonly AirLiquideContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IDictionary<string, TankPump> _equipmentConfigs; 

        public AlertRepository(AirLiquideContext dbContext, IMapper mapper, IDictionary<string, TankPump> equipmentConfigs, AlertHub alertHub)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _equipmentConfigs = equipmentConfigs;
            _hubContext = alertHub;
        }
        public async Task<IEnumerable<AlertDto>> GetByEquipmentAsync(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10)
        {
            var query = from a in _dbContext.Alerts
                        join t in _dbContext.AlertTypes on a.AlertType equals t.Id
                        join tp in _dbContext.TankPumps on a.Equipment equals tp.Equipment
                        where t != null
                        select new { a, t.Description, tp };

            var results = await query.ToListAsync();

            var alertDtos = new List<AlertDto>();

            foreach (var item in results)
            {
                AlertDto dto;

                if (item.tp.Type == "DIVA")
                {
                    dto = new AlertDivaDto
                    {
                        Level1 = item.a.Level1,
                        Pressure1 = item.a.Pressure1
                    };
                }
                else if (item.tp.Type == "VIGI")
                {
                    dto = new AlertVigiDto
                    {
                        Voie1 = item.a.Voie1,
                        Voie2 = item.a.Voie2,
                        Voie3 = item.a.Voie3,
                        Voie4 = item.a.Voie4,
                        Voie5 = item.a.Voie5,
                        Voie6 = item.a.Voie6,
                        Voie7 = item.a.Voie7,
                        NameVoie1 = item.tp.NameVoie1,
                        NameVoie2 = item.tp.NameVoie2,
                        NameVoie3 = item.tp.NameVoie3,
                        NameVoie4 = item.tp.NameVoie4,
                        NameVoie5 = item.tp.NameVoie5,
                        NameVoie6 = item.tp.NameVoie6,
                        NameVoie7 = item.tp.NameVoie7
                    };
                }
                else
                {
                    dto = new AlertDto();
                }

                dto.Id = item.a.Id;
                dto.AcquisitionTime = item.a.AcquisitionTime;
                dto.AlertType = item.a.AlertType;
                dto.Description = item.Description;
                dto.Equipment = item.a.Equipment;

                dto.Customer = item.a.Customer;
                dto.EquipmentType = item.tp.Type;

                alertDtos.Add(dto);
            }

            return alertDtos;
        }

        public List<int> DetectAlertTypes(Refresh refresh, TankPump config)
        {
            var alertTypes = new List<int>();

            if (refresh.Level1 < config.VeryLowLevel) alertTypes.Add(2);
            else if (refresh.Level1 < config.LowLevel) alertTypes.Add(1);

            if (refresh.Pressure1 > config.VeryHighPression) alertTypes.Add(4); 
            else if (refresh.Pressure1 > config.HighPression) alertTypes.Add(3);

            if (refresh.Pressure1 < config.VeryLowPression) alertTypes.Add(6); 
            else if (refresh.Pressure1 < config.LowPression) alertTypes.Add(5); 

            return alertTypes;
        }
        public async Task<List<AlertCountByEquipmentDto>> GetAlertCountsByCustomerAsync(int customerId)
        {
            var result = await (
                from alert in _dbContext.Alerts
                join equipment in _dbContext.Equipment
                    on alert.Equipment equals equipment.SerialNumber
                where alert.Customer == customerId
                group alert by new { equipment.SerialNumber, equipment.EquipmentType } into grouped
                select new AlertCountByEquipmentDto
                {
                    //EquipmentName = grouped.Key.SerialNumber,
                    EquipmentType = grouped.Key.EquipmentType,
                    AlertCount = grouped.Count()
                }
            ).ToListAsync();

            return result;
        }
        public async Task<List<AlertCountByEquipmentDto>> GetAlertCountsForCustomerAsync(int customerId)
        {
            var result = await (
                from alert in _dbContext.Alerts
                join equipment in _dbContext.Equipment
                    on alert.Equipment equals equipment.SerialNumber
                where alert.Customer == customerId
                group alert by new { equipment.SerialNumber, equipment.EquipmentType } into grouped
                select new AlertCountByEquipmentDto
                {
                    EquipmentType = grouped.Key.EquipmentType,
                    AlertCount = grouped.Count()
                }
            ).ToListAsync();

            return result;
        }
        public async Task<List<CustomerDto>> GetAllCustomersAsync()
        {
            return await _dbContext.Customers
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }
        //public async Task<List<AlertDto>> GetActiveAlertsAsync(string equipmentId)
        //{
        //    // Dernières données du refresh
        //    var refresh = await _dbContext.Refreshes
        //        .FirstOrDefaultAsync(r => r.Equipment == equipmentId);

        //    if (refresh == null) return new List<AlertDto>();

        //    // Récupération des seuils réels depuis TankPump
        //    var config = await _dbContext.TankPumps
        //        .FirstOrDefaultAsync(t => t.Equipment == equipmentId);

        //    if (config == null) return new List<AlertDto>();

        //    // Liste des alertes existantes de cet équipement
        //    var existingAlerts = await (
        //        from a in _dbContext.Alerts
        //        join at in _dbContext.AlertTypes on a.AlertType equals at.Id
        //        where a.Equipment == equipmentId
        //        select new { a, at }
        //    ).ToListAsync();

        //    var stillActive = new List<AlertDto>();

        //    foreach (var alert in existingAlerts)
        //    {
        //        bool isStillActive = alert.a.AlertType switch
        //        {
        //            1 => refresh.Level1 < config.LowLevel,
        //            2 => refresh.Level1 < config.VeryLowLevel,
        //            3 => refresh.Pressure1 > config.HighPression,
        //            4 => refresh.Pressure1 > config.VeryHighPression,
        //            5 => refresh.Pressure1 < config.LowPression,
        //            6 => refresh.Pressure1 < config.VeryLowPression,
        //            _ => false
        //        };

        //        if (isStillActive)
        //        {
        //            stillActive.Add(new AlertDto
        //            {
        //                Id = alert.a.Id,
        //                Equipment = alert.a.Equipment,
        //                AcquisitionTime = alert.a.AcquisitionTime,
        //                AlertType = alert.a.AlertType,
        //                Description = alert.at.Description,
        //                Level1 = alert.a.Level1,
        //                Pressure1 = alert.a.Pressure1,
        //                Latitude = alert.a.Latitude,
        //                Longitude = alert.a.Longitude
        //            });
        //        }
        //    }

        //    return stillActive;
        //}



        public async Task SaveAlertsAsync(Refresh refresh, List<int> alertTypes)
        {
            var tankPump = await _dbContext.TankPumps
                .FirstOrDefaultAsync(t => t.Equipment == refresh.Equipment);

            if (tankPump == null) return;

            var acquisitionTime = refresh.AcquisitionTime < SqlDateTime.MinValue.Value
                ? DateTime.Now
                : refresh.AcquisitionTime;

            foreach (var alertType in alertTypes)
            {
                var alert = new Alert
                {
                    AcquisitionTime = acquisitionTime,
                    AlertType = alertType,
                    Equipment = refresh.Equipment,
                    Latitude = refresh.Latitude,
                    Longitude = refresh.Longitude,
                    Customer = tankPump.Customer,
                    Level1 = refresh.Level1,
                    Pressure1 = refresh.Pressure1
                };
                _dbContext.Alerts.Add(alert);
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task NotifyClientsAboutAlert(AlertDto alert)
        {
            await _hubContext.Clients.Group(alert.Equipment).SendAsync("ReceiveAlert", alert);
        }

  
    }
}