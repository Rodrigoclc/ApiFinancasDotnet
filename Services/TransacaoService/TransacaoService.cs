using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Db;
using Financas.Models;

namespace Financas.Services.TransacaoService
{
    public class TransacaoService : ITransacaoInterface
    {
        public DbContext DbContext = new DbContext();
        public RetornoModel<TransacaoModel> AdicionarTransacao(TransacaoModel transacao)
        {
            RetornoModel<TransacaoModel> retornoModel = new();
            try
            {
                DbContext.AddTransacao(transacao);
                retornoModel.Objeto = DbContext.BuscarTransacao(transacao);
            }
            catch (Exception ex)
            {
                retornoModel.Mensagem = ex.Message;
                retornoModel.Sucesso = false;
            }

            return retornoModel;
        }

        public RetornoModel<List<TransacaoModel>> BuscarTodasTransacoes()
        {
            RetornoModel<List<TransacaoModel>> retornoModel = new();
            try
            {
                retornoModel.Objeto = DbContext.ListarTodasTransacoes();
            }
            catch (Exception ex)
            {
                retornoModel.Mensagem = ex.Message;
                retornoModel.Sucesso = false;
            }

            return retornoModel;
        }
    }
}