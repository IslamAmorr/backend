using Application.Interfaces.IRepository;
using Domain.models;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AirLiquideContext _context; 


        public UserRepository(AirLiquideContext context)
        {
            _context = context;
        }



        public async Task<Account?> GetUserByUsernameAsync(string username)
        {
            return await _context.Accounts
                                 .FirstOrDefaultAsync(u => u.Login == username);
        }

        public async Task<Account?> GetUserByIdAsync(int id)
        {
            return await _context.Accounts
                                 .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<bool> AnyUserWithUsernameAsync(string username)
        {
            return await _context.Accounts
                                 .AnyAsync(u => u.Login == username);
        }

        public async Task AddUserAsync(Account user)
        {
            await _context.Accounts.AddAsync(user);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Account?> GetUserByIdUserAsync(int userId)
        {
            return await _context.Accounts.FirstOrDefaultAsync(u => u.Id == userId);
        }

    }
}