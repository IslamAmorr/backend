using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserName => _httpContextAccessor.HttpContext?.User?.Identity?.Name;
        public int? AccountId => int.TryParse(_httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var id) ? id : null;

        public bool IsAdmin => bool.TryParse(_httpContextAccessor.HttpContext?.User?.FindFirst("isAdmin")?.Value, out var isAdmin) && isAdmin;

        public int? CustomerId => int.TryParse(_httpContextAccessor.HttpContext?.User?.FindFirst("customerId")?.Value, out var id) ? id : null;
        public int? CustomerType => int.TryParse(_httpContextAccessor.HttpContext?.User?.FindFirst("customerType")?.Value, out var type) ? type : null;
    }
}


