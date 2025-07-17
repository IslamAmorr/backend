using Application.Interfaces.IRepository;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _repository;

        public EquipmentService(IEquipmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync()
        {
            return await _repository.GetCustomerEquipementsAsync();

        }

        public async Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId)
        {
            return await _repository.GetCustomerEquipementsByIdAsync(customerId);
        }
    }
}
