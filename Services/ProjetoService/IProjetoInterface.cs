using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;

namespace ApiFinancasDotnet.Services.ProjetoService
{
    public interface IProjetoInterface
    {
        Task<RetornoModel<ProjetoModel>> CriarProjeto(ProjetoModel novoProjeto);
        Task<RetornoModel<ProjetoModel>> BuscarProjetoPorId(int idProjeto, int idUsuario);
    }
}