using Application.Interfaces.IServices;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IServiceClient : IService<CustomerDto,int>
    {
        Task<CustomerDto?> GetAllClientWithTanksAsync();
    }
}
