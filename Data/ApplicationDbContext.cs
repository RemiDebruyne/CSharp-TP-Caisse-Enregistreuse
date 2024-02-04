using Caisse_Enregistreuse.Models;
using Microsoft.EntityFrameworkCore;

namespace Caisse_Enregistreuse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
    }
}
