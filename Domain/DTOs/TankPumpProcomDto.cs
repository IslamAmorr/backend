using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TankPumpProcomDto
    {
        public int Id { get; set; } // identifiant
        public string? NameProduct { get; set; }
        public int Customer { get; set; }
        public string? Equipment { get; set; } = string.Empty;
        public string? NumTank { get; set; }
        public string? Type { get; set; }

    }
}
