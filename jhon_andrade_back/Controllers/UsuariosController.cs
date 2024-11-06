using jhon_andrade_back.Services;
using Microsoft.AspNetCore.Mvc;

namespace jhon_andrade_back.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController:ControllerBase
    {
        private readonly UsuariosService _suariosService;

        public UsuariosController(UsuariosService suariosService)
        {
            _suariosService = suariosService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _suariosService.GetUsuarios();

            return Ok(usuarios);
        }
    }
}
