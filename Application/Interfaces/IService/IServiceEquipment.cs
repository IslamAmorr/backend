using Application.Interfaces.IServices;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IServiceEquipment : IService<EquipementDtooo, string>
    {
        Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync();
        Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId);
    }
}
