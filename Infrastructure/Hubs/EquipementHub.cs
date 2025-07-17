using Application.Interfaces;
using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Hubs
{

    public class EquipementHub : Hub
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public EquipementHub(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }

        public async Task SendEquipements()
        {
            var data = await _equipmentRepository.GetCustomerEquipementsAsync();
            await Clients.All.SendAsync("ReceivedEquipement", data);
        }

        public async Task SendProductByCustomerId(int customerId)
        {
            var data = await _equipmentRepository.GetCustomerEquipementsByIdAsync(customerId);
            await Clients.All.SendAsync("ReceivedEquipementsByCustomerId", data);
        }
    }
}
