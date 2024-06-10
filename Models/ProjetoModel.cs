using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financas.Models
{
    public class ProjetoModel
    {
        [Key]
        public int IdProjeto { get; set; }
        public int IdUsuario { get; set; }
        public string NomeProjeto { get; set; }
        public bool Ativo { get; set; }
    }
}