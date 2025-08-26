using Microsoft.EntityFrameworkCore;
using PersonnageLoLApi.Models;

namespace PersonnageLoLApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<PersonnageLoL> Personnages { get; set; }
    }
}