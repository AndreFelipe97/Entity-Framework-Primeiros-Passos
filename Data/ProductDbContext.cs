using Dominio;
using System.Data.Entity;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProdutoDb")
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
