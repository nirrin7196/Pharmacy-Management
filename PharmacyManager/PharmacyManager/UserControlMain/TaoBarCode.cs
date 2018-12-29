using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace PharmacyManager.UserControlMain
{
    public partial class TaoBarCode : UserControl
    {
        public TaoBarCode()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btn_taoma_Click(object sender, EventArgs e)
        {
            string barcode = txt_ma.Text;


            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var barcodeImage = brCode.Draw(barcode, 80, 2);

            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new System.Drawing.Font("Consolas", 20))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(barcode, font, brush, resultImage.Width / 2, resultImage.Height + 10, format);
            }

            img_barcode.Image = resultImage;

            
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("D:/Test.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(img_barcode.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            doc.Add(PNG);

            PdfPTable table = new PdfPTable(6);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            //table.AddCell(PNG);
            //table.AddCell(PNG);
            //table.AddCell(PNG);
            //table.AddCell(PNG);

            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            table.AddCell(PNG);
            //table.AddCell(PNG);
            //table.AddCell(PNG);
            // table.AddCell(PNG);
            //table.AddCell(PNG);

            doc.Add(table);
            doc.Close();
        }
    }
}
