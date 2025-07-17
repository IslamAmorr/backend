using Application.Interfaces.IRepository;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public class HistoriqueAlerteDivaService : IHistoriqueAlerteDivaService
    {
        private readonly IHistoriqueAlerteDivaRepository _repository;

        public HistoriqueAlerteDivaService(IHistoriqueAlerteDivaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<HistoriqueAlerteDivaDto>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<List<HistoriqueAlerteDivaDto>> GetAllByCustomerIdAsync(int customerId)
        {
            return await _repository.GetAllByCustomerIdAsync(customerId);
        }
    }
}
