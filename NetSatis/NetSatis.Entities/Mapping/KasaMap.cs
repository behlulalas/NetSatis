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
    public class KasaMap: EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KasaKodu).HasMaxLength(12);
            this.Property(p => p.KasaAdi).HasMaxLength(30);
            this.Property(p => p.YetkiliKodu).HasMaxLength(12);
            this.Property(p => p.YetkiliAdi).HasMaxLength(50);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Kasalar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            this.Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            this.Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            this.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
