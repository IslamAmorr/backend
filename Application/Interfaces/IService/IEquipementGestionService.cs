using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IEquipementGestionService
    {
        Task<IEnumerable<EquipementDtooo>> GetAllAsync();
        Task<EquipementDtooo> GetByIdAsync(string id);
        Task<EquipementDtooo> AddAsync(EquipementDtooo entity);
        Task<EquipementDtooo> UpdateAsync(EquipementDtooo entity);
        Task DeleteAsync(string id);
        Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync();
        Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId);
    }
}
