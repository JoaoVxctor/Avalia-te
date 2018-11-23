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
        public CadastroQuestao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CadastroQuestao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string de conexão com o banco de dados
            string connString = @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=postgres";

            //tenta criar uma conexão com o banco
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                //abre a conexão com o banco
                conn.Open();

                // Executa uma consulta que não retorna nenhum valor
                // Insere um registro na tabela
                /*                using (NpgsqlCommand cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn; //atribui uma conexão ao comando (obrigatorio)

                                    //variáveis contendo os dados que queremos inserir no banco
                                    string nome = "José Campos Almeida";
                                    string cpf = "11122233344";
                                    string endereco = "Rua Jundiaí";
                                    string cep = "11111222";

                                    //seta o comando sql que será executado
                                    cmd.CommandText = "INSERT INTO tb_cliente (nome, cpf, endereco, cep)" +
                                                      "VALUES ( @nome, @cpf, @endereco, @cep)";

                                    //seta os parametros que deverão ser passados para a consulta sql
                                    cmd.Parameters.AddWithValue("nome", nome);
                                    cmd.Parameters.AddWithValue("cpf", cpf);
                                    cmd.Parameters.AddWithValue("endereco", endereco);
                                    cmd.Parameters.AddWithValue("cep", cep);

                                    //executa o comando / consulta sql
                                    cmd.ExecuteNonQuery();
                                }*/

                //Executa uma consulta que retorna uma tabela
                // Lê todas a linhas da tabela
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM TESTE", conn)) //comando de seleção
                using (NpgsqlDataReader reader = cmd.ExecuteReader()) //executa o comando que retornará uma tabela
                {
                    int numLinha = 0;

                    //lê uma linha
                    while (reader.Read())
                    {

                        Console.WriteLine("Linha: " + numLinha++);
                        Console.WriteLine("\tid: " + reader.GetInt32(0));
                        Console.WriteLine("\tteste: " + reader.GetString(1));
                        Console.WriteLine();

                    }
                }
            }
        }
    }
}
