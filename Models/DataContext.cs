using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<Produto> Produtos {get;set;}
        public DbSet<CarrinhoItem> CarrinhoItems {get; set;}
    }
}
