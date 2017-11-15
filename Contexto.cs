using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Model.Model
{
    class Contexto:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

    }
}
