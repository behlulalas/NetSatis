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

namespace NetSatis.BackOffice.FiyatDegistir
{
    public partial class FrmFiyatDegistir : DevExpress.XtraEditors.XtraForm
    {
        public List<Entities.Tables.OtherTables.FiyatDegistir> list;
        public bool secildi = false;
        public FrmFiyatDegistir()
        {
            InitializeComponent();
            list = new List<Entities.Tables.OtherTables.FiyatDegistir>
            {
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-1",
                    KolonAdi="AlisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-2",
                    KolonAdi="AlisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-3",
                    KolonAdi="AlisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-1",
                    KolonAdi="SatisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                     FiyatTuru="Satış Fiyatı-2",
                    KolonAdi="SatisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                new Entities.Tables.OtherTables.FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-3",
                    KolonAdi="SatisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                }
            };
            gridcontStoklar.DataSource = list;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }
    }
}