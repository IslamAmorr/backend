using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IHistoriqueAlertVigiService
    {
        Task<IEnumerable<HistoriqueAlertVigiDto>> GetAlertesVigiByCustomerId(int customerId);

    }
}
