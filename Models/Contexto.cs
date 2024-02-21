using Microsoft.EntityFrameworkCore;
using Comercio.Models;

namespace Comercio.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Comercio.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<Comercio.Models.Produto> Produto { get; set; } = default!;

        public DbSet<Comercio.Models.Venda> Venda { get; set; } = default!;
    }
}
