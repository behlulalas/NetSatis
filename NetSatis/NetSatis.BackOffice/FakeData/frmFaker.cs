using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities.DataAccess;
using Bogus;

namespace NetSatis.BackOffice.FakeData
{
    public partial class frmFaker : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        CariDAL cariDAL = new CariDAL();
        StokDAL stokDAL = new StokDAL();
        public frmFaker()
        {
            InitializeComponent();
        }

        public enum CariTuru
        {
            Alıcı,
            Satıcı,
            Toptancı,
            Perakendeci
        }
        public enum Birim
        {
            Adet,
            Koli,
            KG,
            Litre
        }
        private void frmFaker_Load(object sender, EventArgs e)
        {
            #region CariFAKEDATA
            var cariFaker = new Faker<Entities.Tables.Cari>("tr")
               .RuleFor(c => c.Durumu, true)
               .RuleFor(c => c.CariTuru, c => c.PickRandom<CariTuru>().ToString())
               .RuleFor(c => c.CariKodu, c => c.Random.AlphaNumeric(10).ToString())
               .RuleFor(c => c.CariAdi, c => c.Company.CompanyName())
               .RuleFor(c => c.YetkiliKisi, c => c.Person.FirstName)
               .RuleFor(c => c.FaturaUnvani, c => c.Company.CompanySuffix())
               .RuleFor(c => c.CepTelefonu, c => c.Person.Phone)
               .RuleFor(c => c.Telefon, c => c.Person.Phone)
               .RuleFor(c => c.Fax, c => c.Person.Phone)
               .RuleFor(c => c.EMail, c => c.Person.Email)
               .RuleFor(c => c.Web, c => c.Person.Website)
               .RuleFor(c => c.Il, c => c.Address.City())
               .RuleFor(c => c.Ilce, c => c.Address.County())
               .RuleFor(c => c.Semt, c => c.Address.County())
               .RuleFor(c => c.Adres, c => c.Address.FullAddress())
               .RuleFor(c => c.CariGrubu, c => c.Name.JobType())
               .RuleFor(c => c.CariAltGrubu, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod1, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod2, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod3, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod4, c => c.Name.JobType())
               .RuleFor(c => c.VergiDairesi, c => c.Company.CompanyName())
               .RuleFor(c => c.VergiNo, c => c.Random.AlphaNumeric(10).ToString())
               .RuleFor(c => c.IskontoOrani, c => c.Random.Decimal(5, 15))
               .RuleFor(c => c.RiskLimiti, c => c.Random.Decimal(50, 99))
               .RuleFor(c => c.AlisOzelFiyati, c => c.Random.Decimal().ToString("N2"))
               .RuleFor(c => c.SatisOzelFiyati, c => c.Random.Decimal().ToString("N2"))
               .RuleFor(c => c.Aciklama, c => c.Lorem.Sentence());
            for (int i = 0; i < 10; i++)
            {
                var generatedObject = cariFaker.Generate();
                cariDAL.AddOrUpdate(context, generatedObject);
                cariDAL.Save(context);
            }
            #endregion

            #region StokFakeDATA
            var stokFaker = new Faker<Entities.Tables.Stok>("tr")
               .RuleFor(c => c.Durumu, true)
               .RuleFor(c => c.StokKodu, c => c.Random.AlphaNumeric(8).ToString())
               .RuleFor(c => c.StokAdi, c => c.Commerce.ProductName())
               .RuleFor(c => c.Barkod, c => c.Commerce.Ean8())
               .RuleFor(c => c.BarkodTuru, "EAN-8")
               .RuleFor(c => c.Birimi, c => c.PickRandom<Birim>().ToString())
               .RuleFor(c => c.StokGrubu, c => c.Commerce.ProductMaterial().ToString())
               .RuleFor(c => c.StokAltGrubu, c => c.Commerce.ProductMaterial().ToString())
               .RuleFor(c => c.Marka, c => c.Commerce.ProductMaterial())
               .RuleFor(c => c.Modeli, c => c.Commerce.ProductMaterial())
               .RuleFor(c => c.OzelKod1, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod2, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod3, c => c.Name.JobType())
               .RuleFor(c => c.OzelKod4, c => c.Name.JobType())
               .RuleFor(c => c.GarantiSuresi, c => c.Random.Number(1, 5).ToString())
               .RuleFor(c => c.UreticiKodu, c => c.Random.AlphaNumeric(10).ToString())
               .RuleFor(c => c.AlisKdv, c => c.Random.Number(5, 15))
               .RuleFor(c => c.SatisKdv, c => c.Random.Number(5, 15))
               .RuleFor(c => c.AlisFiyati1, c => c.Random.Decimal(5, 100))
               .RuleFor(c => c.AlisFiyati2, c => c.Random.Decimal(5, 100))
               .RuleFor(c => c.AlisFiyati3, c => c.Random.Decimal(5, 100))
               .RuleFor(c => c.SatisFiyati1, c => c.Random.Decimal(101, 200))
               .RuleFor(c => c.SatisFiyati2, c => c.Random.Decimal(101, 200))
               .RuleFor(c => c.SatisFiyati3, c => c.Random.Decimal(101, 200))
               .RuleFor(c => c.MaxStokMiktari, c => c.Random.Decimal(5, 200))
               .RuleFor(c => c.MinStokMiktari, c => c.Random.Decimal(5, 200))
               .RuleFor(c => c.Aciklama, c => c.Lorem.Sentence());
            for (int i = 0; i < 10; i++)
            {
                var generatedObject2 = stokFaker.Generate();
                stokDAL.AddOrUpdate(context, generatedObject2);
                stokDAL.Save(context);
            }
            #endregion

        }
    }
}