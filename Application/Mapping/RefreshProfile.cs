using AutoMapper;
using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Mapping
{
    public class RefreshProfile : Profile
    {
        public RefreshProfile()
        {
            CreateMap<Refresh, RefreshDto>();
            
                CreateMap<RefreshDto, Refresh>();


            }


        }
}

