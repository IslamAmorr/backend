using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepository
{
    public interface IUserRepository
    {
        Task<Account?> GetUserByUsernameAsync(string username);
        Task<Account?> GetUserByIdUserAsync(int iduserId);
        Task<Account?> GetUserByIdAsync(int id);
        Task<bool> AnyUserWithUsernameAsync(string username);
        Task AddUserAsync(Account user);
        Task SaveAsync();
    }
}
