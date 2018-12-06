using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avaliate.Control;
namespace avaliate.View
{
    public partial class GerenciarQuestoes : Form
    {
        Conexao con = new Conexao();
       
        public GerenciarQuestoes()
        {
            InitializeComponent();
            con.getQuestao(con, comboBox1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i;
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem == ""){
                i = "";
            }
            else{
                i = comboBox1.SelectedItem.ToString();
            }
            
            con.questaoDataChange(con, i , tipoQuestao, titulo, enunciado, resposta,comboBox1);


        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("´Quer mesmo deletar a questão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    string i = comboBox1.SelectedItem.ToString();
                    con.deletaQuestao(con, i,tipoQuestao,titulo,enunciado,resposta,comboBox1);
                    comboBox1.Items.Clear();
                    con.cleanCampos(tipoQuestao, titulo, enunciado, resposta, comboBox1);
                    con.getQuestao(con, comboBox1);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("´Quer mesmo atualizar a questão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                    string i = comboBox1.SelectedItem.ToString();
                    con.atualizaQuestao(con, i, tipoQuestao, titulo, enunciado, resposta,comboBox1);
                    con.questaoDataChange(con, i, tipoQuestao, titulo, enunciado, resposta,comboBox1);
                    comboBox1.Items.Clear();
                    con.cleanCampos(tipoQuestao,titulo,enunciado,resposta, comboBox1);
                    con.getQuestao(con, comboBox1);
            }

        }
    }
}
