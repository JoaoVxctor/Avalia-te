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
using System.Data.SqlClient;

namespace avaliate
{
    public partial class cadastro : Form
    {
        Conexao con = new Conexao();

         
        Boolean contaExiste = false;

        public cadastro()
        {
            InitializeComponent();

            //tenta criar uma conexão com o banco
            using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
            {
                //abre a conexão com o banco
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome, id FROM materia", conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        materia.Items.Add(reader.GetString(0));
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome, id FROM nivelensino", conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        nivelEnsino.Items.Add(reader.GetString(0));
                }

            }
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
            if (!verificaCampos())
                MessageBox.Show("Por favor, preencha todos os campos antes de prosseguir");
            else
            {
                if (senha.Text.Equals(confirmarSenha.Text))
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                    {
                        //abre a conexão com o banco
                        conn.Open();

                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;

                            using (NpgsqlCommand sel = new NpgsqlCommand("SELECT id FROM professor WHERE email = @email", conn))
                            {
                                sel.Parameters.AddWithValue("email", email.Text);

                                using (NpgsqlDataReader reader = sel.ExecuteReader())
                                {
                                    while (reader.Read())
                                        contaExiste = true;
                                }
                            }

                            if (!contaExiste)
                            {
                                cmd.CommandText = "INSERT INTO professor (nome, email, senha)" +
                                "VALUES ( @nome, @email, @senha)";

                                cmd.Parameters.AddWithValue("nome", nome.Text);
                                cmd.Parameters.AddWithValue("email", email.Text);
                                cmd.Parameters.AddWithValue("senha", senha.Text);

                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "INSERT INTO conjuncao (fk_professor, fk_materia, fk_nivelensino)" +
                                "VALUES ((SELECT id FROM professor WHERE email = @email),(SELECT id FROM materia WHERE nome = @materia)," +
                                "(SELECT id FROM nivelensino WHERE nome = @nivelensino));";

                                cmd.Parameters.AddWithValue("email", email.Text);
                                cmd.Parameters.AddWithValue("materia", materia.GetItemText(materia.SelectedItem).Trim());
                                cmd.Parameters.AddWithValue("nivelensino", nivelEnsino.GetItemText(nivelEnsino.SelectedItem).Trim());

                                using (NpgsqlCommand sel = new NpgsqlCommand("SELECT professor.id, conjuncao.fk_materia, conjuncao.fk_nivelensino FROM professor, " +
                                    "conjuncao WHERE email = @email AND fk_professor = (SELECT id FROM professor WHERE email = @email); ", conn))
                                {
                                    sel.Parameters.AddWithValue("email", email.Text);

                                    using (NpgsqlDataReader reader = sel.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            LoginInfo.id = reader.GetInt32(0);
                                            LoginInfo.materia = reader.GetInt32(1);
                                            LoginInfo.nivelEnsino = reader.GetInt32(2);
                                        }
                                    }
                                }

                                cmd.ExecuteNonQuery();
                            }
                        }

                    }
                    if (!contaExiste)
                    {
                        LoginInfo.nome = nome.Text;
                      
                        MessageBox.Show("Cadastro feito com sucesso");
                        this.Hide();
                        var menu = new Menu();
                        menu.Closed += (s, args) => this.Close();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email já cadastrado");
                        contaExiste = false;
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não batem");
                }
            }
        }

        private Boolean verificaCampos()
        {
            if (nome.Text == null || nome.Text == "")
                return false;

            if (email.Text == null || email.Text == "")
                return false;

            if (materia.GetItemText(materia.SelectedItem) == null || materia.GetItemText(materia.SelectedItem) == "")
                return false;

            if (nivelEnsino.GetItemText(materia.SelectedItem) == null || nivelEnsino.GetItemText(materia.SelectedItem) == "")
                return false;

            if (senha.Text == null || senha.Text == "")
                return false;

            if (confirmarSenha.Text == null || confirmarSenha.Text == "")
                return false;

            return true;
        }

    }
}
