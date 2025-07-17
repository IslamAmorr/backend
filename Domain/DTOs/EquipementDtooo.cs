using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EquipementDtooo
    {

        public string SerialNumber { get; set; } = null!;

        public int? Customer { get; set; }
        public string? CustomerName { get; set; }

        public string? EquipmentType { get; set; }

        public string? SimcardNumber { get; set; }
        public DateTime? DateFirstSend { get; set; }

        public string? UserUpdate { get; set; }
        public DateTime? DateInsert { get; set; }

    }
}