using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class RefreshCLientDto
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Adress { get; set; }


        public List<RefreshDto?> Equipements { get; set; }


    }
}
