using Application.Interfaces.IRepository;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertController : ControllerBase
    {
        private readonly IAlertRepository _alertRepository;

        public AlertController(IAlertRepository alertRepository)
        {
            _alertRepository = alertRepository;
        }

        [HttpGet("{equipment}")]
        public async Task<ActionResult<IEnumerable<AlertDto>>> Get(string equipment)
        {
            var list = await _alertRepository.GetByEquipmentAsync(equipment);
            return list.Any() ? Ok(list) : NotFound();
        }
        [HttpGet("count-by-equipment")]
        public async Task<ActionResult<List<AlertCountByEquipmentDto>>> GetAlertCountsByEquipment(int customerId)
        {
            var result = await _alertRepository.GetAlertCountsByCustomerAsync(customerId);
            return Ok(result);
        }

        [HttpGet("customer")]
        public async Task<ActionResult<List<CustomerDto>>> GetAllCustomers()
        {
            var customers = await _alertRepository.GetAllCustomersAsync();
            return Ok(customers);
        }
        [HttpGet("count-Client-Alert")]
        public async Task<ActionResult<List<AlertCountByEquipmentDto>>> GetAlertCountsByCustomer([FromQuery] int customerId)
        {
            if (customerId <= 0)
            {
                return BadRequest("Invalid customer ID.");
            }

            var results = await _alertRepository.GetAlertCountsForCustomerAsync(customerId);
            return Ok(results);
        }
    }


    
}