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
        string connString = @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=postgres";
        Boolean contaExiste = false;

        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastro = new cadastro();
            cadastro.Closed += (s, args) => this.Close();
            cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verificaCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de prosseguir");
            }
            else
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, nome FROM professor WHERE email = @email AND senha = @senha", conn))
                    {
                        cmd.Parameters.AddWithValue("email", email.Text);
                        cmd.Parameters.AddWithValue("senha", senha.Text);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginInfo.id = reader.GetInt32(0);
                                LoginInfo.nome = reader.GetString(1);
                                contaExiste = true;
                            }
                        }
                    }

                    if (contaExiste)
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT fk_materia, fk_nivelensino FROM conjuncao WHERE fk_professor = @fk_professor", conn))
                        {
                            cmd.Parameters.AddWithValue("fk_professor", LoginInfo.id);

                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    LoginInfo.materia = reader.GetInt32(0);
                                    LoginInfo.nivelEnsino = reader.GetInt32(1);
                                }
                            }
                        }

                        this.Hide();
                        var menu = new Menu();
                        menu.Closed += (s, args) => this.Close();
                        menu.Show();
                    }
                    else {
                        MessageBox.Show("Usuario ou senha inválidos");
                    }
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
