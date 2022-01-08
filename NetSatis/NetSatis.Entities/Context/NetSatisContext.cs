using NetSatis.Entities.Mapping;
using NetSatis.Entities.Migrations;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext : DbContext
    {
        public NetSatisContext() : base($"{SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi) ?? "Bağlantı yok !"}")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NetSatisContext, Configuration>());
        }
        public NetSatisContext(string connString,bool olustur=false) : base(connString)
        {
            if (olustur)
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<NetSatisContext, Configuration>());
            }
        }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> HizliSatisGruplari { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod> Kodlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new IndirimMap());
            modelBuilder.Configurations.Add(new HizliSatisMap());
            modelBuilder.Configurations.Add(new HizliSatisGrupMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new KodMap());
        }
    }
}
