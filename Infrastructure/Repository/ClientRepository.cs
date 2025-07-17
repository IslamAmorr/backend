using Application.Interfaces.IRepository;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClientRepository : GenericRepositoryImp<Customer>, IClientRepository
    {
        private readonly AirLiquideContext _context;

        public ClientRepository(AirLiquideContext context) : base(context)

        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllClientsWithTanksAsync()
        {
            var clientsWithTanks = await (from customer in _context.Customers
                                          join tank in _context.TankPumps
                                          on customer.Id equals tank.Customer
                                          select new CustomerDto
                                          {
                                              Id = customer.Id,
                                              Name = customer.Name,
                                              Adress = customer.Adress,
                                              Tel1 = customer.Tel1,
                                              Latitude=customer.Latitude,
                                              Longitude = customer.Longitude,
                                              Email1=customer.Email1
                                          })
                                          .Distinct()
                                          .ToListAsync();

            return clientsWithTanks;
        }
    }
}
