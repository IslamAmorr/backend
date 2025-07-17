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
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            // Mapping simple properties
            CreateMap<Customer, CustomerEquipementsDto>()
                .ForMember(dest => dest.IdCustomer, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NameCustomer, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Equipements, opt => opt.Ignore());

            CreateMap<TankPump, EquipementDto>()
      .ForMember(dest => dest.IdEquipement, opt => opt.MapFrom(src => src.Equipment))
      .ForMember(dest => dest.NameEquipement, opt => opt.MapFrom(src => src.Name))
      .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type == "T" ? "DIVA" : src.Type == "V" ? "VIGI" : "procom"))
      .ForMember(dest => dest.Equipement, opt => opt.Ignore())
      .ForMember(dest => dest.Temperature, opt => opt.Ignore())
      .ForMember(dest => dest.Humidity, opt => opt.Ignore())
      .ForMember(dest => dest.PompAON, opt => opt.Ignore())
      .ForMember(dest => dest.PompBON, opt => opt.Ignore())
      .ForMember(dest => dest.PompCON, opt => opt.Ignore())
      .ForMember(dest => dest.Latitude, opt => opt.Ignore())
      .ForMember(dest => dest.Longitude, opt => opt.Ignore())
      .ForMember(dest => dest.AcquisitionTime, opt => opt.Ignore())
      .ForMember(dest => dest.PressureReg, opt => opt.Ignore())
    // Nouveaux attributs ignorés
    .ForMember(dest => dest.TempPompA, opt => opt.Ignore())
    .ForMember(dest => dest.TempPompB, opt => opt.Ignore())
    .ForMember(dest => dest.TempPompC, opt => opt.Ignore())
    .ForMember(dest => dest.TempPompD, opt => opt.Ignore())

    .ForMember(dest => dest.HourCounterPompA, opt => opt.Ignore())
    .ForMember(dest => dest.HourCounterPompB, opt => opt.Ignore())
    .ForMember(dest => dest.HourCounterPompC, opt => opt.Ignore())
    .ForMember(dest => dest.HourCounterPompD, opt => opt.Ignore())

    .ForMember(dest => dest.PressureC1A, opt => opt.Ignore())
    .ForMember(dest => dest.PressureC2A, opt => opt.Ignore());



        }

    }
}
