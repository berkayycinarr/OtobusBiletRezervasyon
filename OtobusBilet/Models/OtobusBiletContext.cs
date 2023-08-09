using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;


namespace OtobusBilet.Models
{
    public class OtobusBiletContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Otobus> Otobusler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=OtobusBilet;Trusted_Connection=True;");
        }

    }
}
