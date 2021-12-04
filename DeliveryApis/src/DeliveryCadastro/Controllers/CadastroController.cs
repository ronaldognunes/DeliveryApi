using DeliveryCadastro.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryCadastro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly ILogger<CadastroController> _logger;   
        public CadastroController(ILogger<CadastroController> logger)
        {
            _logger = logger;   
        }

        [HttpGet("usuarios")]
        public async Task<ActionResult<IList<UsuarioDto>>> RetornarUsuarios()
        {
            return Ok();
        }

        [HttpPost("Cadastrar-usuario")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDto usuario)
        {
            return Ok();
        }

        [HttpPut("alterar-endereco-usuario/{id:int}")]
        public async Task<IActionResult> AlterarEnderecoDoUsuario(int id, [FromBody] EnderecoDto endereco)
        {
            return Ok();
        }

        [HttpDelete("excluir-usuario/{id:int}")]
        public async Task<IActionResult> ExcluirUsuario(int id)
        {
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
