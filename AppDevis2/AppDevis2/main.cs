using System;
using System.Diagnostics;
using System.IO;

//pdf
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Font = iTextSharp.text.Font;


//json
using Newtonsoft.Json;

namespace AppDevis2
{
    public partial class main : Form

    {

        //init
        public List<string[]> Produits = new List<string[]>();
        int prixTotal = 0;

        public main() //when programm start
        {
            InitializeComponent(); //init

            //verifer si il y a le ficher param.json
            string path = Environment.CurrentDirectory + "/param.json";
            bool result = File.Exists(path);

            if (result == false) // si il y est pas tu le créer
            {
                MesInfos infosJson = new MesInfos() { coordonnees = null, verify = false };

                string jsonSerializedObj = JsonConvert.SerializeObject(infosJson, Formatting.Indented);
                File.WriteAllText(Environment.CurrentDirectory + @"/param.json", jsonSerializedObj);

            }

            //tu lis le fichier
            StreamReader r = new StreamReader("param.json");
            string jsonString = r.ReadToEnd();
            //fermer le fichier
            r.Close();


            MesInfos m = JsonConvert.DeserializeObject<MesInfos>(jsonString);

            if (m.coordonnees != null) //si coordonnees != null => mesinfos.Text = m.coordonnees;
            {
                mesinfos.Text = m.coordonnees;

            }

        }


        //button générer pdf
        private void button1_Click(object sender, EventArgs e)
        {
            GeneratePdf();
        }

        //button add cell
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCell();
        }
        //fct pour définir les partularité des cell
        public void AddCellToTab(string str, Font f, BaseColor c, PdfPTable t)
        {
            //Lister produits dans le tab
            PdfPCell cell1 = new PdfPCell(new Phrase(str, f));
            cell1.BackgroundColor = c;
            cell1.Padding = 7;
            cell1.BorderColor = c;
            //cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            t.AddCell(cell1);
        }

        //generate pdf
        public void GeneratePdf()
        {
            string outFile = Environment.CurrentDirectory + "/devis.pdf";
            // Création du document
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();

            //Palette de couleurs
            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor gris = new BaseColor(240, 240, 240);
            BaseColor blanc = new BaseColor(255, 255, 255);

            //police d'écriture
            Font policeTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
            Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, 1, blanc);

            //Page
            //Création paragraphe
            Paragraph p1 = new Paragraph("Camille :" + mesinfos.Text + "\n\n", policeTitre);
            p1.Alignment = Element.ALIGN_LEFT;
            doc.Add(p1);

            Paragraph p2 = new Paragraph("Le Client :" + client.Text + "\n\n", policeTitre);
            p2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p2);

            Paragraph p3 = new Paragraph("Devis : " + titre.Text + "\n\n", policeTitre);
            p3.Alignment = Element.ALIGN_LEFT;
            doc.Add(p3);

            //Création tableau des produits
            PdfPTable tableau = new PdfPTable(3);
            tableau.WidthPercentage = 100;

            //Cel du tab
            AddCellToTab("Désignation", policeTh, blue, tableau);
            AddCellToTab("Qté", policeTh, blue, tableau);
            AddCellToTab("Prix", policeTh, blue, tableau);



            foreach (string[] infosProduit in Produits)
            {
                foreach (string info in infosProduit)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(info));
                    cell.BackgroundColor = gris;
                    cell.Padding = 7;
                    cell.BorderColor = gris;
                    tableau.AddCell(cell);

                }

            }

            doc.Add(tableau);
            doc.Add(new Phrase("\n"));


            Paragraph p4 = new Paragraph("Total = " + prixTotal + "\n\n", policeTitre);
            p4.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p4);


            //Fermer le document
            doc.Close();
            Process.Start(@"cmd.exe", @"/c" + outFile);
        }

        //Add cell and reset input
        public void AddCell()
        {

            string[] infosProduit = new string[3];
            infosProduit[0] = nom.Text;
            infosProduit[1] = qte.Text;
            infosProduit[2] = prix.Text;
            Produits.Add(infosProduit);
            prixTotal += int.Parse(prix.Text) * int.Parse(qte.Text);

            nom.Text = null;
            qte.Text = null;
            prix.Text = null;

            MessageBox.Show("Enregistré !");
        }


        //paramètre
        private void param_Click(object sender, EventArgs e)
        {
            //nouvelle instance de param
            param paramShow = new param();

            paramShow.ShowDialog(); //ouvrir fenetre param

            //tu lis le fichier
            StreamReader r = new StreamReader("param.json");
            string jsonString = r.ReadToEnd();
            MesInfos m = JsonConvert.DeserializeObject<MesInfos>(jsonString);


            if (paramShow.verify == true && paramShow.coordonnees != m.coordonnees)
            {

                mesinfos.Text = paramShow.coordonnees;

                //modify
                m.coordonnees = paramShow.coordonnees;
                m.verify = true;

                //Phase 2 - serialisation de l'objet 
                string jsonSerializedObj = JsonConvert.SerializeObject(m, Formatting.Indented);
                r.Close();
                File.WriteAllText("param.json", jsonSerializedObj);

            }
            // fermer le fichier
            r.Close();


        }

    }
}