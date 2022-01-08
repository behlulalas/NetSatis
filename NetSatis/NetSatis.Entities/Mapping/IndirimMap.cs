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
    class IndirimMap:EntityTypeConfiguration<Indirim>
    {
        public IndirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.IndirimTuru).HasMaxLength(15);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Indirimler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            this.Property(p => p.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            this.Property(p => p.BitisTarihi).HasColumnName("BitisTarihi");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
