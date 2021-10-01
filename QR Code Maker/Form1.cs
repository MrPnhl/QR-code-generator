using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Maker
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string text = txttext.Text;
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(qRCodeData);
            Bitmap image = code.GetGraphic(20);
            picturebox.Image = image;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = new Bitmap(picturebox.Image);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Files|*.png";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    bitmap1.Save(sfd.FileName, ImageFormat.Png);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        Bitmap bitmap;
        private void btnprint_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = picturebox.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(picturebox.Image);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(picturebox.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(picturebox.Image, 0, 0);
        }
    }
}
