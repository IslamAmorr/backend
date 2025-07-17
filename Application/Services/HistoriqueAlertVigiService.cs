using Application.Interfaces.IRepository;
using Application.Interfaces.IService;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class HistoriqueAlertVigiService : IHistoriqueAlertVigiService
    {
        private readonly IHistoriqueAlertVigiRepository _repository;

        // Injecter le repository ici, pas le service lui-même
        public HistoriqueAlertVigiService(IHistoriqueAlertVigiRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<HistoriqueAlertVigiDto>> GetAlertesVigiByCustomerId(int customerId)
        {
            return await _repository.GetAlertesVigiByCustomerId(customerId);
        }
    }
}
