using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository
{
    public interface IAlertRepository
    {
        Task SaveAlertsAsync(Refresh refresh, List<int> alertTypes);
        //Task<List<AlertDto>> GetActiveAlertsAsync(string equipmentId);

        Task<IEnumerable<AlertDto>> GetByEquipmentAsync(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10);
        List<int> DetectAlertTypes(Refresh refresh, TankPump config);
        Task<List<AlertCountByEquipmentDto>> GetAlertCountsForCustomerAsync(int customerId);
        Task<List<CustomerDto>> GetAllCustomersAsync();
        Task<List<AlertCountByEquipmentDto>> GetAlertCountsByCustomerAsync(int customerId);




    }
}
