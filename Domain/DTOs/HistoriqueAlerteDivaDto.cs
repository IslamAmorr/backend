using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class HistoriqueAlerteDivaDto
    {
        public DateTime AcquisitionTime { get; set; }
        public string? EquipmentName { get; set; } = null!;
        public double? Level1 { get; set; }
        public double? Pressure1 { get; set; }
        public int CustomerId { get; set; }
    }
}
