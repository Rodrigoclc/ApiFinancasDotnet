using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;
using Financas.Services.UsuarioService;
using Microsoft.AspNetCore.Mvc;
using Financas.RequestModels;

namespace Financas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;
        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }
        [HttpGet]
        public async Task<ActionResult<RetornoModel<List<UsuarioModel>>>> GetTodosUsuario()
        {
            return Ok(await _usuarioInterface.GetTodosUsuario());
        }

        [HttpPost]
        public async Task<ActionResult<RetornoModel<UsuarioModel>>> CriarNovoUsuario(UsuarioModel novoUsuario)
        {
            return Ok(await _usuarioInterface.CadastrarNovoUsuario(novoUsuario));
        }
    }
}