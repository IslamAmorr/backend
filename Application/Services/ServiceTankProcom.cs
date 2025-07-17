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
    public class ServiceTankProcom   :IService<TankPumpProcomDto, int>
    {
        private readonly IGenericRepository<TankPump> _repository;
    private readonly IMapper _mapper;

    public ServiceTankProcom(IGenericRepository<TankPump> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

        public async Task<IEnumerable<TankPumpProcomDto>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync(t => t.Type == "D" || t.Type == "A");
            return _mapper.Map<IEnumerable<TankPumpProcomDto>>(data);
        }

        public async Task<TankPumpProcomDto> GetByIdAsync(int id) =>
        _mapper.Map<TankPumpProcomDto>(await _repository.GetByIdAsync(id));

    public async Task<TankPumpProcomDto> AddAsync(TankPumpProcomDto dto)
    {
        var entity = _mapper.Map<TankPump>(dto);
        return _mapper.Map<TankPumpProcomDto>(await _repository.AddAsync(entity));
    }

    public async Task<TankPumpProcomDto> UpdateAsync(TankPumpProcomDto dto)
    {
        var existing = await _repository.GetByIdAsync(dto.Id);
        if (existing == null) throw new KeyNotFoundException("Not found");

        _mapper.Map(dto, existing);
        await _repository.UpdateAsync(existing);
        return _mapper.Map<TankPumpProcomDto>(existing);
    }

    public async Task DeleteAsync(int id)
    {
        var existing = await _repository.GetByIdAsync(id);
        if (existing == null) throw new KeyNotFoundException("Not found");

        await _repository.DeleteAsync(existing);
    }
}
}

