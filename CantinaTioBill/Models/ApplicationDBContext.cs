using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaTioBill.Models
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Database=billdb;username=postgres;password=toor");
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FM4L43IE;Initial Catalog=BillDb;Persist Security Info=True;User ID=sa;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<Cliente>().ToTable("cliente");
            modelBuilder.Entity<Produto>().ToTable("produto");
            modelBuilder.Entity<Pedido>().ToTable("pedido");
            modelBuilder.Entity<Categoria>().ToTable("categoria");
            modelBuilder.Entity<Endereco>().ToTable("endereco");
            modelBuilder.Entity<Funcionario>().ToTable("funcionario");
            modelBuilder.Entity<Ingrediente>().ToTable("ingrediente");
            modelBuilder.Entity<ProdutoPedido>().ToTable("produto_pedido");*/

            modelBuilder.Entity<ProdutoPedido>().HasKey(k => new { k.PedidoId, k.ProdutoId });
        }

    }
}
