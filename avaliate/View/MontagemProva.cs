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
using avaliate.Control;

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
                    "SELECT fk_questao FROM conjuncao WHERE fk_materia = @materia AND fk_nivelensino = @nivelensino)", conn))
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
            int i = 0;
           

            if (nomeArch.Text == null || nomeArch.Text == ""){
                nomeArch.Focus();
                nomeArquivoLabel.Text = "É PRECISO SELECIONAR UM NOME";
            }
            else if(pictureBox1.Image == null)
            {
                CabecalhoTxt.Text = "É PRECISO SELECIONAR UM CABECALHO!";
                header.Focus();
            }
            else{

                folderBrowserDialog1.ShowDialog();
                var path = folderBrowserDialog1.SelectedPath.ToString() + "/";
                var archiveName = nomeArch.Text + ".pdf";
                var output = path + archiveName;
                ToPrint print = new ToPrint();

                print.imprimir(pictureBox1.Image, output, con, listBox2.Items, doc);
                pictureBox1.Image = null;
                nomeArch.Text = null;
                CabecalhoTxt.Text = "Cabecalho Não Selecionado.";

                while (listBox2.Items.Count > i){

                    listBox1.Items.Add(listBox2.Items[i]);
                
                    i++;
                
                }

                listBox2.Items.Clear();

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
                CabecalhoTxt.Text = "Cabecalho Selecionado !";
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
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
