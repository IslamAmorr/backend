using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs  
{
    public class RefreshDto
    {
         public string Equipment { get; set; }
         public DateTime AcquisitionTime { get; set; }
        public string EquipmentType { get; set; }
        public int Customer { get; set; }

        public string? EquipmentName { get; set; }
        public string? CustomerName { get; set; }
        public string? Adress { get; set; }
        public double? Pressure1 { get; set; }
        public double? Level1 { get; set; }
        public string? NameVoie1 { get; set; }
        public string? NameVoie2 { get; set; }
        public string? NameVoie3 { get; set; }
        public string? NameVoie4 { get; set; }
        public string? NameVoie5 { get; set; }
        public string? NameVoie6 { get; set; }
        public string? NameVoie7 { get; set; }
        public double? Voie1 { get; set; }
        public double? Voie2 { get; set; }
        public double? Voie3 { get; set; }
        public double? Voie4 { get; set; }
        public double? Voie5 { get; set; }
        public double? Voie6 { get; set; }
        public double? Voie7 { get; set; }

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
