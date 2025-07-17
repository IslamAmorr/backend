using Application.Interfaces.IRepository;
using Domain.DTOs;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{

    public class HistoriqueAlerteDivaRepository : IHistoriqueAlerteDivaRepository
    {
        private readonly AirLiquideContext _context;

        public HistoriqueAlerteDivaRepository(AirLiquideContext context)
        {
            _context = context;
        }


        public async Task<List<HistoriqueAlerteDivaDto>> GetAllAsync()
        {
            return await _context.Alerts
                .Select(alert => new HistoriqueAlerteDivaDto
                {
                    AcquisitionTime = alert.AcquisitionTime,
                    EquipmentName = alert.Equipment, // ou alert.EquipmentName selon le nom réel
                    Level1 = alert.Level1,
                    Pressure1 = alert.Pressure1
                })
                .ToListAsync();
        }
        public async Task<List<HistoriqueAlerteDivaDto>> GetAllByCustomerIdAsync(int customerId)
        {
            var query = from alert in _context.Alerts
                        join equip in _context.Equipment
                            on alert.Customer equals equip.Customer
                        join tankPump in _context.TankPumps
                            on equip.SerialNumber equals tankPump.Equipment
                        where alert.Customer == customerId
                        orderby alert.AcquisitionTime descending
                        select new HistoriqueAlerteDivaDto
                        {
                            AcquisitionTime = alert.AcquisitionTime,
                            EquipmentName = tankPump.Name,
                            Level1 = alert.Level1,
                            Pressure1 = alert.Pressure1
                        };

            return await query.Take(10).ToListAsync();
        }



    }
}
