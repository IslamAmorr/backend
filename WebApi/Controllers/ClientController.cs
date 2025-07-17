using Application.Interfaces.IServices;
using Application.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace TunavProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IService<CustomerDto,int> _serviceClient;

    public ClientController(IService<CustomerDto, int> serviceClient)
    {
        _serviceClient = serviceClient;
    }
        
         [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clients = await _serviceClient.GetAllAsync();
            return Ok(clients);
        }




        [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var client = await _serviceClient.GetByIdAsync(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CustomerDto client)
    {
        if (client == null)
        {
            return BadRequest("client is null.");
        }

        var createdclient = await _serviceClient.AddAsync(client);
        return CreatedAtAction(nameof(GetById), new { id = createdclient.Id }, createdclient);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] CustomerDto client)
    {
        if (client == null || client.Id != id)
        {
            return BadRequest("client is null or ID mismatch.");
        }

        var existingclient = await _serviceClient.GetByIdAsync(id);
        if (existingclient == null)
        {
            return NotFound();
        }

        await _serviceClient.UpdateAsync(client);
        return Ok(client);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var client = await _serviceClient.GetByIdAsync(id);
        if (client == null)
        {
            return NotFound();
        }

        await _serviceClient.DeleteAsync(id);
        return NoContent();
    }
}
}