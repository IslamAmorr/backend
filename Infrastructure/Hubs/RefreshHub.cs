using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Infrastructure.Hubs
{
    public class RefreshHub : Hub
    {
        private readonly RefreshRepository _refreshRepository;
        private readonly AirLiquideContext _dbContext;
        private readonly IMapper _mapper;

        public RefreshHub(IConfiguration configuration, AirLiquideContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _refreshRepository = new RefreshRepository( dbContext, mapper);
        }

        public async Task SubscribeToEquipmentByType(string type)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, type.ToString());

            var customer = await _refreshRepository.GetProductsByTypeForAllCustomers(type);

            await Clients.Caller.SendAsync("ReceivedEquipementType", customer);
        }

        //await Clients.Group(type).SendAsync("ReceivedEquipementType", customer);
        public async Task GetCustomerEquipementByType(string type)
        {
            var data = await _refreshRepository.GetProductsByTypeForAllCustomers(type);
            await Clients.Caller.SendAsync("ReceiveCustomerEquipementByType", data);
        }

        // Pour envoyer à tout le monde (depuis service, table dependency, etc.)
        public async Task SendCustomerEquipementByType(string type)
        {
            var data = await _refreshRepository.GetProductsByTypeForAllCustomers(type);
            await Clients.All.SendAsync("ReceiveCustomerEquipementByType", data);
        }

        public async Task<List<RefreshCLientDto>> GetAllCustomer()
        {
            return await _refreshRepository.GetProductsForAllCustomers();
        }

        public async Task SendAllProducts()
        {
            var products = await _refreshRepository.GetProductsForAllCustomers();
            await Clients.All.SendAsync("ReceivedProducts", products);
        }



        public async Task<RefreshCLientDto> GetProductsByCustomer(int customerId)
        {
            return await _refreshRepository.GetProductsByCustomer(customerId);
        }


        public async Task SubscribeToEquipmentByCustomer(int customerId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, customerId.ToString());

            var customer = await _refreshRepository.GetProductsByCustomer(customerId);

            await Clients.Caller.SendAsync("Receivedcustomer", customer);
        }




        public async Task SubscribeToEquipment(string equipmentId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, equipmentId);

            var equipment = await _refreshRepository.GetEquipementById(equipmentId);

            await Clients.Caller.SendAsync("ReceivedRefresh", equipment);
        }
        //public async Task<List<RefreshDto>> GetProductsById(string equipmentId)
        //{
        //    var product = await _refreshRepository.GetEquipementById(equipmentId);
        //    return new List<RefreshDto> { product };
        //}

        public async Task<List<object>> RequestActiveAlerts(string equipmentId)
        {
            return await _refreshRepository.GetActiveAlerts(equipmentId);
        }

        public async Task<List<object>> RequestLatestAlerts(string equipmentId, string? startDate, string? endDate)
        {
            DateTime? start = string.IsNullOrWhiteSpace(startDate) ? null : DateTime.Parse(startDate);
            DateTime? end = string.IsNullOrWhiteSpace(endDate) ? null : DateTime.Parse(endDate);

            return await _refreshRepository.GetLatestAlerts(equipmentId, start, end);
        }



        public async Task UnsubscribeFromEquipment(string equipmentId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, equipmentId);
        }



    }
}
