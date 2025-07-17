using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TankPumpDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? Customer { get; set; }

        public string? Equipment { get; set; }
        public string? NameProduct { get; set; }
        public char? Type { get; set; }

        public double Capacity { get; set; }
        public string PeriodOfOperation { get; set; }
        public string PeriodOfDistribution { get; set; }
        public double PressureService { get; set; }
        public string ReferenceTank { get; set; }

        public double LowLevel { get; set; }
        public double VeryLowLevel { get; set; }
        public double HighPression { get; set; }
        public double VeryHighPression { get; set; }
        public double LowPression { get; set; }
        public double VeryLowPression { get; set; }
        
    }

}
