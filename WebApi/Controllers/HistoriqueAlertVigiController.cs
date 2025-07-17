using Application.Interfaces.IService;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoriqueAlertVigiController : ControllerBase
    {
        private readonly IHistoriqueAlertVigiService _service;

        public HistoriqueAlertVigiController(IHistoriqueAlertVigiService service)
        {
            _service = service;
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<IEnumerable<HistoriqueAlertVigiDto>>> GetByCustomerId(int customerId)
        {
            var alertes = await _service.GetAlertesVigiByCustomerId(customerId);
            return Ok(alertes);
        }
    }
}
