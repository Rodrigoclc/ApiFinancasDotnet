using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;

namespace Financas.Db
{
    public class DbContext
    {
        private readonly List<UsuarioModel> _dbUsuarios = [];
        private readonly List<TransacaoModel> _Transacoes = [];

        public void AddUsuario(UsuarioModel usuario)
        {
            _dbUsuarios.Add(usuario);
        }

        public List<UsuarioModel> ListarTodosUsuarios()
        {
            return _dbUsuarios;
        }

        public void AddTransacao(TransacaoModel transacaoModel)
        {
            _Transacoes.Add(transacaoModel);
        }

        public List<TransacaoModel> ListarTodasTransacoes()
        {
            return _Transacoes;
        }

        public TransacaoModel BuscarTransacao(TransacaoModel transacaoModel)
        {
            TransacaoModel retono = new();
            for (int i = 0; i < _Transacoes.Count; i++) 
            {
                if(transacaoModel == _Transacoes[i])
                {
                    retono = _Transacoes[i];
                    break;
                }
            }
            return retono;
        }
    }
}