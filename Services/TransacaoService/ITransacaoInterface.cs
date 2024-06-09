using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;

namespace Financas.Services.TransacaoService
{
    public interface ITransacaoInterface
    {
        RetornoModel<TransacaoModel> AdicionarTransacao(TransacaoModel transacao);
        RetornoModel<List<TransacaoModel>> BuscarTodasTransacoes();
    }
}