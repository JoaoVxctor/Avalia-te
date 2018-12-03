using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using System.IO;
using Image = System.Drawing.Image;

namespace avaliate
{
    public partial class MontagemProva : Form
    {
        Questao questao;

        Conexao con = new Conexao();

        Document doc;
        int index = 0;

        public MontagemProva()
        {
            InitializeComponent();

          using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, titulo,enunciado FROM questoes WHERE id IN(" +
                    "SELECT fk_questao FROM questao_materia_nivelensino WHERE fk_materia = @materia AND fk_nivelensino = @nivelensino)", conn))
                {
                    cmd.Parameters.AddWithValue("materia", LoginInfo.materia);
                    cmd.Parameters.AddWithValue("nivelensino", LoginInfo.nivelEnsino);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox1.DisplayMember = "titulo";
                        listBox2.DisplayMember = "titulo";
                        listBox1.ValueMember = "id";
                        listBox2.ValueMember = "id";

                        while (reader.Read())
                        {
                            listBox1.Items.Add(new Questao { id = reader.GetInt32(0).ToString(), titulo = reader.GetString(1) });
                    
                        }
                    }
                }
            }


            }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox list1 = sender as ListBox;
            index = list1.IndexFromPoint(e.X, e.Y);

            if (index >= 0 & e.Button == MouseButtons.Left) {

                list1.DoDragDrop(list1.Items[index], DragDropEffects.Move);

            }

        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Questao))) {

                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            ListBox list2 = sender as ListBox;
            list2.Items.Add(e.Data.GetData(typeof(Questao)));
            listBox1.Items.RemoveAt(index);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Questao)))
            {

                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox list1 = sender as ListBox;
            list1.Items.Add(e.Data.GetData(typeof(Questao)));
            listBox2.Items.RemoveAt(index);
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox list2 = sender as ListBox;
            index = list2.IndexFromPoint(e.X, e.Y);

            if (index >= 0 & e.Button == MouseButtons.Left)
            {

                list2.DoDragDrop(list2.Items[index], DragDropEffects.Move);

            }
        }



        private void imprimir_Click(object sender, EventArgs e)
        {
            doc = new Document(PageSize.A4);
            int i = 0;
            iTextSharp.text.Font fonte = FontFactory.GetFont("Consolas", 12);

            folderBrowserDialog1.ShowDialog();
            var path = folderBrowserDialog1.SelectedPath.ToString()+"/" ;
            var archiveName = nomeArch.Text + ".pdf";
            var output = path + archiveName;

            var cabecalho = pictureBox1.Image;

            using (var fileStream = new System.IO.FileStream(output, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);


                using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                {
                    conn.Open();
                    doc.Open();
                    try
                    {
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(cabecalho, System.Drawing.Imaging.ImageFormat.Png);

                        pdfImage.ScaleToFit(510,240);
                        pdfImage.SetAbsolutePosition(0,842);
                        doc.Add(pdfImage);

                    }
                    catch { MessageBox.Show("Sem cabeçalho"); }
                    
  //                 pdfImage.SetAbsolutePosition(Top);
                   
                    foreach (Questao item in listBox2.Items)
                    {
      

                        using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT titulo,enunciado, resposta FROM questoes WHERE id = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("id", Convert.ToInt32(listBox2.Items[i].ToString()));

                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string s = Convert.ToString(i + 1) + " - " + reader.GetString(0) + "\n\n";
                                    string t = " \t\t " + reader.GetString(1) + "\n\n";
                                    string u = " \n\t " + reader.GetString(2) + "\n\n";

                                    Paragraph a = new Paragraph(s, fonte);
                                    Paragraph b = new Paragraph(t, fonte);
                                    Paragraph c = new Paragraph(u, fonte);


                                    doc.Add(a);
                                    doc.Add(b);
                                    doc.Add(c);

                                }

                            }
                        }
                        
                        i++;
                    
                    }
                    doc.Close();
                }


            }
            
        }

        private void header_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter =  "PNG|*png" , ValidateNames = true 
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK) { }
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        public class Questao
        {
            public string titulo { get; set; }
            public string id { get; set; }

            public override string ToString()
            {
                return this.id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
