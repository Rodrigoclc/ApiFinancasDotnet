using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financas.Models
{
    public class TransacaoModel
    {
        [Key]
        public int IdTransacao { get; set; }
        public int IdUsuario { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public bool Ativo { get; set; }
    }
}