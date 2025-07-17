using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IRefreshService
    {
        Task<List<RefreshDto>> GetRefreshes();
        Task<List<CustomerDto>> GetAllCustomers();
        Task<List<object>> GetActiveAlerts(string equipmentId);
        Task<List<object>> GetLatestAlerts(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10);
        Task<RefreshCLientDto?> GetProductsByCustomer(int customerId);
        Task<RefreshDto> GetEquipmentById(string equipmentId);
        Task<List<RefreshCLientDto>> GetProductsForAllCustomers();
        Task<List<RefreshDto>> GetProductsByTypeForAllCustomers(string type);
    }
}