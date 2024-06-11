using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancasDotnet.Services.ProjetoService;
using Financas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinancasDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoInterface _projeto;
        public ProjetoController(IProjetoInterface projeto)
        {
            _projeto = projeto;
        }

        [HttpPost]
        public async Task<ActionResult<RetornoModel<ProjetoModel>>> CriarProjeto(ProjetoModel novoProjeto)
        {
            return Ok( await _projeto.CriarProjeto(novoProjeto) );
        }

        [HttpGet]
        [Route("buscar-projeto-por-id/{idProjeto:int}/{idUsuario:int}")]
        public async Task<ActionResult<RetornoModel<ProjetoModel>>> BuscarProjetoPorId(int idProjeto, int idUsuario)
        {
            return Ok( await _projeto.BuscarProjetoPorId(idProjeto, idUsuario) );
        }
    }
}