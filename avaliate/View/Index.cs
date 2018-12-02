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

namespace avaliate
{
    public partial class Index : Form
    {
        Conexao con = new Conexao();
       
      

        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastro = new cadastro();
            cadastro.Closed += (s, args) => this.Close();
            cadastro.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (!verificaCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de prosseguir");
            }
            else
            {
               if( con.login( con,email.Text, senha.Text)) { 
                this.Hide();
                var menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
                }

            }
        }

        private Boolean verificaCampos()
        {
            if (email.Text == null || email.Text == "")
                return false;

            if (senha.Text == null || senha.Text == "")
                return false;

            return true;
        }
    }
}
