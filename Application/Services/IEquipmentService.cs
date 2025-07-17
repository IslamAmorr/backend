using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IEquipmentService
    {
        //Task<List<CustomerDto>> GetAllEquipmentsAsync();
        Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync();
        Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId);

    }
}
