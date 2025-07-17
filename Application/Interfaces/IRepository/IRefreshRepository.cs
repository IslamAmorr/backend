using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository
{
    public interface IRefreshRepository
    {
        Task<List<RefreshDto>> GetRefreshes();

        Task<RefreshCLientDto> GetProductsByCustomer(int id);

        Task<List<object>> GetLatestAlerts(string equipmentId, DateTime? startDate, DateTime? endDate, int count);

        Task<RefreshDto> GetEquipementById(string equipmentId);

        Task<List<RefreshCLientDto>> GetProductsForAllCustomers();
        Task<List<RefreshDto>> GetProductsByTypeForAllCustomers(string type);

        Task<List<CustomerDto>> GetAllCustomer();
        Task<List<object>> GetActiveAlerts(string equipmentId);
      //  Task<List<RefreshDto>> GetProducts();



    }
}
