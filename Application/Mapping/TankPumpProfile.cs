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
public class TankPumpProfile : Profile
{
    public TankPumpProfile()
    {
            CreateMap<TankPumpDto, TankPump>();
            CreateMap<TankPump, TankPumpDto>();


            CreateMap<TankPumpVigiDto, TankPump>();
            CreateMap<TankPump, TankPumpVigiDto>();


            CreateMap<TankPumpProcomDto, TankPump>();
            CreateMap<TankPump, TankPumpProcomDto>();


            CreateMap<EquipementDtooo, Equipment>();
            CreateMap<Equipment, EquipementDtooo>();
        }


    }
}

