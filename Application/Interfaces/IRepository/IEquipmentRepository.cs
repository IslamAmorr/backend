using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository
{
    public interface IEquipmentRepository : IGenericRepository<Equipment>

    {
        Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync();
        Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId);


    }
}
