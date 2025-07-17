using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceTank : IService<TankPumpDto,int>
    {
        private readonly IGenericRepository<TankPump> _tankRepository;
        private readonly IMapper _mapper;

        public ServiceTank(IGenericRepository<TankPump> tankRepository, IMapper mapper)
        {
            _tankRepository = tankRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TankPumpDto>> GetAllAsync()
        {
            var tanks = await _tankRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TankPumpDto>>(tanks);
        }

        public async Task<TankPumpDto> GetByIdAsync(int id)
        {
            var tank = await _tankRepository.GetByIdAsync(id);
            return _mapper.Map<TankPumpDto>(tank);
        }

        public async Task<TankPumpDto> AddAsync(TankPumpDto tankDto)
        {
            if (tankDto == null)
                throw new ArgumentNullException(nameof(tankDto), "Tank is null.");

            var tankEntity = _mapper.Map<TankPump>(tankDto);
            var addedEntity = await _tankRepository.AddAsync(tankEntity);
            return _mapper.Map<TankPumpDto>(addedEntity);
        }

        public async Task<TankPumpDto> UpdateAsync(TankPumpDto tankDto)
        {
            if (tankDto == null)
                throw new ArgumentNullException(nameof(tankDto), "Tank is null.");

            var existingEntity = await _tankRepository.GetByIdAsync(tankDto.Id);
            if (existingEntity == null)
                throw new KeyNotFoundException("Tank not found.");

            // Map updated fields from DTO to entity
            _mapper.Map(tankDto, existingEntity);

            await _tankRepository.UpdateAsync(existingEntity);
            return _mapper.Map<TankPumpDto>(existingEntity);
        }

        public async Task DeleteAsync(int id)
        {
            var tankEntity = await _tankRepository.GetByIdAsync(id);
            if (tankEntity == null)
                throw new KeyNotFoundException("Tank not found.");

            await _tankRepository.DeleteAsync(tankEntity);
        }
    }
}
