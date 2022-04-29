using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace GBF
{
    public partial class Fiche : Form
    {
        public Fiche()
        {
            InitializeComponent();
        }

        private void D1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vali_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }

        public void GeneratePDF()
        {
            // Date et dir. du fichier
            DateTime now = DateTime.Now;
            string outFile = Environment.CurrentDirectory + "/fiche.pdf";

            // Background / Images
            System.Drawing.Image background = Properties.Resources.background;
            System.Drawing.Image lgbf = Properties.Resources.lgbf;

            iTextSharp.text.Image gbf = iTextSharp.text.Image.GetInstance(lgbf, System.Drawing.Imaging.ImageFormat.Png);



            // Création du document
            Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(background, System.Drawing.Imaging.ImageFormat.Png);

            jpg.ScaleToFit(3100, 850);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
            jpg.SetAbsolutePosition(0, 0);

            // Edition du document
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();
            doc.Add(jpg);


            // Ressources
            BaseColor bGBF = new BaseColor(46, 87, 152); // Bleu GBF
            BaseColor rGBF = new BaseColor(238, 90, 155); // Rose GBF

            BaseColor blanc = new BaseColor(255, 255, 255);

            Font PTitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blanc);

            // Document \\
            // Paragraphes
            Paragraph p1 = new Paragraph("\n \n \n \n" + "Domicile", PTitre);
            
            p1.Alignment = Element.ALIGN_CENTER;
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add(Chunk.TABBING);
            p1.Add("Extérieur" + "\n \n");
            doc.Add(p1);



            // Table
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 92;

            // Cell

            gbf.ScaleToFit(32, 32);

            PdfPCell celli = new PdfPCell();

            //Domicile 1

            ACell(L1.Text, blanc, table);

            //Fin

            ACell("ES1", bGBF, table);

            //Ext 1
            ACell("E1", blanc, table);
            //Fin

            ACell("L1", bGBF, table);
            ACell("L2", bGBF, table);
            ACell("L3", bGBF, table);
            ACell("L4", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L6", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L2", bGBF, table);
            ACell("L3", bGBF, table);
            ACell("L4", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L6", bGBF, table);

            ACell("D2", blanc, table);
            ACell("ES2", bGBF, table);
            ACell("E2", blanc, table);

            ACell("L1", bGBF, table);
            ACell("L2", bGBF, table);
            ACell("L3", bGBF, table);
            ACell("L4", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L6", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L2", bGBF, table);
            ACell("L3", bGBF, table);
            ACell("L4", bGBF, table);
            ACell("L1", bGBF, table);
            ACell("L6", bGBF, table);

            ACell("D3", blanc, table);
            ACell("ES3", bGBF, table);
            ACell("E3", blanc, table);



            doc.Add(table);

            // TEST
            //PdfContentByte canvas = writer.DirectContent;
            //Reectangle(canvas, BaseColor.WHITE, 1, 1, 50, 30);


            // Fin
            doc.Close();
            Process.Start(@"cmd.exe", @"/c" + outFile);



        }

        private void ACell(string str, BaseColor c, PdfPTable t)
        {
            PdfPCell cello = new PdfPCell(new Phrase(str));

            cello.BackgroundColor = c;
            cello.BorderColor = c;
            cello.Padding = 20;
            t.AddCell(cello);
        }



        // Trash
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll_2(object sender, ScrollEventArgs e)
        {

        }
    }
}
