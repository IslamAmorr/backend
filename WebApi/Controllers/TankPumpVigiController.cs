using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class TankPumpVigiController : ControllerBase
    {
        private readonly IService<TankPumpVigiDto, int> _service;

        public TankPumpVigiController(IService<TankPumpVigiDto, int> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(TankPumpVigiDto dto) => Ok(await _service.AddAsync(dto));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TankPumpVigiDto dto)
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
