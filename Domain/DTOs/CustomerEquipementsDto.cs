using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CustomerEquipementsDto
    {
        public int IdCustomer { get; set; }
        public string NameCustomer { get; set; }
        public string Adress { get; set; }

        public double NbEquipements { get; set; }
        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
        public List<EquipementDto> Equipements { get; set; }
    }
        

}
