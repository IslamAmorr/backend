using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{

    public class DivaDto : RefreshDto
    {
        public double? Pressure1 { get; set; }
        public double? Level1 { get; set; }
    }
}
