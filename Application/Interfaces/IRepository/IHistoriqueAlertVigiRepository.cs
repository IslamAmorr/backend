using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository
{
    public interface IHistoriqueAlertVigiRepository
    {
        Task<IEnumerable<HistoriqueAlertVigiDto>> GetAlertesVigiByCustomerId(int customerId);

    }
}
