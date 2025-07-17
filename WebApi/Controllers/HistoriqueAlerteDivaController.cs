using Application.Interfaces.IService;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoriqueAlerteDivaController : ControllerBase
    {
        private readonly IHistoriqueAlerteDivaService _service;

        public HistoriqueAlerteDivaController(IHistoriqueAlerteDivaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<HistoriqueAlerteDivaDto>>> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<List<HistoriqueAlerteDivaDto>>> GetByCustomerId(int customerId)
        {
            var result = await _service.GetAllByCustomerIdAsync(customerId);
            if (result == null || result.Count == 0)
                return NotFound($"Aucune alerte trouvée pour le client avec l'ID {customerId}.");

            return Ok(result);
        }
    }
}
