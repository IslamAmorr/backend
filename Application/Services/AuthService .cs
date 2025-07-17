using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Interfaces.IService;
using Application.Interfaces.IRepository;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using Domain.models;
using Microsoft.AspNetCore.Identity;
using Domain.DTOs;


namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(IUserRepository userRepository, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<TokenResponseDto?> LoginAsync(LoginDto request)
        {
            var user = await _userRepository.GetUserByUsernameAsync(request.Login);
            if (user == null || new PasswordHasher<Account>().VerifyHashedPassword(user, user.Password, request.Password)
                              == PasswordVerificationResult.Failed)
            {
                return null;
            }

            return await CreateTokenResponse(user);
        }

        public async Task<AccountDto?> RegisterAsync(AccountDto request)
        {
            if (await _userRepository.AnyUserWithUsernameAsync(request.Login))
            {
                return null;
            }

            var user = new Account
            {
                Login = request.Login,
                Password = new PasswordHasher<Account>().HashPassword(null, request.Password),
                Role = request.Role,
                Customer = request.Customer
            };

            await _userRepository.AddUserAsync(user);
            await _userRepository.SaveAsync();

            return new AccountDto
            {
                Login = user.Login,
                Role = user.Role,
                Customer = user.Customer
            };
        }

        private async Task<TokenResponseDto> CreateTokenResponse(Account user)
        {
            return new TokenResponseDto
            {
                AccessToken = _tokenService.CreateToken(user),
                userID = user.Id,
                Role = user.Role,
                Customer = user.Customer
            };
        }


    }
}
