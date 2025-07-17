using Microsoft.AspNetCore.SignalR;

using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;

using Microsoft.Extensions.DependencyInjection;
using Domain.models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Infrastructure.Persistence;
using Infrastructure.Hubs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Infrastructure.SignalR;
using Application.Interfaces;
using Application.Interfaces.IRepository;

namespace Infrastructure.SignalR
{
    public class EquipementDatabaseSubscription : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<EquipementHub> _hubContext;
        private readonly SqlTableDependency<Refresh> _refreshTableDependency;
        private readonly SqlTableDependency<TankPump> _tankPumpTableDependency;
        private readonly SqlTableDependency<Customer> _customerTableDependency;
        public EquipementDatabaseSubscription(
           IServiceScopeFactory scopeFactory,
           IHubContext<EquipementHub> hubContext,
           IConfiguration configuration)
        {
            _scopeFactory = scopeFactory;
            _hubContext = hubContext;


            var connStr = configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (var testConn = new SqlConnection(connStr))
                {
                    testConn.Open();
                }

                _refreshTableDependency = new SqlTableDependency<Refresh>(
                    connStr, tableName: "Refresh", schemaName: "dbo", executeUserPermissionCheck: false);

                _tankPumpTableDependency = new SqlTableDependency<TankPump>(
                    connStr, tableName: "TankPump", schemaName: "dbo", executeUserPermissionCheck: false);

                _customerTableDependency = new SqlTableDependency<Customer>(
                    connStr, tableName: "Customer", schemaName: "dbo", executeUserPermissionCheck: false);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error initializing table dependencies: {ex.Message}");
                throw;
            }
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _refreshTableDependency.OnChanged += OnRefreshTableChanged;
            _refreshTableDependency.OnError += OnTableError;
            _refreshTableDependency.Start();

            _tankPumpTableDependency.OnChanged += OnTankPumpTableChanged;
            _tankPumpTableDependency.OnError += OnTableError;
            _tankPumpTableDependency.Start();

            _customerTableDependency.OnChanged += OnCustomerTableChanged;
            _customerTableDependency.OnError += OnTableError;
            _customerTableDependency.Start();

            return Task.CompletedTask;
        }

        private async void OnRefreshTableChanged(object sender, RecordChangedEventArgs<Refresh> e)
        {
            try
            {
                if (e.ChangeType != ChangeType.None)
                {
                    var customerId = e.Entity?.Customer;
                    await HandleTableChange(customerId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error in OnRefreshTableChanged: {ex.Message}");
            }
        }

        private async void OnTankPumpTableChanged(object sender, RecordChangedEventArgs<TankPump> e)
        {
            try
            {
                if (e.ChangeType != ChangeType.None)
                {
                    var customerId = e.Entity?.Customer;
                    await HandleTableChange(customerId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error in OnTankPumpTableChanged: {ex.Message}");
            }
        }

        private async void OnCustomerTableChanged(object sender, RecordChangedEventArgs<Customer> e)
        {
            try
            {
                if (e.ChangeType != ChangeType.None)
                {
                    var customerId = e.Entity?.Id;
                    await HandleTableChange(customerId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error in OnCustomerTableChanged: {ex.Message}");
            }
        }

        private async Task HandleTableChange(int? customerId)
        {
            if (!customerId.HasValue)
                return;

            try
            {
                using var scope = _scopeFactory.CreateScope();
                var repo = scope.ServiceProvider.GetRequiredService<IEquipmentRepository>();

                var data = await repo.GetCustomerEquipementsByIdAsync(customerId.Value);

                await _hubContext.Clients.All.SendAsync("ReceivedEquipementsByCustomerId", data);


                // 🔹 2. Récupère la liste globale mise à jour (tous les clients)
                var allData = await repo.GetCustomerEquipementsAsync();
                await _hubContext.Clients.All.SendAsync("ReceivedEquipement", allData);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error in HandleTableChange: {ex.Message}");
            }
        }

        private void OnTableError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            Console.WriteLine($"❌ SqlTableDependency error: {e.Error.Message}");
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _refreshTableDependency?.Stop();
            _tankPumpTableDependency?.Stop();
            _customerTableDependency?.Stop();
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            _refreshTableDependency?.Dispose();
            _tankPumpTableDependency?.Dispose();
            _customerTableDependency?.Dispose();
            base.Dispose();
        }
    }
}