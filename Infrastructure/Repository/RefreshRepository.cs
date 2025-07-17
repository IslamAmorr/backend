using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Hubs;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;
using Humanizer;

namespace Infrastructure.Repository
{
    public class RefreshRepository : IRefreshRepository
    {


        private readonly AirLiquideContext dbContext;
        private readonly IMapper _mapper;

        public RefreshRepository( AirLiquideContext context, IMapper mapper)

        {
            _mapper = mapper;

            this.dbContext = context;
        }
        public async Task<List<RefreshDto>> GetRefreshes()
        {
            var refreshEntities = await dbContext.Refreshes.ToListAsync();
            return _mapper.Map<List<RefreshDto>>(refreshEntities);
        }

        public async Task<List<CustomerDto>> GetAllCustomer()
        {
            var refreshEntities = await dbContext.Customers.ToListAsync();
            return _mapper.Map<List<CustomerDto>>(refreshEntities);
        }
        public async Task<List<object>> GetActiveAlerts(string equipmentId)

        {
            var lastRefresh = await dbContext.Refreshes
                .Where(r => r.Equipment == equipmentId)
                .OrderByDescending(r => r.AcquisitionTime)
                .FirstOrDefaultAsync();

            if (lastRefresh == null) return new List<object>();

            var tp = await dbContext.TankPumps
                .FirstOrDefaultAsync(t => t.Equipment == equipmentId);

            if (tp == null) return new List<object>();



            var activeTypes = new List<int>();

            if (tp.Type == "T")
            {
                if (lastRefresh.Level1 < tp.VeryLowLevel) activeTypes.Add(12);
                else if (lastRefresh.Level1 < tp.LowLevel) activeTypes.Add(11);

                if (lastRefresh.Pressure1 > tp.VeryHighPression) activeTypes.Add(22);
                else if (lastRefresh.Pressure1 > tp.HighPression) activeTypes.Add(21);
                else if (lastRefresh.Pressure1 < tp.VeryLowPression) activeTypes.Add(24);
                else if (lastRefresh.Pressure1 < tp.LowPression) activeTypes.Add(23);
            }
            else if (tp.Type == "V")
            {
                if (lastRefresh.LastAlertType.HasValue && lastRefresh.LastAlertType != 0)
                {
                    activeTypes.Add(lastRefresh.LastAlertType.Value);
                }

                for (int i = 1; i <= 7; i++)
                {
                    var voieActive = (bool?)tp.GetType().GetProperty($"Voie{i}")?.GetValue(tp) == true;
                    var voieValue = (double?)lastRefresh.GetType().GetProperty($"Voie{i}")?.GetValue(lastRefresh);

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
            }
            else if (tp.Type == "D" || tp.Type == "A")
            {
                if (lastRefresh.PreAlarmTempPumpA == true) activeTypes.Add(2032);               // Pré-alarme température A
                if (lastRefresh.AuxiliaryFaultA == true) activeTypes.Add(2040);                 // Défaut auxiliaire A
                if (lastRefresh.DisjonctionFaultA == true) activeTypes.Add(2046);               // Défaut disjoncteur A
                if (lastRefresh.OilLvlFaultA == true) activeTypes.Add(40010);                   // Défaut niveau huile (Pression régulation hypothétique)
                if (lastRefresh.HighTempFaultA == true) activeTypes.Add(40400);                 // Défaut température haute
                if (lastRefresh.OffScaleTempPompA == true) activeTypes.Add(40106);              // Alarme hors échelle température
                if (lastRefresh.LowTempFaultA == true) activeTypes.Add(40200);                  // Défaut température basse
                if (lastRefresh.CompressorProblemAlarmA == true) activeTypes.Add(40002);        // Défaut compresseur A
                if (lastRefresh.TrapBekoProblemA == true) activeTypes.Add(40001);               // Défaut purgeur BEKO A (hypothétique)
                if (lastRefresh.DryerTemperatureProblemA == true) activeTypes.Add(40031);       // Défaut température base A
                if (lastRefresh.HygrometryLineA == true) activeTypes.Add(40800);                // Défaut hygrométrie ligne A


                // Défauts pompe B
                if (lastRefresh.PreAlarmTempPumpB == true) activeTypes.Add(2033);               // Pré-alarme température B
                if (lastRefresh.AuxiliaryFaultB == true) activeTypes.Add(2041);                 // Défaut auxiliaire B
                if (lastRefresh.DisjonctionFaultB == true) activeTypes.Add(2047);               // Défaut disjoncteur B
                if (lastRefresh.OilLvlFaultB == true) activeTypes.Add(40011);                   // Défaut niveau huile B (hypothétique)
                if (lastRefresh.HighTempFaultB == true) activeTypes.Add(40401);                 // Défaut température haute B
                if (lastRefresh.OffScaleTempPompB == true) activeTypes.Add(40107);              // Alarme hors échelle température B
                if (lastRefresh.LowTempFaultB == true) activeTypes.Add(40201);                  // Défaut température basse B
                if (lastRefresh.CompressorProblemAlarmB == true) activeTypes.Add(40003);        // Défaut compresseur B
                if (lastRefresh.TrapBekoProblemB == true) activeTypes.Add(40004);               // Défaut purgeur BEKO B
                if (lastRefresh.DryerTemperatureProblemB == true) activeTypes.Add(40032);       // Défaut température base B
                if (lastRefresh.HygrometryLineB == true) activeTypes.Add(40801);                // Défaut hygrométrie ligne B


                // Défauts pompe C
                if (lastRefresh.PreAlarmTempPumpC == true) activeTypes.Add(2034);               // Pré-alarme température C
                if (lastRefresh.AuxiliaryFaultC == true) activeTypes.Add(2042);                 // Défaut auxiliaire C
                if (lastRefresh.DisjonctionFaultC == true) activeTypes.Add(2048);               // Défaut disjoncteur C
                if (lastRefresh.OilLvlFaultC == true) activeTypes.Add(40012);                   // Défaut niveau huile C (hypothétique)
                if (lastRefresh.HighTempFaultC == true) activeTypes.Add(40402);                 // Défaut température haute C
                if (lastRefresh.OffScaleTempPompC == true) activeTypes.Add(40108);              // Alarme hors échelle température C
                if (lastRefresh.LowTempFaultC == true) activeTypes.Add(40202);                  // Défaut température basse C
                if (lastRefresh.CompressorProblemAlarmC == true) activeTypes.Add(40005);        // Défaut compresseur C
                if (lastRefresh.TrapBekoProblemC == true) activeTypes.Add(40006);               // Défaut purgeur BEKO C
                if (lastRefresh.DryerTemperatureProblemC == true) activeTypes.Add(40033);       // Défaut température base C
                if (lastRefresh.HygrometryLineC == true) activeTypes.Add(40802);                // Défaut hygrométrie ligne C

            

            }
        var activeDtos = new List<object>();
            foreach (var t in activeTypes)
            {
                var desc = await dbContext.AlertTypes
                    .Where(at => at.Id == t)
                    .Select(at => at.Description)
                    .FirstOrDefaultAsync() ?? "";

                activeDtos.Add(new
                {
                    AlertType = t,
                    Description = desc,
                    Level1 = lastRefresh.Level1,
                    Pressure1 = lastRefresh.Pressure1,
                    AcquisitionTime = lastRefresh.AcquisitionTime,
                    EquipmentType = tp.Type,
                    Voie1 = lastRefresh.Voie1,
                    Voie2 = lastRefresh.Voie2,
                    Voie3 = lastRefresh.Voie3,
                    Voie4 = lastRefresh.Voie4,
                    Voie5 = lastRefresh.Voie5,
                    Voie6 = lastRefresh.Voie6,
                    Voie7 = lastRefresh.Voie7,
                    NameVoie1 = tp.NameVoie1,
                    NameVoie2 = tp.NameVoie2,
                    NameVoie3 = tp.NameVoie3,
                    NameVoie4 = tp.NameVoie4,
                    NameVoie5 = tp.NameVoie5,
                    NameVoie6 = tp.NameVoie6,
                    NameVoie7 = tp.NameVoie7,

                   TempPompA = lastRefresh.TempPompA,
                   HourCounterPompA = lastRefresh.HourCounterPompA,

                    TempPompB = lastRefresh.TempPompB,
                    HourCounterPompB = lastRefresh.HourCounterPompB,

                    TempPompC = lastRefresh.TempPompC,
                    HourCounterPompC = lastRefresh.HourCounterPompC,

                    TempPompD = lastRefresh.TempPompD,
                    HourCounterPompD = lastRefresh.HourCounterPompD,


                });
            }

            return activeDtos;
        }
        public async Task<List<object>> GetLatestAlerts(  string equipmentId,DateTime? startDate = null,DateTime? endDate = null, int count = 10)
        {
            var query = dbContext.Alerts
                .Where(a => a.Equipment == equipmentId && a.AlertType != -5) ;

            if (startDate.HasValue)
                query = query.Where(a => a.AcquisitionTime >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(a => a.AcquisitionTime <= endDate.Value);

            var alerts = await query
                .OrderByDescending(a => a.AcquisitionTime)
                .Take(count)
                .Join(
                    dbContext.TankPumps,
                    alert => alert.Equipment,
                    tank => tank.Equipment,
                    (alert, tank) => new { Alert = alert, Tank = tank }

                )
                .Join(
                    dbContext.Customers,
                    alertTank => alertTank.Tank.Customer,
                    customer => customer.Id,
                    (alertTank, customer) => new { alertTank.Alert, alertTank.Tank, CustomerName = customer.Name }
                )
                .ToListAsync();

            var alertTypeDescriptions = await dbContext.AlertTypes
                .ToDictionaryAsync(at => at.Id, at => at.Description);

            var result = new List<object>();

            foreach (var item in alerts)
            {
                object dto;

                if (item.Tank.Type == "T") 
                {
                    var divaDto = _mapper.Map<AlertDivaDto>(item.Alert);
                    if (divaDto != null)
                    {
                        divaDto.Pressure1 = item.Alert.Pressure1;
                        divaDto.Level1 = item.Alert.Level1;
                    }
                    divaDto.EquipmentType = item.Tank.Type;
                    divaDto.Customer = item.Tank.Customer;
                    divaDto.CustomerName = item.CustomerName;
                    divaDto.EquipmentName = item.Tank.Name;
                    divaDto.Description = alertTypeDescriptions.TryGetValue(item.Alert.AlertType, out var desc) ? desc : "N/A";

                    dto = divaDto;
                }
                else if (item.Tank.Type == "V") // VIGI
                {
                    var vigiDto = _mapper.Map<AlertVigiDto>(item.Alert);
                    if (vigiDto != null)
                    {
                        vigiDto.Voie1 = item.Alert.Voie1;
                        vigiDto.Voie2 = item.Alert.Voie2;
                        vigiDto.Voie3 = item.Alert.Voie3;
                        vigiDto.Voie4 = item.Alert.Voie4;
                        vigiDto.Voie5 = item.Alert.Voie5;
                        vigiDto.Voie6 = item.Alert.Voie6;
                        vigiDto.Voie7 = item.Alert.Voie7;
                    }

                    vigiDto.NameVoie1 = item.Tank.NameVoie1;
                    vigiDto.NameVoie2 = item.Tank.NameVoie2;
                    vigiDto.NameVoie3 = item.Tank.NameVoie3;
                    vigiDto.NameVoie4 = item.Tank.NameVoie4;
                    vigiDto.NameVoie5 = item.Tank.NameVoie5;
                    vigiDto.NameVoie6 = item.Tank.NameVoie6;
                    vigiDto.NameVoie7 = item.Tank.NameVoie7;

                    vigiDto.EquipmentType = item.Tank.Type;
                    vigiDto.Customer = item.Tank.Customer;
                    vigiDto.CustomerName = item.CustomerName;
                    vigiDto.EquipmentName = item.Tank.Name;
                    vigiDto.Description = alertTypeDescriptions.TryGetValue(item.Alert.AlertType, out var desc) ? desc : "N/A";

                    dto = vigiDto;
                }

                else if (item.Tank.Type == "A" || item.Tank.Type == "D")
                {
                    var pumpDto = _mapper.Map<AlertDto>(item.Alert);
                    if (pumpDto != null)
                    {
                        pumpDto.TempPompA = item.Alert.TempPompA;
                        pumpDto.HourCounterPompA = item.Alert.HourCounterPompA;
                        pumpDto.TempPompB = item.Alert.TempPompB;
                        pumpDto.HourCounterPompB = item.Alert.HourCounterPompB;
                        pumpDto.TempPompC = item.Alert.TempPompC;
                        pumpDto.HourCounterPompC = item.Alert.HourCounterPompC;
                        pumpDto.TempPompD = item.Alert.TempPompD;
                        pumpDto.HourCounterPompD = item.Alert.HourCounterPompD;

                    }

                    pumpDto.EquipmentType = item.Tank.Type;
                    pumpDto.Customer = item.Tank.Customer;
                    pumpDto.CustomerName = item.CustomerName;
                    pumpDto.EquipmentName = item.Tank.Name;
                    pumpDto.Description = alertTypeDescriptions.TryGetValue(item.Alert.AlertType, out var desc) ? desc : "N/A";

                    dto = pumpDto;
                }


                else
                {
                    var baseDto = _mapper.Map<AlertDto>(item.Alert);
                    baseDto.EquipmentType = item.Tank.Type;
                    baseDto.Customer = item.Tank.Customer;
                    baseDto.CustomerName = item.CustomerName;
                    baseDto.EquipmentName = item.Tank.Name;
                    baseDto.Description = alertTypeDescriptions.TryGetValue(item.Alert.AlertType, out var desc) ? desc : "N/A";

                    dto = baseDto;
                }

                result.Add(dto);
            }

            return result;
        }

        public async Task<RefreshCLientDto?> GetProductsByCustomer(int customerId)
        {
            var data = await (
                from refresh in dbContext.Refreshes
                join tank in dbContext.TankPumps on refresh.Equipment equals tank.Equipment
                join customer in dbContext.Customers on refresh.Customer equals customer.Id
                where customer.Id == customerId
                select new
                {
                    CustomerId = customer.Id,
                    CustomerName = customer.Name,
                    refresh.Equipment,
                    refresh.AcquisitionTime,
                    tank.Type,
                    EquipmentName = tank.Name,
                    refresh.Pressure1,
                    refresh.Level1,
                    refresh.TempPompA,
                    refresh.HourCounterPompA,
                    refresh.TempPompB,
                    refresh.HourCounterPompB,
                    refresh.TempPompC,
                    refresh.HourCounterPompC,
                    refresh.TempPompD,
                    refresh.HourCounterPompD,
                    refresh.Voie1,
                    refresh.Voie2,
                    refresh.Voie3,
                    refresh.Voie4,
                    refresh.Voie5,
                    refresh.Voie6,
                    refresh.Voie7,
                    tank.NameVoie1,
                    tank.NameVoie2,
                    tank.NameVoie3,
                    tank.NameVoie4,
                    tank.NameVoie5,
                    tank.NameVoie6,
                    tank.NameVoie7
                }
            ).ToListAsync();

            if (!data.Any()) return null;

            var result = new RefreshCLientDto
            {
                CustomerId = data.First().CustomerId,
                CustomerName = data.First().CustomerName,
                Equipements = data.Select(item =>
                {
                    if (item.Type == "T")
                    {
                        return new RefreshDto
                        {
                            Equipment = item.Equipment,
                            AcquisitionTime = item.AcquisitionTime,
                            EquipmentType = item.Type,
                            EquipmentName = item.EquipmentName,
                            Pressure1 = item.Pressure1,
                            Level1 = item.Level1
                        };
                    }
                    else if (item.Type == "V")
                    {
                        return new RefreshDto
                        {
                            Equipment = item.Equipment,
                            AcquisitionTime = item.AcquisitionTime,
                            EquipmentType = item.Type,
                            EquipmentName = item.EquipmentName,
                            Voie1 = item.Voie1,
                            Voie2 = item.Voie2,
                            Voie3 = item.Voie3,
                            Voie4 = item.Voie4,
                            Voie5 = item.Voie5,
                            Voie6 = item.Voie6,
                            Voie7 = item.Voie7,
                            NameVoie1 = item.NameVoie1,
                            NameVoie2 = item.NameVoie2,
                            NameVoie3 = item.NameVoie3,
                            NameVoie4 = item.NameVoie4,
                            NameVoie5 = item.NameVoie5,
                            NameVoie6 = item.NameVoie6,
                            NameVoie7 = item.NameVoie7
                        };
                    }
                    else if (item.Type == "A" || item.Type == "D")
                    {
                        return new RefreshDto
                        {
                            Equipment = item.Equipment,
                            AcquisitionTime = item.AcquisitionTime,
                            EquipmentType = item.Type,
                            EquipmentName = item.EquipmentName,
                            TempPompA = item.TempPompA,
                            HourCounterPompA = item.HourCounterPompA,
                            TempPompB = item.TempPompB,
                            HourCounterPompB = item.HourCounterPompB,
                            TempPompC = item.TempPompC,
                            HourCounterPompC = item.HourCounterPompC,
                            TempPompD = item.TempPompD,
                            HourCounterPompD = item.HourCounterPompD
                        };
                    }
                    else
                    {
                        return null;
                    }
                })
                .Where(e => e != null)
                .ToList()
            };

            return result;
        }



        public async Task<RefreshDto> GetEquipementById(string equipmentId)
        {
            var data = await (from r in dbContext.Refreshes
                              join tp in dbContext.TankPumps on r.Equipment equals tp.Equipment
                              join c in dbContext.Customers on r.Customer equals c.Id
                              where r.Equipment == equipmentId
                              select new
                              {
                                  r.Equipment,
                                  r.AcquisitionTime,
                                  r.Latitude,
                                  r.Longitude,
                                  tp.Type,
                                  r.Customer,
                                  tp.Name,
                                  CustomerName = c.Name,
                                  r.Pressure1,
                                  r.Level1,
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
                                  r.HourCounterPompD
                              }).FirstOrDefaultAsync();

            if (data == null)
                return null;

            if (data.Type == "T")
            {
                return new RefreshDto
                {
                    Equipment = data.Equipment,
                    AcquisitionTime = data.AcquisitionTime,

                    EquipmentType = data.Type,
                    EquipmentName = data.Name,
                    Pressure1 = data.Pressure1,
                    Level1 = data.Level1
                };
            }
            else if (data.Type == "V")
            {
                return new RefreshDto
                {
                    Equipment = data.Equipment,
                    AcquisitionTime = data.AcquisitionTime,
                    EquipmentType = data.Type,
                    EquipmentName = data.Name,
                    Voie1 = data.Voie1,
                    Voie2 = data.Voie2,
                    Voie3 = data.Voie3,
                    Voie4 = data.Voie4,
                    Voie5 = data.Voie5,
                    Voie6 = data.Voie6,
                    Voie7 = data.Voie7,
                    NameVoie1 = data.NameVoie1,
                    NameVoie2 = data.NameVoie2,
                    NameVoie3 = data.NameVoie3,
                    NameVoie4 = data.NameVoie4,
                    NameVoie5 = data.NameVoie5,
                    NameVoie6 = data.NameVoie6,
                    NameVoie7 = data.NameVoie7
                };
            }
            else if (data.Type == "A" || data.Type == "D")
            {
                return new RefreshDto
                {
                    Equipment = data.Equipment,
                    AcquisitionTime = data.AcquisitionTime,
                    EquipmentType = data.Type,
                    EquipmentName = data.Name,
                    TempPompA = data.TempPompA,
                    HourCounterPompA = data.HourCounterPompA,
                    TempPompB = data.TempPompB,
                    HourCounterPompB = data.HourCounterPompB,
                    TempPompC = data.TempPompC,
                    HourCounterPompC = data.HourCounterPompC,
                    TempPompD = data.TempPompD,
                    HourCounterPompD = data.HourCounterPompD,

                };
            }

            return null;
        }
        public async Task<List<RefreshCLientDto>> GetProductsForAllCustomers()
        {
            var data = await (from r in dbContext.Refreshes
                              join tp in dbContext.TankPumps on r.Equipment equals tp.Equipment
                              join c in dbContext.Customers on tp.Customer equals c.Id
                              select new
                              {
                                  CustomerId = c.Id,
                                  CustomerName = c.Name,
                                  r.Equipment,
                                  r.AcquisitionTime,
                                  r.Latitude,
                                  r.Longitude,
                                  tp.Type,
                                  tp.Name,
                                  r.Pressure1,
                                  r.Level1,
                                  r.Voie1,
                                  r.Voie2,
                                  r.Voie3,
                                  r.Voie4,
                                  r.Voie5,
                                  r.Voie6,
                                  r.Voie7,
                                  r.TempPompA,
                                  r.HourCounterPompA,
                                  r.TempPompB,
                                  r.HourCounterPompB,
                                  r.TempPompC,
                                  r.HourCounterPompC,
                                  r.TempPompD,
                                  r.HourCounterPompD,
                                  tp.NameVoie1,
                                  tp.NameVoie2,
                                  tp.NameVoie3,
                                  tp.NameVoie4,
                                  tp.NameVoie5,
                                  tp.NameVoie6,
                                  tp.NameVoie7,
                              }).ToListAsync();

            var grouped = data
                .GroupBy(d => new { d.CustomerId, d.CustomerName })
                .Select(g => new RefreshCLientDto
                {
                    CustomerId = g.Key.CustomerId,
                    CustomerName = g.Key.CustomerName,
                    Equipements = g.Select(d =>
                    {
                        if (d.Type == "T")
                        {
                            return new RefreshDto
                            {
                                Equipment = d.Equipment,
                                AcquisitionTime = d.AcquisitionTime,
                                EquipmentType = d.Type,
                                EquipmentName = d.Name,
                                Pressure1 = d.Pressure1,
                                Level1 = d.Level1
                            };
                        }
                        else if (d.Type == "V")
                        {
                            return new RefreshDto
                            {
                                Equipment = d.Equipment,
                                AcquisitionTime = d.AcquisitionTime,
                                EquipmentType = d.Type,
                                EquipmentName = d.Name,
                                Voie1 = d.Voie1,
                                Voie2 = d.Voie2,
                                Voie3 = d.Voie3,
                                Voie4 = d.Voie4,
                                Voie5 = d.Voie5,
                                Voie6 = d.Voie6,
                                Voie7 = d.Voie7,
                                NameVoie1 = d.NameVoie1,
                                NameVoie2 = d.NameVoie2,
                                NameVoie3 = d.NameVoie3,
                                NameVoie4 = d.NameVoie4,
                                NameVoie5 = d.NameVoie5,
                                NameVoie6 = d.NameVoie6,
                                NameVoie7 = d.NameVoie7
                            };
                        }
                        else if (d.Type == "A" || d.Type == "D")
                        {
                            return new RefreshDto
                            {
                                Equipment = d.Equipment,
                                AcquisitionTime = d.AcquisitionTime,
                                EquipmentType = d.Type,
                                EquipmentName = d.Name,
                                TempPompA = d.TempPompA,
                                HourCounterPompA = d.HourCounterPompA,
                                TempPompB = d.TempPompB,
                                HourCounterPompB = d.HourCounterPompB,
                                TempPompC = d.TempPompC,
                                HourCounterPompC = d.HourCounterPompC,
                                TempPompD = d.TempPompD,
                                HourCounterPompD = d.HourCounterPompD,
                            };
                        }

                        return null;
                    }).Where(x => x != null).ToList()
                }).ToList();

            return grouped;
        }


        public async Task<List<RefreshDto>> GetProductsByTypeForAllCustomers(string type)
        {
            var query = from refresh in dbContext.Refreshes
                        join tank in dbContext.TankPumps on refresh.Equipment equals tank.Equipment
                        join customer in dbContext.Customers on refresh.Customer equals customer.Id
                        select new
                        {
                            refresh.Equipment,
                            refresh.AcquisitionTime,
                            tank.Type,
                            tank.Name,
                            Customer = customer.Id,
                            CustomerName = customer.Name,
                            Adress = customer.Adress,
                            refresh.Level1,
                            refresh.Pressure1,
                            refresh.Voie1,
                            refresh.Voie2,
                            refresh.Voie3,
                            refresh.Voie4,
                            refresh.Voie5,
                            refresh.Voie6,
                            refresh.Voie7,
                            refresh.TempPompA,
                            refresh.HourCounterPompA,
                            refresh.TempPompB,
                            refresh.HourCounterPompB,
                            refresh.TempPompC,
                            refresh.HourCounterPompC,
                            refresh.TempPompD,
                            refresh.HourCounterPompD,
                            tank.NameVoie1,
                            tank.NameVoie2,
                            tank.NameVoie3,
                            tank.NameVoie4,
                            tank.NameVoie5,
                            tank.NameVoie6,
                            tank.NameVoie7
                        };

            if (!string.IsNullOrEmpty(type) && type.ToLower() != "tous")
            {
                query = query.Where(q => q.Type == type);
            }

            var data = await query.ToListAsync();

            var results = data.Select(d =>
            {
                if (d.Type == "T" && d.Level1 != null && d.Pressure1 != null)
                {
                    return new RefreshDto
                    {
                        Equipment = d.Equipment,
                        Customer = d.Customer,
                        Adress = d.Adress,
                        AcquisitionTime = d.AcquisitionTime,
                        EquipmentType = d.Type,
                        EquipmentName = d.Name,
                        Pressure1 = d.Pressure1,
                        Level1 = d.Level1,
                        CustomerName = d.CustomerName
                    };
                }
                else if (d.Type == "V")
                {
                    bool allVoiesNull = d.Voie1 == null && d.Voie2 == null && d.Voie3 == null &&
                                        d.Voie4 == null && d.Voie5 == null && d.Voie6 == null && d.Voie7 == null;

                    if (allVoiesNull)
                    {
                        return null;
                    }

                    return new RefreshDto
                    {
                        Equipment = d.Equipment,
                        Customer = d.Customer,
                        Adress = d.Adress,
                        AcquisitionTime = d.AcquisitionTime,
                        EquipmentType = d.Type,
                        EquipmentName = d.Name,
                        Voie1 = d.Voie1,
                        Voie2 = d.Voie2,
                        Voie3 = d.Voie3,
                        Voie4 = d.Voie4,
                        Voie5 = d.Voie5,
                        Voie6 = d.Voie6,
                        Voie7 = d.Voie7,
                        NameVoie1 = d.NameVoie1,
                        NameVoie2 = d.NameVoie2,
                        NameVoie3 = d.NameVoie3,
                        NameVoie4 = d.NameVoie4,
                        NameVoie5 = d.NameVoie5,
                        NameVoie6 = d.NameVoie6,
                        NameVoie7 = d.NameVoie7,
                        CustomerName = d.CustomerName
                    };
                }
                else if ((d.Type == "A" || d.Type == "D") && d.TempPompA != null && d.HourCounterPompA != null)
                {
                    return new RefreshDto
                    {
                        Equipment = d.Equipment,
                        Customer = d.Customer,
                        Adress = d.Adress,
                        AcquisitionTime = d.AcquisitionTime,
                        EquipmentType = d.Type,
                        EquipmentName = d.Name,
                        TempPompA = d.TempPompA,
                        HourCounterPompA = d.HourCounterPompA,
                        TempPompB = d.TempPompB,
                        HourCounterPompB = d.HourCounterPompB,
                        TempPompC = d.TempPompC,
                        HourCounterPompC = d.HourCounterPompC,
                        TempPompD = d.TempPompD,
                        HourCounterPompD = d.HourCounterPompD,
                        CustomerName = d.CustomerName
                    };
                }

                return null;
            }).Where(r => r != null).ToList();

            return results;
        }






    }
}
