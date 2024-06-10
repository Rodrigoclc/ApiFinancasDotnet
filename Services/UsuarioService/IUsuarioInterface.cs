using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;
using Financas.RequestModels;

namespace Financas.Services.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<RetornoModel<UsuarioModel>> CadastrarNovoUsuario(UsuarioModel novoUsuario);
        Task<RetornoModel<List<UsuarioModel>>> GetTodosUsuario();
    }
}