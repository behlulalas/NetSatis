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
    public class StokMap:EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.StokGrubu).HasMaxLength(30);
            this.Property(p => p.StokAltGrubu).HasMaxLength(30);
            this.Property(p => p.Marka).HasMaxLength(30);
            this.Property(p => p.Modeli).HasMaxLength(30);
            this.Property(p => p.OzelKod1).HasMaxLength(30);
            this.Property(p => p.OzelKod2).HasMaxLength(30);
            this.Property(p => p.OzelKod3).HasMaxLength(30);
            this.Property(p => p.OzelKod4).HasMaxLength(30);
            this.Property(p => p.GarantiSuresi).HasMaxLength(15);
            this.Property(p => p.UreticiKodu).HasMaxLength(20);
            this.Property(p => p.AlisFiyati1).HasPrecision(12,2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12,2);
            this.Property(p => p.AlisFiyati3).HasPrecision(12,2);
            this.Property(p => p.SatisFiyati1).HasPrecision(12,2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12,2);
            this.Property(p => p.SatisFiyati3).HasPrecision(12,2);
            this.Property(p => p.MinStokMiktari).HasPrecision(12,3);
            this.Property(p => p.MaxStokMiktari).HasPrecision(12,3);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Stoklar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.StokGrubu).HasColumnName("StokGrubu");
            this.Property(p => p.StokAltGrubu).HasColumnName("StokAltGrubu");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Modeli).HasColumnName("Modeli");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            this.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            this.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
            this.Property(p => p.GarantiSuresi).HasColumnName("GarantiSuresi");
            this.Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
            this.Property(p => p.AlisFiyati1).HasColumnName("AlisFiyati1");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(p => p.SatisFiyati1).HasColumnName("SatisFiyati1");
            this.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(p => p.SatisFiyati3).HasColumnName("SatisFiyati3");
            this.Property(p => p.MinStokMiktari).HasColumnName("MinStokMiktari");
            this.Property(p => p.MaxStokMiktari).HasColumnName("MaxStokMiktari");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
