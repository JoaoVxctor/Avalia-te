using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;
using avaliate.Control;

namespace avaliate
{
    public class Conexao
    {
        private  string connString;
        Boolean contaExiste = false;

        public Conexao() {
            connString =  @"Host=127.0.0.1;Username=postgres;Password=ipmh61r3;Database=avaliate"; 
           
        }

         public String getConn() {
            return connString;
        }

        public Boolean accountVerify(NpgsqlCommand cmd, string email, string senha) {
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("senha", senha);

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    LoginInfo.id = reader.GetInt32(0);
                    LoginInfo.nome = reader.GetString(1);
                    contaExiste = true;
                }
            }
            return contaExiste;
         }
    
        public Boolean login(Conexao con, string email, string senha) {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                Boolean contaExiste;

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, nome FROM professor WHERE email = @email AND senha = @senha", conn))
                {
                    contaExiste = con.accountVerify(cmd, email, senha);
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

                    return true;
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos");
                    return false;
                }

                conn.Close();
            }



        }





    public void createDB() {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    
                }
            }

            catch (NpgsqlException e)
            {
               
                    
                        MessageBox.Show("Banco de dados falhou" + e.ToString());
                    
             }

               
            }

    public void getQuestao(Conexao con, System.Windows.Forms.ComboBox combobox) {
            using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "SELECT  questoes.id,tipo,titulo,enunciado,resposta FROM questoes INNER JOIN professor ON  questoes.fk_professor = professor.id where professor.id = " + LoginInfo.id;

                    

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        combobox.DisplayMember = "titulo";

                        combobox.ValueMember = "id";

                        while (reader.Read())
                        {
                            combobox.Items.Add(new Questao { id = reader.GetInt32(0).ToString(), titulo = reader.GetString(2) });

                        }
                    }

                }

                conn.Close();
            }

        }


        public void questaoDataChange(Conexao con, string i,System.Windows.Forms.ComboBox combobox, System.Windows.Forms.TextBox titulo, System.Windows.Forms.RichTextBox enunciado, System.Windows.Forms.RichTextBox resposta,System.Windows.Forms.ComboBox cbb )
        {
            if (i == "")
            {
                cleanCampos(combobox, titulo, enunciado, resposta, cbb);
            }
            else {
                using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                    

                        cmd.CommandText = "SELECT  id,tipo,titulo,enunciado,resposta FROM questoes  WHERE id = ' " + i + " ' ";


                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            combobox.SelectedItem = reader.GetString(1);
                            titulo.Text = reader.GetString(2);
                            enunciado.Text = reader.GetString(3);
                            resposta.Text = reader.GetString(4);

                            combobox.ValueMember = reader.GetInt16(0).ToString();
                            }
                        

                        }

                    }
                    conn.Close();

                }
               }

        }

        public void deletaQuestao(Conexao con, string i, System.Windows.Forms.ComboBox combobox, System.Windows.Forms.TextBox titulo, System.Windows.Forms.RichTextBox enunciado, System.Windows.Forms.RichTextBox resposta,System.Windows.Forms.ComboBox cbb)
        {
            try { 
                using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM questoes  WHERE id = '" + i+"' ";
                    


                 
                        cmd.ExecuteNonQuery();

                        using (NpgsqlCommand cmd2 = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;

                            cmd.CommandText = "DELETE FROM questao  WHERE q.id = '" + i + "' ";
                        }

                        }
                    conn.Close();

                    cleanCampos(combobox, titulo, enunciado, resposta,cbb);

                    combobox.ValueMember = null;
                    MessageBox.Show("Questão deletada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

                MessageBox.Show("Algo deu errado", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        public void atualizaQuestao(Conexao con, string i, System.Windows.Forms.ComboBox combobox, System.Windows.Forms.TextBox titulo, System.Windows.Forms.RichTextBox enunciado, System.Windows.Forms.RichTextBox resposta,ComboBox cbb)
        {
               try 
            {
            using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE questoes SET tipo='"+ combobox.SelectedItem.ToString() + "' , enunciado='"+enunciado.Text+ "', resposta='" + resposta.Text + "', titulo ='" + titulo.Text + "' WHERE id = '" + i + "' ";

                        

                        cmd.ExecuteNonQuery();
                        
          
                    }
                    conn.Close();

                    cleanCampos(combobox, titulo, enunciado, resposta,cbb);


                    MessageBox.Show("Questão Atualizada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cleanCampos(combobox, titulo, enunciado, resposta,cbb);
                }
            }
            catch
            {

                MessageBox.Show("Algo deu errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void cleanCampos( System.Windows.Forms.ComboBox combobox, System.Windows.Forms.TextBox titulo, System.Windows.Forms.RichTextBox enunciado, System.Windows.Forms.RichTextBox resposta, System.Windows.Forms.ComboBox cbb)
        {
            cbb.SelectedItem = null;
            combobox.SelectedItem = null;
            titulo.Text = null;
            enunciado.Text = null;
            resposta.Text = null;

        }






    }
}
