using Application.Interfaces.IServices;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TankPumpProcomController : ControllerBase
    {
        private readonly IService<TankPumpProcomDto, int> _service;

        public TankPumpProcomController(IService<TankPumpProcomDto, int> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TankPumpProcomDto>>> GetAll() =>
            Ok(await _service.GetAllAsync());


        [HttpGet("{id}")]
        public async Task<ActionResult<TankPumpProcomDto>> GetById(int id) =>
            Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<ActionResult<TankPumpProcomDto>> Create(TankPumpProcomDto dto) =>
            Ok(await _service.AddAsync(dto));

        [HttpPut("{id}")]
        public async Task<ActionResult<TankPumpProcomDto>> Update(int id, TankPumpProcomDto dto)
        {
            dto.Id = id;
            return Ok(await _service.UpdateAsync(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}