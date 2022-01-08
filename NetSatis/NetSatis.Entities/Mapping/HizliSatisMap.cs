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
    public class HizliSatisMap : EntityTypeConfiguration<HizliSatis>
    {
        public HizliSatisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.UrunAdi).HasMaxLength(50);

            this.ToTable("HizliSatislar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
