using Application.Interfaces.IRepository;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Hubs;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Tunav_AirLiquide.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefreshController : ControllerBase
    {
        private readonly IRefreshRepository _refreshRepository;
        private readonly IHubContext<RefreshHub> _hubContext;

        public RefreshController(IRefreshRepository refreshService, IHubContext<RefreshHub> hubContext)
        {
            _refreshRepository = refreshService;
            _hubContext = hubContext;
        }



        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetByCustomer(int customerId)
        {
            var list = await _refreshRepository.GetProductsByCustomer(customerId);
            return  Ok(list) ;
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _refreshRepository.GetProductsForAllCustomers();
            return Ok(list);
        }


        [HttpGet("ByType")]
        public async Task<IActionResult> GetAllByType(string type)
        {
            var list = await _refreshRepository.GetProductsByTypeForAllCustomers(type);
            return Ok(list);
        }

        [Route("api/GetProductsById")]

        [HttpGet]
        public async Task<IActionResult> GetProductsById(string eqId)
        {
            var list = await _refreshRepository.GetEquipementById(eqId);
            return  Ok(list);

        }



        [HttpGet("AllCustomerNameID")]
        public async Task<IActionResult> GetAllCustomer()
        {
            var list = await _refreshRepository.GetAllCustomer();
            return Ok(list);
        }

        [HttpGet("LastAlert")]
        public async Task<IActionResult> GetLatestAlerts(string equipmentId, DateTime? startDate = null, DateTime? endDate = null, int count = 10)
        {
            var list = await _refreshRepository.GetLatestAlerts(equipmentId, startDate, endDate, count);
            return Ok(list);
        }

    }
}
