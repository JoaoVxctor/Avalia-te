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
    public partial class CadastroQuestao : Form
    {
        string connString = @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=postgres";

        public CadastroQuestao()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CadastroQuestao_Load(object sender, EventArgs e)
        {

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

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                        cmd.CommandText = "INSERT INTO questoes (fk_professor, tipo, enunciado, resposta, titulo)" +
                                "VALUES ( @fk_professor, @tipo, @enunciado, @resposta, @titulo)";

                        cmd.Parameters.AddWithValue("fk_professor", LoginInfo.id);
                        cmd.Parameters.AddWithValue("tipo", tipoQuestao.GetItemText(tipoQuestao.SelectedItem));
                        cmd.Parameters.AddWithValue("enunciado", enunciado.Text);
                        cmd.Parameters.AddWithValue("resposta", resposta.Text);
                        cmd.Parameters.AddWithValue("titulo", titulo.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                        cmd.CommandText = "INSERT INTO questao_materia_nivelensino (fk_questao, fk_materia, fk_nivelensino)" +
                                "VALUES ( (SELECT id FROM questoes WHERE fk_professor = @fk_professor AND enunciado = @enunciado), @fk_materia, @fk_nivelensino)";

                        cmd.Parameters.AddWithValue("fk_professor", LoginInfo.id);
                        cmd.Parameters.AddWithValue("fk_materia", LoginInfo.materia);
                        cmd.Parameters.AddWithValue("enunciado", enunciado.Text);
                        cmd.Parameters.AddWithValue("fk_nivelensino", LoginInfo.nivelEnsino);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Questão cadastrada com sucesso");
            }
        }

        private Boolean verificaCampos()
        {
            if (tipoQuestao.GetItemText(tipoQuestao.SelectedItem) == null || tipoQuestao.GetItemText(tipoQuestao.SelectedItem) == "")
                return false;

            if (enunciado.Text == null || enunciado.Text == "")
                return false;

            if (titulo.Text == null || titulo.Text == "")
                return false;

            if (resposta.Text == null || resposta.Text == "")
                return false;

            return true;
        }
    }
}
