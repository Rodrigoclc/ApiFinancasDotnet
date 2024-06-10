using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;

namespace Financas.Services.TransacaoService
{
    public class TransacaoService : ITransacaoInterface
    {
        public RetornoModel<TransacaoModel> AdicionarTransacao(TransacaoModel transacao)
        {
            RetornoModel<TransacaoModel> retornoModel = new();

            return retornoModel;
        }

        public RetornoModel<List<TransacaoModel>> BuscarTodasTransacoes()
        {
            RetornoModel<List<TransacaoModel>> retornoModel = new();

            return retornoModel;
        }
    }
}