using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;
using Financas.Services.TransacaoService;
using Microsoft.AspNetCore.Mvc;

namespace Financas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoInterface _transacao;
        public TransacaoController(ITransacaoInterface transacao)
        {
            _transacao = transacao;
        }
        [HttpPost]
        public async Task<ActionResult<RetornoModel<TransacaoModel>>> Transacao(TransacaoModel transacao)
        {
            return Ok( await _transacao.AdicionarTransacao(transacao));
        }

        [HttpGet]
        public async Task<ActionResult<RetornoModel<TransacaoModel>>> GetTodasTransacoes()
        {
            return Ok( await _transacao.BuscarTodasTransacoes());
        }
    }
}