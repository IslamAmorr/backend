
    using Application.Interfaces.IService;
using Domain.DTOs;
using Domain.models;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

    namespace Tunav_AirLiquide.WebApi.Controllers
    {

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IHttpClientFactory _httpClientFactory;


        public AuthController(IAuthService authService, IHttpClientFactory httpClientFactory)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }


        // POST: api/Auth/login
        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> Login([FromBody] LoginDto loginDto)
        {
            var tokenResponse = await _authService.LoginAsync(loginDto);
            if (tokenResponse == null)
                return Unauthorized("Invalid credentials");

            return Ok(tokenResponse);
        }

        // POST: api/Auth/register
        [HttpPost("register")]
        public async Task<ActionResult<AccountDto>> Register([FromBody] AccountDto registerDto)
        {
            var createdUser = await _authService.RegisterAsync(registerDto);
            if (createdUser == null)
                return BadRequest("User already exists");

            return Ok(createdUser);
        }


        [HttpPost("verify-recaptcha")]
        public async Task<IActionResult> VerifyRecaptcha([FromBody] RecaptchaRequest request)
        {
            if (request?.RecaptchaToken == null)
            {
                return BadRequest("Recaptcha token is required");
            }

            Console.WriteLine($"Received Recaptcha Token: {request.RecaptchaToken}, Username: {request.Username}");


            var secretKey = "6LcaV_cqAAAAANGiHrc4OLTjh-ncuhrfes3vmhx8";
            var client = _httpClientFactory.CreateClient();
            var response = await client.PostAsync(
                $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={request.RecaptchaToken}",
                null);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, new { message = "Error while verifying reCAPTCHA" });
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine("reCAPTCHA API Response: " + jsonResponse);

            if (jsonResponse.Contains("\"success\": true"))
            {
                return Ok(new { message = "reCAPTCHA validé !" });
            }
            else
            {
                return BadRequest(new { message = "Échec de la validation reCAPTCHA !" });
            }
        }


        public class RecaptchaRequest
        {
            public string? RecaptchaToken { get; set; }
            public string? Username { get; set; }
        }
    }
}
