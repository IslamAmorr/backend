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
    public class HistoriqueAlertVigiRepository : IHistoriqueAlertVigiRepository
    {
        private readonly AirLiquideContext _context;

        public HistoriqueAlertVigiRepository(AirLiquideContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HistoriqueAlertVigiDto>> GetAlertesVigiByCustomerId(int customerId)
        {
            var query = from alert in _context.Alerts
                        join equip in _context.Equipment
                            on alert.Customer equals equip.Customer
                        join tankPump in _context.TankPumps
                            on equip.SerialNumber equals tankPump.Equipment
                        where alert.Customer == customerId
                        where alert.Customer == customerId
                              && equip.EquipmentType == "ViGi"
                        orderby alert.AcquisitionTime descending
                        select new HistoriqueAlertVigiDto
                        {
                            AcquisitionTime = alert.AcquisitionTime,
                            EquipmentName = tankPump.Name,
                            Voie1 = alert.Voie1,
                            Voie2 = alert.Voie2,
                            Voie3 = alert.Voie3,
                            Voie4 = alert.Voie4,
                            Voie5 = alert.Voie5,
                            Voie6 = alert.Voie6,
                            Voie7 = alert.Voie7,
                            NameVoie1 = tankPump.NameVoie1,
                            NameVoie2 = tankPump.NameVoie2,
                            NameVoie3 = tankPump.NameVoie3,
                            NameVoie4 = tankPump.NameVoie4,
                            NameVoie5 = tankPump.NameVoie5,
                            NameVoie6 = tankPump.NameVoie6,
                            NameVoie7 = tankPump.NameVoie7
                        };

            return await query.Take(10).ToListAsync();
        }

    }
}
