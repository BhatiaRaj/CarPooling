using CarPooling.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPooling.Data
{
    public class CarpoolingDbContext : DbContext
    {
        public CarpoolingDbContext(DbContextOptions<CarpoolingDbContext> options) : base(options)
        {

        }

        public DbSet<ApplyRequect> ApplyRequests { get; set; }

        public DbSet<Carpooling> OppernigCarpooling { get; set; }
    }
}
