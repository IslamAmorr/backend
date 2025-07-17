using Application.Interfaces.IServices;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TunavProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TankController : Controller
    {
        private readonly IService<TankPumpDto, int> _serviceTank;

        public TankController(IService<TankPumpDto, int> serviceTank)
        {
            _serviceTank = serviceTank;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tanks = await _serviceTank.GetAllAsync();
            return Ok(tanks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tank = await _serviceTank.GetByIdAsync(id);
            if (tank == null)
            {
                return NotFound();
            }
            return Ok(tank);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TankPumpDto tank)
        {
            if (tank == null)
            {
                return BadRequest("tank is null.");
            }

            var createdtank = await _serviceTank.AddAsync(tank);
            return CreatedAtAction(nameof(GetById), new { id = createdtank.Id }, createdtank);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TankPumpDto tank)
        {
            if (tank == null || tank.Id != id)
            {
                return BadRequest("tank is null or ID mismatch.");
            }

            var existingtank = await _serviceTank.GetByIdAsync(id);
            if (existingtank == null)
            {
                return NotFound();
            }

            await _serviceTank.UpdateAsync(tank);
            return Ok(tank); 
                }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tank = await _serviceTank.GetByIdAsync(id);
                if (tank == null)
                {
                    return NotFound();
                }

                await _serviceTank.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erreur : {ex.Message}");
            }
        }

    }
}