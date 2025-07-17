
using Domain.models;

namespace Application.Interfaces.IService
{
    public interface ITokenService
    {
        string CreateToken(Account User);
        //Task<string> GenerateAndSaveRefreshTokenAsync(Account user);
        //Task<Account?> ValidateRefreshTokenAsync(int userId, string refreshToken);

    }
}
