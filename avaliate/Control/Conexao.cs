using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;

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
        }
    }
