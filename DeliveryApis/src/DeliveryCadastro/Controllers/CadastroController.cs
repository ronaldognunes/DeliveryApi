using DeliveryCadastro.CadastroServices;
using DeliveryCadastro.Dtos;
using DeliveryCadastro.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryCadastro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly ILogger<CadastroController> _logger;
        private readonly IUsuarioService _usuarioService;
        public CadastroController(ILogger<CadastroController> logger
                                , IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService; 
        }

        [HttpGet("usuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> RetornarUsuarios()
        {
            var usuarios = await _usuarioService.RetornartodosUsuarios();
            
            return Ok(usuarios);
        }

        [HttpPost("Cadastrar-usuario")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] Usuario usuario)
        {
            var sucesso = await _usuarioService.CadastrarUsuario(usuario);
            if(sucesso)
                return Ok();

            return BadRequest();
        }

        [HttpPut("alterar-endereco-usuario/{id:int}")]
        public async Task<IActionResult> AlterarEnderecoDoUsuario(int id, [FromBody] EnderecoDto endereco)
        {
            return Ok();
        }

        [HttpDelete("excluir-usuario/{id:int}")]
        public async Task<IActionResult> ExcluirUsuario(int id)
        {
            var sucesso = await _usuarioService.DeletarUsuario(id);
            if (sucesso)
                return Ok();
            return NoContent();
        }

        [HttpPost("efetuar-login")]
        public async Task<ActionResult<UsuarioDto>> EfetuarLogin([FromBody] LoginDto login)
        {
            return Ok();
        }

        [HttpPut("alterar-senha-usuario/{id:int}")]
        public async Task<IActionResult> AlterarSenhaDoUsuario(int id , [FromBody] UsuarioDto usuario)
        {
            return Ok();
        }
    }
}
