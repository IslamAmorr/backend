

using Domain.DTOs;
using Domain.models;
using Domain.Models;

namespace Application.Interfaces.IService
{
    public interface IAuthService
    {
        Task<TokenResponseDto?> LoginAsync(LoginDto request);
        Task<AccountDto?> RegisterAsync(AccountDto request);
    }
}
