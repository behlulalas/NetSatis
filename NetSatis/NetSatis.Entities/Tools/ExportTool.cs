using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.Entities.Tools
{
    public class ExportTool
    {
        XtraForm _form;
        DropDownButton _buton;
        GridView _grid;
        BarManager manager = new BarManager();
        PopupMenu menu;

        public ExportTool(XtraForm form, GridView grid, DropDownButton button)
        {
            _form = form;
            _buton = button;
            _grid = grid;
            menu = new PopupMenu(manager);
            _buton.MenuManager = manager;
            _buton.DropDownControl = menu;

            //PDF
            BarButtonItem pdfExport = new BarButtonItem
            {
                Name = "pdf",
                Caption = "PDF dosyası",
                ImageOptions = { Image = Properties.Resources.PDF }
            };
            pdfExport.ItemClick += Export;
            menu.AddItem(pdfExport);

            //CSV
            BarButtonItem csvExport = new BarButtonItem
            {
                Name = "csv",
                Caption = "CSV dosyası",
                ImageOptions = { Image = Properties.Resources.file_48x48 }

            };
            csvExport.ItemClick += Export;
            menu.AddItem(csvExport);

            //XLSX
            BarButtonItem xlsxExport = new BarButtonItem
            {
                Name = "xlsx",
                Caption = "Excel dosyası",
                ImageOptions = { Image = Properties.Resources.XLSX }

            };
            xlsxExport.ItemClick += Export;
            menu.AddItem(xlsxExport);

            //XLS
            BarButtonItem xlsExport = new BarButtonItem
            {
                Name = "xls",
                Caption = "Excel dosyası",
                ImageOptions = { Image = Properties.Resources.XLS }

            };
            xlsExport.ItemClick += Export;
            menu.AddItem(xlsExport);

            //HTML
            BarButtonItem htmlExport = new BarButtonItem
            {
                Name = "html",
                Caption = "HTML dosyası",
                ImageOptions = { Image = Properties.Resources.HTML }

            };
            htmlExport.ItemClick += Export;
            menu.AddItem(htmlExport);

            //MHT
            BarButtonItem mhtExport = new BarButtonItem
            {
                Name = "mht",
                Caption = "MHT dosyası",
                ImageOptions = { Image = Properties.Resources.MHT }

            };
            mhtExport.ItemClick += Export;
            menu.AddItem(mhtExport);

            //RTF
            BarButtonItem rtfExport = new BarButtonItem
            {
                Name = "rtf",
                Caption = "Rich Text dosyası",
                ImageOptions = { Image = Properties.Resources.RTF }

            };
            rtfExport.ItemClick += Export;
            menu.AddItem(rtfExport);

            //TXT
            BarButtonItem txtExport = new BarButtonItem
            {
                Name = "txt",
                Caption = "Text dosyası",
                ImageOptions = { Image = Properties.Resources.TXT }

            };
            txtExport.ItemClick += Export;
            menu.AddItem(txtExport);

            //WORD
            BarButtonItem docxExport = new BarButtonItem
            {
                Name = "docx",
                Caption = "Word dosyası",
                ImageOptions = { Image = Properties.Resources.export }
            };
            docxExport.ItemClick += Export;
            menu.AddItem(docxExport);
        }

        private void Export(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = $"{e.Item.Caption}|*.{e.Item.Name}";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (e.Item.Name)
                {
                    case "pdf":
                        _grid.ExportToPdf(dialog.FileName);
                        break;
                    case "csv":
                        _grid.ExportToCsv(dialog.FileName);
                        break;
                    case "xlsx":
                        _grid.ExportToXlsx(dialog.FileName);
                        break;
                    case "xls":
                        _grid.ExportToXls(dialog.FileName);
                        break;
                    case "html":
                        _grid.ExportToHtml(dialog.FileName);
                        break;
                    case "mht":
                        _grid.ExportToMht(dialog.FileName);
                        break;
                    case "rtf":
                        _grid.ExportToRtf(dialog.FileName);
                        break;
                    case "txt":
                        _grid.ExportToText(dialog.FileName);
                        break;
                    case "docx":
                        _grid.ExportToDocx(dialog.FileName);
                        break;
                }
            }
        }
    }
}
