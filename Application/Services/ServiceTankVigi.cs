using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
   
        public class ServiceTankVigi : IService<TankPumpVigiDto, int>
        {
            private readonly IGenericRepository<TankPump> _repository;
            private readonly IMapper _mapper;

            public ServiceTankVigi(IGenericRepository<TankPump> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<TankPumpVigiDto>> GetAllAsync()
            {
                var entities = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<TankPumpVigiDto>>(entities);
            }

            public async Task<TankPumpVigiDto> GetByIdAsync(int id)
            {
                var entity = await _repository.GetByIdAsync(id);
                return _mapper.Map<TankPumpVigiDto>(entity);
            }

            public async Task<TankPumpVigiDto> AddAsync(TankPumpVigiDto dto)
            {
                var entity = _mapper.Map<TankPump>(dto);
                var added = await _repository.AddAsync(entity);
                return _mapper.Map<TankPumpVigiDto>(added);
            }

            public async Task<TankPumpVigiDto> UpdateAsync(TankPumpVigiDto dto)
            {
                var existing = await _repository.GetByIdAsync(dto.Id);
                if (existing == null)
                    throw new KeyNotFoundException("Tank not found");

                _mapper.Map(dto, existing);
                await _repository.UpdateAsync(existing);
                return _mapper.Map<TankPumpVigiDto>(existing);
            }

            public async Task DeleteAsync(int id)
            {
                var existing = await _repository.GetByIdAsync(id);
                if (existing == null)
                    throw new KeyNotFoundException("Tank not found");

                await _repository.DeleteAsync(existing);
            }
        }
    }