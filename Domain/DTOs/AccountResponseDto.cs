using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class AccountResponseDto
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
