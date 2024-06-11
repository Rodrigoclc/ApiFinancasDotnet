using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.DataContext;
using Financas.Models;
using Financas.Services.TransacaoService;

namespace ApiFinancasDotnet.Services.ProjetoService
{
    public class ProjetoService : IProjetoInterface
    {
        private readonly ApplicationDbContext _context;
        public ProjetoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<RetornoModel<ProjetoModel>> CriarProjeto(ProjetoModel novoProjeto)
        {
            RetornoModel<ProjetoModel> retorno = new();

            try
            {
                _context.Projetos.Add(novoProjeto);
                await _context.SaveChangesAsync();
                retorno.Objeto = null;
                retorno.Mensagem = "Projeto cadastrado.";
            }
            catch (Exception exception)
            {
                retorno.Mensagem = exception.Message;
                retorno.Sucesso = false;
            }

            return retorno;
        }

        public async Task<RetornoModel<ProjetoModel>> BuscarProjetoPorId(int idProjeto, int idUsuario)
        {
            RetornoModel<ProjetoModel> retorno = new();

            try
            {
                ProjetoModel? requisicao = new();
                requisicao = _context.Projetos.FirstOrDefault(x => x.IdProjeto == idProjeto && x.IdUsuario == idUsuario);
                if (requisicao == null)
                {
                    retorno.Objeto = requisicao;
                    retorno.Mensagem = "Nenhum projeto encontrado.";
                    retorno.Sucesso = false;
                    return retorno;
                }
                retorno.Objeto = requisicao;
                retorno.Mensagem = "Projeto encontrado";
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