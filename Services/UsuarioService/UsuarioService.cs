using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.DataContext;
using Financas.Models;
using Financas.RequestModels;

namespace Financas.Services.UsuarioService
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService()
        {
        }

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RetornoModel<UsuarioModel>> CadastrarNovoUsuario(UsuarioModel novoUsuario)
        {
            RetornoModel<UsuarioModel> retorno = new();

            try
            {
                _context.Add(novoUsuario);
                await _context.SaveChangesAsync();
                retorno.Objeto = _context.Usuarios.Single(usuario => usuario.Nome == novoUsuario.Nome && usuario.Senha == usuario.Senha);
            }
            catch (Exception exception)
            {
                retorno.Mensagem = exception.Message;
                retorno.Sucesso = false;
            }
            return retorno;
        }

        public async Task<RetornoModel<List<UsuarioModel>>> GetTodosUsuario()
        {
            RetornoModel<List<UsuarioModel>> retorno = new();
            List<UsuarioModel> requisicao = [];

            try
            {
                requisicao = _context.Usuarios.ToList();
                if(requisicao.Count == 0)
                {
                    retorno.Mensagem = "Nenhum Usuario encontrado";
                }
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