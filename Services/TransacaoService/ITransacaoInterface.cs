using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;

namespace Financas.Services.TransacaoService
{
    public interface ITransacaoInterface
    {
        Task<RetornoModel<TransacaoModel>> AdicionarTransacao(TransacaoModel transacao);
        Task<RetornoModel<List<TransacaoModel>>> BuscarTodasTransacoes();
    }
}