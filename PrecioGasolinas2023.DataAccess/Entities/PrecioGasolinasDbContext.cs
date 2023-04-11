using Microsoft.EntityFrameworkCore;

namespace PrecioGasolinas2023.DataAccess.Entities
{
    public class PrecioGasolinasDbContext : DbContext
    {
        public PrecioGasolinasDbContext(DbContextOptions<PrecioGasolinasDbContext> options) : base(options) { }

        public DbSet<Gasolina> Gasolinas { get; set; }
    }
}
