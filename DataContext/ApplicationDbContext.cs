using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financas.Models;
using Microsoft.EntityFrameworkCore;

namespace Financas.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TransacaoModel> Transacoes { get; set; }
        public DbSet<ProjetoModel> Projetos { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
    }
}