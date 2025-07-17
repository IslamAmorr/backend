using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public enum AlertSource
    {
        Level,
        Pressure,
        Voie1,
        Voie2,
        Voie3,
        Voie4,
        Voie5,
        Voie6,
        Voie7
    }

    public class AlertDto
    {
        public int Id { get; set; }
        public string Equipment { get; set; } = null!;
        public string? EquipmentType { get; set; }

        public int? Customer { get; set; }

        public DateTime AcquisitionTime { get; set; }
        public int AlertType { get; set; }

        public string Description { get; set; } = null!;


        public string CustomerName { get; set; } = null!;

        public string EquipmentName { get; set; } = null!;
        // Propriétés spécifiques à AlertProDto, mais ici dans la base

        public double? TempPompA { get; set; }
        public double? HourCounterPompA { get; set; }

        public double? TempPompB { get; set; }
        public double? HourCounterPompB { get; set; }

        public double? TempPompC { get; set; }
        public double? HourCounterPompC { get; set; }

        public double? TempPompD { get; set; }
        public double? HourCounterPompD { get; set; }




    }

}
