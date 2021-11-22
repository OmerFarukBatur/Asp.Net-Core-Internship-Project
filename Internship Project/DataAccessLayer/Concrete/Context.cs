using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-E3MP67O;database=StajProje2;integrated security=true;");
        }
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Proje> Projes { get; set; }
        public DbSet<ProjeGereksinim> ProjeGereksinims { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        //public DbSet<KategoriProje> KategoriProjes { get; set; }
        public DbSet<Pozisyon> Pozisyons { get; set; }
        //public DbSet<PozisyonUye> PozisyonUyes { get; set; }
        public DbSet<Yetenek> Yeteneks { get; set; }
        public DbSet<Takim> Takims { get; set; }
        //public DbSet<TakimUye> TakimUyes { get; set; }
        public DbSet<Maliyet> Maliyets { get; set; }
        public DbSet<Basvuru> Basvurus { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }

    }
}
