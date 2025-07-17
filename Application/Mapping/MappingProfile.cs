using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Customer mappings
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Adress, opt => opt.MapFrom(src => src.Adress))
                .ForMember(dest => dest.Tel1, opt => opt.MapFrom(src => src.Tel1))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude));

            // TankPump mappings
            // Fix for CS1001 and CS0117 errors  
            CreateMap<TankPump, TankPumpDto>()
               .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type != null && src.Type.Length > 0 ? src.Type[0] : (char?)null))
               .ReverseMap()
               .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.HasValue ? src.Type.ToString() : null));

            // Refresh mappings
            CreateMap<Refresh, RefreshDto>()
                .ForMember(dest => dest.Equipment, opt => opt.MapFrom(src => src.Equipment))
                .ForMember(dest => dest.AcquisitionTime, opt => opt.MapFrom(src => src.AcquisitionTime))
                .ForMember(dest => dest.Pressure1, opt => opt.MapFrom(src => src.Pressure1))
                .ForMember(dest => dest.Level1, opt => opt.MapFrom(src => src.Level1))
                .ForMember(dest => dest.Voie1, opt => opt.MapFrom(src => src.Voie1))
                .ForMember(dest => dest.Voie2, opt => opt.MapFrom(src => src.Voie2))
                .ForMember(dest => dest.Voie3, opt => opt.MapFrom(src => src.Voie3))
                .ForMember(dest => dest.Voie4, opt => opt.MapFrom(src => src.Voie4))
                .ForMember(dest => dest.Voie5, opt => opt.MapFrom(src => src.Voie5))
                .ForMember(dest => dest.Voie6, opt => opt.MapFrom(src => src.Voie6))
                .ForMember(dest => dest.Voie7, opt => opt.MapFrom(src => src.Voie7));

            // Alert mappings
            CreateMap<Alert, AlertDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Equipment, opt => opt.MapFrom(src => src.Equipment))
                .ForMember(dest => dest.AcquisitionTime, opt => opt.MapFrom(src => src.AcquisitionTime))
                .ForMember(dest => dest.AlertType, opt => opt.MapFrom(src => src.AlertType))
                .Include<Alert, AlertDivaDto>()
                .Include<Alert, AlertVigiDto>();

            CreateMap<Alert, AlertDivaDto>()
                .IncludeBase<Alert, AlertDto>()
                .ForMember(dest => dest.Level1, opt => opt.MapFrom(src => src.Level1))
                .ForMember(dest => dest.Pressure1, opt => opt.MapFrom(src => src.Pressure1));

            CreateMap<Alert, AlertVigiDto>()
                .IncludeBase<Alert, AlertDto>()
                .ForMember(dest => dest.Voie1, opt => opt.MapFrom(src => src.Voie1))
                .ForMember(dest => dest.Voie2, opt => opt.MapFrom(src => src.Voie2))
                .ForMember(dest => dest.Voie3, opt => opt.MapFrom(src => src.Voie3))
                .ForMember(dest => dest.Voie4, opt => opt.MapFrom(src => src.Voie4))
                .ForMember(dest => dest.Voie5, opt => opt.MapFrom(src => src.Voie5))
                .ForMember(dest => dest.Voie6, opt => opt.MapFrom(src => src.Voie6))
                .ForMember(dest => dest.Voie7, opt => opt.MapFrom(src => src.Voie7));

            // AlertType mapping
            CreateMap<AlertType, AlertTypeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            // Account mappings
            CreateMap<Account, AccountDto>()
                .ReverseMap();

            CreateMap<Account, AccountResponseDto>();

            // Equipement mappings
            CreateMap<Equipment, EquipementDtooo>()
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer))
                .ForMember(dest => dest.EquipmentType, opt => opt.MapFrom(src => src.EquipmentType))
                .ForMember(dest => dest.SimcardNumber, opt => opt.MapFrom(src => src.SimcardNumber))
                .ForMember(dest => dest.DateFirstSend, opt => opt.MapFrom(src => src.DateFirstSend))
                .ForMember(dest => dest.UserUpdate, opt => opt.MapFrom(src => src.UserUpdate))
                .ForMember(dest => dest.DateInsert, opt => opt.MapFrom(src => src.DateInsert));

            // Configuration spéciale pour les mappings complexes
            CreateMap<Refresh, RefreshCLientDto>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Customer))
                .ForMember(dest => dest.Equipements, opt => opt.Ignore()); // Géré manuellement

            // Mapping personnalisé pour RefreshDto avec jointures
            CreateMap<Refresh, RefreshDto>()
                .ForMember(dest => dest.EquipmentType, opt => opt.Ignore())
                .ForMember(dest => dest.EquipmentName, opt => opt.Ignore())
                .ForMember(dest => dest.CustomerName, opt => opt.Ignore())
                .ForMember(dest => dest.Adress, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie1, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie2, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie3, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie4, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie5, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie6, opt => opt.Ignore())
                .ForMember(dest => dest.NameVoie7, opt => opt.Ignore())
                .AfterMap((src, dest, context) =>
                {
                    // Résolution des propriétés via les relations
                    if (context.Items.TryGetValue("TankPump", out var tpObj) && tpObj is TankPump tp)
                    {
                        dest.EquipmentType = tp.Type?.ToString();
                        dest.EquipmentName = tp.Name;
                        dest.NameVoie1 = tp.NameVoie1;
                        dest.NameVoie2 = tp.NameVoie2;
                        dest.NameVoie3 = tp.NameVoie3;
                        dest.NameVoie4 = tp.NameVoie4;
                        dest.NameVoie5 = tp.NameVoie5;
                        dest.NameVoie6 = tp.NameVoie6;
                        dest.NameVoie7 = tp.NameVoie7;
                    }

                    if (context.Items.TryGetValue("Customer", out var custObj) && custObj is Customer customer)
                    {
                        dest.CustomerName = customer.Name;
                        dest.Adress = customer.Adress;
                    }
                });
        }
    }
}