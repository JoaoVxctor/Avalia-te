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
    

        public Conexao() {
            connString =  @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=avaliate"; 
           
        }

         public String getConn() {
            return connString;
        }
        public void createDB() {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                }
            }

            catch (NpgsqlException e)
            {
                if (e.ErrorCode == -2147467259){
                    try
                    {
                        
                        connString = @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=postgres";
                        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();
                            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome, id FROM nivelensino", conn.getConn())) ;
                        }
                        
                    }
                    catch {
                        MessageBox.Show("Banco de dados falhou");
                    }
                }

               
            }
        }
    }
}
