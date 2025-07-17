using Application.Interfaces.IRepository;
using Application.Interfaces.IService;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{

    public class RefreshService : IRefreshService
    {
        private readonly IRefreshRepository _refreshRepository;
        private readonly IMapper _mapper;

        public RefreshService(IRefreshRepository refreshRepository, IMapper mapper)
        {
            _refreshRepository = refreshRepository;
            _mapper = mapper;
        }

        public async Task<List<RefreshDto>> GetRefreshes()
        {
            return await _refreshRepository.GetRefreshes();
        }

        public async Task<List<CustomerDto>> GetAllCustomers()
        {
            return await _refreshRepository.GetAllCustomer();
        }

        public async Task<List<object>> GetActiveAlerts(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10)
        {
            return await _refreshRepository.GetLatestAlerts(equipmentId,startDate,endDate,count);
        }
        
        public async Task<List<object>> GetLatestAlerts(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10)
        {
            return await _refreshRepository.GetLatestAlerts(equipmentId, startDate, endDate, count);
        }

        public async Task<RefreshCLientDto?> GetProductsByCustomer(int customerId)
        {
            return await _refreshRepository.GetProductsByCustomer(customerId);
        }

        public async Task<RefreshDto> GetEquipmentById(string equipmentId)
        {
            return await _refreshRepository.GetEquipementById(equipmentId);
        }

        public async Task<List<RefreshCLientDto>> GetProductsForAllCustomers()
        {
            return await _refreshRepository.GetProductsForAllCustomers();
        }

        public async Task<List<RefreshDto>> GetProductsByTypeForAllCustomers(string type)
        {
            return await _refreshRepository.GetProductsByTypeForAllCustomers(type);
        }

        public async Task<List<object>> GetActiveAlerts(string equipmentId)
        {
            return await _refreshRepository.GetActiveAlerts(equipmentId);
        }
    }
}
