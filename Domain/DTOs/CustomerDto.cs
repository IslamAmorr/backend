using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? Tel1 { get; set; }
        public string? Email1 { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }



    }
}
