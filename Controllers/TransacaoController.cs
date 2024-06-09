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
        [HttpPost]
        public IActionResult Transacao(TransacaoModel transacao)
        {
            TransacaoService transacaoService = new();
            return Ok(transacaoService.AdicionarTransacao(transacao));
        }

        [HttpGet]
        public IActionResult GetTodasTransacoes()
        {
            TransacaoService transacaoService = new();
            return Ok(transacaoService.BuscarTodasTransacoes());
        }
    }
}