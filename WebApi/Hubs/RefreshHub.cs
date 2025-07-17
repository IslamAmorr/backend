using Application.Interfaces;
using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NuGet.Protocol.Core.Types;

namespace Tunav_AirLiquide.WebApi.Hubs
{
    public class RefreshHub : Hub
    {
        private readonly IRefreshRepository refreshRepository;

        private readonly IMapper _mapper;

        public RefreshHub(IConfiguration configuration, IMapper mapper, IRefreshRepository repository)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            refreshRepository = repository;
        }
        public Task Subscribe(string equipment)
    => Groups.AddToGroupAsync(Context.ConnectionId, equipment);

        public Task Unsubscribe(string equipment)
            => Groups.RemoveFromGroupAsync(Context.ConnectionId, equipment);
        public async Task SendProducts()
        {
            try
            {
                var products = await refreshRepository.GetRefreshes();
                await Clients.All.SendAsync("ReceivedProducts", products);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GpsHub] ❌ Exception in SendProducts: {ex}");
                throw;  // laisse l’erreur remonter pour le client
            }
        }
    }
}