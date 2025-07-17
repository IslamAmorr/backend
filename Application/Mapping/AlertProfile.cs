using AutoMapper;
using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{

    public class AlertProfile : Profile
    {
        public AlertProfile()
        {

CreateMap<Alert, AlertDivaDto>()
    .IncludeBase<Alert, AlertDto>();

            CreateMap<Alert, AlertVigiDto>()
                .IncludeBase<Alert, AlertDto>();

            CreateMap<Alert, AlertDto>()
                .ForMember(dest => dest.Equipment,
                           opt => opt.MapFrom(src => src.Equipment))
                .ReverseMap();

        }


        private AlertSource DetermineAlertSource(int alertType)
        {
            // Implémentez la logique pour déterminer la source de l'alerte en fonction de alertType
            // Par exemple :
            return alertType switch
            {
                1 => AlertSource.Level,
                2 => AlertSource.Pressure,
                3 => AlertSource.Voie1,
                // Ajoutez d'autres cas selon vos besoins
                _ => AlertSource.Level // Valeur par défaut
            };
        }

        private string GetAlertDescription(int alertType)
        {
            // Implémentez la logique pour obtenir la description de l'alerte en fonction de alertType
            // Par exemple :
            return alertType switch
            {
                1 => "Niveau bas",
                2 => "Pression élevée",
                3 => "Voie 1 défaillante",
                // Ajoutez d'autres cas selon vos besoins
                _ => "Type d'alerte inconnu"
            };
        }
    }
}
