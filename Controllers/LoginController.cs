using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Models;
using TaskManagerAPI.Services;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public LoginController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Autenticação fictícia (poderia ser um usuário fixo ou do banco)
            if (request.Usuario == "administrador" && request.Senha == "mv")
            {
                var token = _jwtService.GerarToken(request.Usuario);
                return Ok(new { token });
            }

            return Unauthorized("Usuário ou senha inválidos.");
        }
    }
}
