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
    public class ServiceClient : IService<CustomerDto,int>
    {
        private readonly IClientRepository _clientRepository;

        private readonly IMapper _mapper;

        public ServiceClient(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            var clients = await _clientRepository.GetAllClientsWithTanksAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(clients);
        }

        public async Task<CustomerDto> GetByIdAsync(int id)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerDto>(client);
        }

        public async Task<CustomerDto> AddAsync(CustomerDto clientDto)
        {
            if (clientDto == null)
                throw new ArgumentNullException(nameof(clientDto));

            var clientEntity = _mapper.Map<Customer>(clientDto);

            var addedClient = await _clientRepository.AddAsync(clientEntity);
            return _mapper.Map<CustomerDto>(addedClient);
        }

        public async Task<CustomerDto> UpdateAsync(CustomerDto clientDto)
        {
            if (clientDto == null)
                throw new ArgumentNullException(nameof(clientDto), "Client is null.");

            var existingClient = await _clientRepository.GetByIdAsync(clientDto.Id);
            if (existingClient == null)
                throw new KeyNotFoundException("Client not found.");

            _mapper.Map(clientDto, existingClient); // met à jour les champs de existingClient à partir de clientDto
            await _clientRepository.UpdateAsync(existingClient);

            return _mapper.Map<CustomerDto>(existingClient);
        }

        public async Task DeleteAsync(int id)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            if (client == null)
                throw new KeyNotFoundException("Client not found.");

            await _clientRepository.DeleteAsync(client);
        }
    }
}
