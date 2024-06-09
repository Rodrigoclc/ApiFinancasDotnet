using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financas.Models
{
    public class RetornoModel<T>
    {
        public T? Objeto { get; set; }
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; } = true;
    }
}