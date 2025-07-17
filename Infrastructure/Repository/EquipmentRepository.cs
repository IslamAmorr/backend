using Application.Interfaces;
using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EquipmentRepository : GenericRepositoryImp<Equipment>, IEquipmentRepository
    {
        string connectionString;
        private readonly AirLiquideContext _context;
        private readonly IMapper _mapper;

        public EquipmentRepository(string connectionString, AirLiquideContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
            this.connectionString = connectionString;
            _context = context;
        }

        public async Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync()
        {
            var customers = await _context.Customers.ToListAsync();
            var tankPumps = await _context.TankPumps.ToListAsync();
            var refreshes = await _context.Refreshes.ToListAsync();

            var result = customers.Select(c =>
            {
                var dto = _mapper.Map<CustomerEquipementsDto>(c);
                dto.Adress = c.Adress;

                var pumpsOfClient = tankPumps.Where(tp => tp.Customer == c.Id);

                dto.Equipements = pumpsOfClient.Select(tp =>
                {
                    var eqDto = _mapper.Map<EquipementDto>(tp);
                    eqDto.Type = tp.Type;

                    var r = refreshes.FirstOrDefault(rf => rf.Customer == c.Id && rf.Equipment == tp.Equipment);

                    if (tp.Type == "T" && r != null)
                    {
                        var dict = new Dictionary<string, double?>();
                        dict["level1"] = r.Level1;
                        dict["pressure1"] = r.Pressure1;
                        eqDto.Equipement = dict;
                    }
                    else if (tp.Type == "V" && r != null)
                    {
                        var dict = new Dictionary<string, double?>();
                        if (tp.Voie1 == true) dict[tp.NameVoie1] = r.Voie1;
                        if (tp.Voie2 == true) dict[tp.NameVoie2] = r.Voie2;
                        if (tp.Voie3 == true) dict[tp.NameVoie3] = r.Voie3;
                        if (tp.Voie4 == true) dict[tp.NameVoie4] = r.Voie4;
                        if (tp.Voie5 == true) dict[tp.NameVoie5] = r.Voie5;
                        if (tp.Voie6 == true) dict[tp.NameVoie6] = r.Voie6;
                        if (tp.Voie7 == true) dict[tp.NameVoie7] = r.Voie7;
                        eqDto.Equipement = dict;
                    }
                    else
                    {
                        // Pour A, D, P, R et tout autre type => Pas de dictionnaire
                        eqDto.Equipement = null;
                    }

                    eqDto.AcquisitionTime = r?.AcquisitionTime ?? DateTime.MinValue;

                    if (r != null)
                    {
                        eqDto.Longitude = r.Longitude;
                        eqDto.Latitude = r.Latitude;

                        // Attributs normaux dans le DTO, toujours assignés
                        eqDto.Temperature = r.Temperature;
                        eqDto.Humidity = r.Humidity;
                        eqDto.PompAON = r.PompAon;
                        eqDto.PompBON = r.PompBon;
                        eqDto.PompCON = r.PompCon;
                        eqDto.PressureReg = r.PressureReg;
                        // Nouveaux attributs
                        eqDto.TempPompA = r.TempPompA;
                        eqDto.TempPompB = r.TempPompB;
                        eqDto.TempPompC = r.TempPompC;
                        eqDto.TempPompD = r.TempPompD;

                        eqDto.HourCounterPompA = r.HourCounterPompA;
                        eqDto.HourCounterPompB = r.HourCounterPompB;
                        eqDto.HourCounterPompC = r.HourCounterPompC;
                        eqDto.HourCounterPompD = r.HourCounterPompD;

                        eqDto.PressureC1A = r.PressureC1a;
                        eqDto.PressureC2A = r.PressureC2a;
                    }

                    return eqDto;
                }).ToList();

                dto.NbEquipements = dto.Equipements.Count;
                return dto;
            }).ToList();

            return result;
        }

        public async Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            if (customer == null) return null;

            var tankPumps = await _context.TankPumps
                .Where(tp => tp.Customer == customerId)
                .ToListAsync();

            var refreshes = await _context.Refreshes
                .Where(rf => rf.Customer == customerId)
                .ToListAsync();

            var dto = _mapper.Map<CustomerEquipementsDto>(customer);
            dto.Adress = customer.Adress;

            dto.Equipements = tankPumps.Select(tp =>
            {
                var eqDto = _mapper.Map<EquipementDto>(tp);
                eqDto.Type = tp.Type;

                var r = refreshes.FirstOrDefault(rf => rf.Equipment == tp.Equipment);

                if (tp.Type == "T" && r != null)
                {
                    var dict = new Dictionary<string, double?>();
                    dict["level1"] = r.Level1;
                    dict["pressure1"] = r.Pressure1;
                    eqDto.Equipement = dict;
                }
                else if (tp.Type == "V" && r != null)
                {
                    var dict = new Dictionary<string, double?>();
                    if (tp.Voie1 == true) dict[tp.NameVoie1] = r.Voie1;
                    if (tp.Voie2 == true) dict[tp.NameVoie2] = r.Voie2;
                    if (tp.Voie3 == true) dict[tp.NameVoie3] = r.Voie3;
                    if (tp.Voie4 == true) dict[tp.NameVoie4] = r.Voie4;
                    if (tp.Voie5 == true) dict[tp.NameVoie5] = r.Voie5;
                    if (tp.Voie6 == true) dict[tp.NameVoie6] = r.Voie6;
                    if (tp.Voie7 == true) dict[tp.NameVoie7] = r.Voie7;
                    eqDto.Equipement = dict;
                }
                else
                {
                    // Pas de dict pour A, D, P, R
                    eqDto.Equipement = null;
                }

                eqDto.AcquisitionTime = r?.AcquisitionTime ?? DateTime.MinValue;

                if (r != null)
                {
                    eqDto.Longitude = r.Longitude;
                    eqDto.Latitude = r.Latitude;

                    eqDto.Temperature = r.Temperature;
                    eqDto.Humidity = r.Humidity;
                    eqDto.PompAON = r.PompAon;
                    eqDto.PompBON = r.PompBon;
                    eqDto.PompCON = r.PompCon;
                    eqDto.PressureReg = r.PressureReg;
                    // Nouveaux attributs
                    eqDto.TempPompA = r.TempPompA;
                    eqDto.TempPompB = r.TempPompB;
                    eqDto.TempPompC = r.TempPompC;
                    eqDto.TempPompD = r.TempPompD;

                    eqDto.HourCounterPompA = r.HourCounterPompA;
                    eqDto.HourCounterPompB = r.HourCounterPompB;
                    eqDto.HourCounterPompC = r.HourCounterPompC;
                    eqDto.HourCounterPompD = r.HourCounterPompD;

                    eqDto.PressureC1A = r.PressureC1a;
                    eqDto.PressureC2A = r.PressureC2a;
                }

                return eqDto;
            }).ToList();

            dto.NbEquipements = dto.Equipements.Count;
            return dto;
        }
    }
}
