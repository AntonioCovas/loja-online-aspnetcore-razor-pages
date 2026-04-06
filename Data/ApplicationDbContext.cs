using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreWebApp.Models;

namespace AspNetCoreWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoItem>()
                .HasKey(x => new { x.IdPedido, x.IdProduto });

            modelBuilder.Entity<Favorito>()
                .HasKey(x => new { x.IdCliente, x.IdProduto });

            modelBuilder.Entity<Visitado>()
                .HasKey(x => new { x.IdCliente, x.IdProduto });
        }

        public DbSet<Produto> Produto { get; set; } = default!;
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Pedido> Pedidos { get; set; } = default!;
        public DbSet<Favorito> Favoritos { get; set; } = default!;
        public DbSet<Visitado> Visitados { get; set; } = default!;
        public DbSet<PedidoItem> PedidoItens { get; set; } = default!;
    }
}
