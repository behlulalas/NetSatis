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
    public class KullaniciRolMap : EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciAdi).HasMaxLength(20);
            this.Property(p => p.FormAdi).HasMaxLength(30);
            this.Property(p => p.KontrolAdi).HasMaxLength(30);

            this.ToTable("KullaniciRolleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.RootId).HasColumnName("RootId");
            this.Property(p => p.ParentId).HasColumnName("ParentId");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.FormAdi).HasColumnName("FormAdi");
            this.Property(p => p.KontrolAdi).HasColumnName("KontrolAdi");
            this.Property(p => p.Yetki).HasColumnName("Yetki");
        }
    }
}
