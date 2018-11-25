using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avaliate
{
    public partial class MontagemProva : Form
    {
        int index = 0;

        public MontagemProva()
        {
            InitializeComponent();
            string[] items = new string[] {"QUESTÃO 1","QUESTÃO 2","QUESTÃO 3","QUESTÃO 4" };
            listBox1.Items.AddRange(items);
           
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

                list1.DoDragDrop(list1.Items[index].ToString(), DragDropEffects.Move);

            }

        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String))) {

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
            list2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            listBox1.Items.RemoveAt(index);
            

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
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
            list1.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            listBox2.Items.RemoveAt(index);
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox list2 = sender as ListBox;
            index = list2.IndexFromPoint(e.X, e.Y);

            if (index >= 0 & e.Button == MouseButtons.Left)
            {

                list2.DoDragDrop(list2.Items[index].ToString(), DragDropEffects.Move);

            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i=0;
            var fonte =  new Font("Times New Roman", 14);
            foreach (string item in listBox2.Items){ 

            e.Graphics.DrawString(listBox2.Items[i].ToString(), fonte, Brushes.Black, new PointF(100, i*50));
            i++;

            }
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
    }
}
