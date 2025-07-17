using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using Domain.DTOs;
using Domain.models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack;
using Application.Interfaces.IService;

namespace Application.Services
{

    public class ServiceEquipement : IEquipementGestionService
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentRepository _equipementRepository;

        public ServiceEquipement(IEquipmentRepository equipementRepository, IMapper mapper)
        {
            _equipementRepository = equipementRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EquipementDtooo>> GetAllAsync()
        {
            var entities = await _equipementRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EquipementDtooo>>(entities);
        }

        public async Task<EquipementDtooo> GetByIdAsync(string id)
        {
            var entity = await _equipementRepository.GetByIdAsync(id);
            return _mapper.Map<EquipementDtooo>(entity);
        }

        public async Task<EquipementDtooo> AddAsync(EquipementDtooo equipementDtooo)
        {
            if (equipementDtooo == null)
                throw new ArgumentNullException(nameof(equipementDtooo));

            var entity = _mapper.Map<Equipment>(equipementDtooo);
            entity.DateInsert = equipementDtooo.DateInsert ?? DateTime.UtcNow;

            var addedEntity = await _equipementRepository.AddAsync(entity);
            return _mapper.Map<EquipementDtooo>(addedEntity);
        }

        public async Task<EquipementDtooo> UpdateAsync(EquipementDtooo equipementDtooo)
        {
            if (equipementDtooo == null)
                throw new ArgumentNullException(nameof(equipementDtooo));

            var existingEntity = await _equipementRepository.GetByIdAsync(equipementDtooo.SerialNumber);
            if (existingEntity == null)
                throw new KeyNotFoundException("Equipement not found.");

            _mapper.Map(equipementDtooo, existingEntity);
            existingEntity.DateUpdate = DateTime.UtcNow;

            await _equipementRepository.UpdateAsync(existingEntity);
            return _mapper.Map<EquipementDtooo>(existingEntity);
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await _equipementRepository.GetByIdAsync(id);
            if (entity == null)
                throw new KeyNotFoundException("Equipement not found.");

            await _equipementRepository.DeleteAsync(entity);
        }

        public async Task<List<CustomerEquipementsDto>> GetCustomerEquipementsAsync()
        {
            return await _equipementRepository.GetCustomerEquipementsAsync();
        }

        public async Task<CustomerEquipementsDto> GetCustomerEquipementsByIdAsync(int customerId)
        {
            return await _equipementRepository.GetCustomerEquipementsByIdAsync(customerId);
        }
    }
}
