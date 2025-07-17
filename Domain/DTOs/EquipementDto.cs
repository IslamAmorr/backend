using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EquipementDto
    {
        public string IdEquipement { get; set; }
        public string NameEquipement { get; set; }
        public string Type { get; set; }
        public DateTime? AcquisitionTime { get; set; }
        public double? Latitude { get; set; }

        public double? PressureReg { get; set; }
        public double? Temperature { get; set; }
        public double? Humidity { get; set; }
        public bool? PompAON { get; set; }
        public bool? PompBON { get; set; }
        public bool? PompCON { get; set; }

        // Nouveaux attributs
        public double? TempPompA { get; set; }
        public double? TempPompB { get; set; }
        public double? TempPompC { get; set; }
        public double? TempPompD { get; set; }

        public double? HourCounterPompA { get; set; }
        public double? HourCounterPompB { get; set; }
        public double? HourCounterPompC { get; set; }
        public double? HourCounterPompD { get; set; }

        public double? PressureC1A { get; set; }
        public double? PressureC2A { get; set; }



        public double? Longitude { get; set; }
        public string descAlert { get; set; }

        public Dictionary<string, double?> Equipement { get; set; }
    }
}
