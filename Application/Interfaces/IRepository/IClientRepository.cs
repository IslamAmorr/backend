using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository

{
    public interface IClientRepository : IGenericRepository<Customer>
    {
        Task<IEnumerable<CustomerDto>> GetAllClientsWithTanksAsync();
    }
}
