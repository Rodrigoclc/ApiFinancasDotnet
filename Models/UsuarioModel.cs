using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}