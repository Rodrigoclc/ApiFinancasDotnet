using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancasDotnet.Enums;

namespace Financas.Models
{
    public class CategoriaModel
    {
        [Key]
        public int IdCategoria { get; set; }
        public int IdProjeto { get; set; }
        public int IdUsuario { get; set; }
        public string NomeCategoria { get; set; }
        public RendaDespesaEnum RendaDespesa { get; set; }
        public bool Ativo { get; set; }
    }
}