using Application.Interfaces.IService;
using Application.Interfaces.IServices;
using Application.Services;
using Domain.DTOs;
using Domain.models;
using Microsoft.AspNetCore.Mvc;

namespace Tunav_AirLiquide.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipementGestionService _serviceEquipement;




        public EquipmentController(IEquipementGestionService serviceEquipement)
        {
            _serviceEquipement = serviceEquipement;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var equipements = await _serviceEquipement.GetAllAsync();
            return Ok(equipements);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var equipment = await _serviceEquipement.GetByIdAsync(id);
            if (equipment == null)
                return NotFound();
            return Ok(equipment);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EquipementDtooo equipement)
        {
            if (equipement == null)
            {
                return BadRequest("equipement is null.");
            }

            var createdequipement = await _serviceEquipement.AddAsync(equipement);
            return CreatedAtAction(nameof(GetById), new { id = createdequipement.SerialNumber }, createdequipement);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] EquipementDtooo equipement)
        {
            if (equipement == null || equipement.SerialNumber != id.ToString())
            {
                return BadRequest("equipement is null or ID mismatch.");
            }

            var existingequipement = await _serviceEquipement.GetByIdAsync(id);
            if (existingequipement == null)
            {
                return NotFound();
            }

            await _serviceEquipement.UpdateAsync(equipement);
            return Ok(equipement);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var equipement = await _serviceEquipement.GetByIdAsync(id);
            if (equipement == null)
            {
                return NotFound();
            }

            await _serviceEquipement.DeleteAsync(id);
            return NoContent();
        }


        [HttpGet("customersEquipement")]

        public async Task<IActionResult> GetCustomerEquipements()
        {
            var result = await _serviceEquipement.GetCustomerEquipementsAsync();
            return Ok(result);
        }
        [HttpGet("equipements/customer/{customerId}")]
        public async Task<IActionResult> GetCustomerEquipementsById(int customerId)
        {
            var result = await _serviceEquipement.GetCustomerEquipementsByIdAsync(customerId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}