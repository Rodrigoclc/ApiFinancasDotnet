using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.DataContext;
using Financas.Models;

namespace Financas.Services.TransacaoService
{
    public class TransacaoService : ITransacaoInterface
    {
        private readonly ApplicationDbContext _context;
        public TransacaoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<RetornoModel<TransacaoModel>> AdicionarTransacao(TransacaoModel transacao)
        {
            RetornoModel<TransacaoModel> retorno = new();

            try
            {                
                _context.Transacoes.Add(transacao);
                await _context.SaveChangesAsync();
                TransacaoModel requisicao = _context.Transacoes.Single(transacaoDB => transacaoDB.Valor == transacao.Valor || transacaoDB.Descricao == transacao.Descricao );
                retorno.Objeto = requisicao;
            }
            catch (Exception exception)
            {
                retorno.Mensagem = exception.Message;
                retorno.Sucesso = false;
            }

            return retorno;
        }

        public async Task<RetornoModel<List<TransacaoModel>>> BuscarTodasTransacoes()
        {
            RetornoModel<List<TransacaoModel>> retorno = new();

            try
            {
                List<TransacaoModel> requisicao = _context.Transacoes.ToList();
                retorno.Objeto = requisicao;
            }
            catch (Exception exception)
            {
                retorno.Mensagem = exception.Message;
                retorno.Sucesso = false;
            }

            return retorno;
        }
    }
}