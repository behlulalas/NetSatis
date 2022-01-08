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
    public class PersonelMap : EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Unvani).HasMaxLength(15);
            this.Property(p => p.PersonelKodu).HasMaxLength(12);
            this.Property(p => p.PersonelAdi).HasMaxLength(50);
            this.Property(p => p.TcKimlikNo).HasMaxLength(11);
            this.Property(p => p.CepTelefonu).HasMaxLength(20);
            this.Property(p => p.Telefon).HasMaxLength(20);
            this.Property(p => p.Fax).HasMaxLength(20);
            this.Property(p => p.EMail).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(50);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.PrimOrani).HasPrecision(5,2);
            this.Property(p => p.AylikMaas).HasPrecision(12,2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Personeller");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Calisiyor).HasColumnName("Calisiyor");
            this.Property(p => p.Unvani).HasColumnName("Unvani");
            this.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.TcKimlikNo).HasColumnName("TcKimlikNo");
            this.Property(p => p.IseGirisTarihi).HasColumnName("IseGirisTarihi");
            this.Property(p => p.IstenCikisTarihi).HasColumnName("IstenCikisTarihi");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
            this.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            this.Property(p => p.AylikMaas).HasColumnName("AylikMaas");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama"); 
        }
    }
}
