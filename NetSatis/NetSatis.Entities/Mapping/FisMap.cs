using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Mapping
{
    public class FisMap: EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisBaglantiKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.FaturaUnvani).HasMaxLength(50);
            this.Property(p => p.Telefon).HasMaxLength(20);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.VergiDairesi).HasMaxLength(30);
            this.Property(p => p.VergiNo).HasMaxLength(15);
            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            this.Property(p => p.IskontoTutar).HasPrecision(12, 2);
            this.Property(p => p.Alacak).HasPrecision(12, 2);
            this.Property(p => p.Borc).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fisler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisBaglantiKodu).HasColumnName("FisBaglantiKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerId).HasColumnName("PlasiyerId");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(p => p.Alacak).HasColumnName("Alacak");
            this.Property(p => p.Borc).HasColumnName("Borc");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.HasOptional(c => c.Cari).WithMany(c => c.Fis).HasForeignKey(c => c.CariId);
            this.HasOptional(c => c.Personel).WithMany(c => c.Fis).HasForeignKey(c => c.PlasiyerId);

        }
    }
}
