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
    public class KodMap : EntityTypeConfiguration<Kod>
    {
        public KodMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OnEki).HasMaxLength(6);
            this.Property(p => p.Tablo).HasMaxLength(15);
     

            this.ToTable("Kodlar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Tablo).HasColumnName("Tablo");
            this.Property(p => p.OnEki).HasColumnName("OnEki");
            this.Property(p => p.SonDeger).HasColumnName("SonDeger");
        }

    }
}
