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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var index = new Index();
            index.Closed += (s, args) => this.Close();
            index.Show();
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
