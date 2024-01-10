using Microsoft.EntityFrameworkCore;

namespace StudentskiDogodki.Pages
{
    public class BazaContext : DbContext
    {
        public DbSet<Dogodek> Dogodki { get; set; }

        public DbSet<Fotografija> Fotografije { get; set; }

        public DbSet<Rezervacija> Rezervacije { get; set; }
        public DbSet<Nakup> Nakupi { get; set; }
        public DbSet<Karta> Karte { get; set; }
        public DbSet<Popust> Popusti { get; set; }
        public DbSet<Uporabnik> Uporabniki { get; set; }

        public string DbPath { get; }

        public BazaContext()
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(startupPath, "BazaDB.db");
        }
      

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
