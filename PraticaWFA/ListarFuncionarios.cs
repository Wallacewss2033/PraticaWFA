using MySql.Data.MySqlClient;
using PraticaWFA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticaWFA
{
    public partial class ListarFuncionarios : Form
    {
        public ListarFuncionarios()
        {
            InitializeComponent();

            lv_funcionario.Columns.Insert(0, "COD", 100, HorizontalAlignment.Left);
            lv_funcionario.Columns.Insert(1, "NOME", 250, HorizontalAlignment.Left);
            lv_funcionario.Columns.Insert(2, "CPF", 250, HorizontalAlignment.Center);
            lv_funcionario.Columns.Insert(3, "EMAIL", 250, HorizontalAlignment.Left);
            ListarFuncionario();
        }
        public void ListarFuncionario()
        {
            try
            {
                Conexao conexao = new Conexao();
                MySqlCommand cmd = new MySqlCommand("SELECT id_pessoa, nome, cpf_cnpj, email FROM Pessoa WHERE flg_pessoa_juridica = 0;");

                cmd.Connection = conexao.openConnection();

                MySqlDataReader reader = cmd.ExecuteReader();



                /// if (lv_usuario.Columns.Count != 0)


                while (reader.Read())
                {

                    string id_pessoa = reader["id_pessoa"].ToString();
                    string nome = (reader["nome"].ToString());
                    string cpf = (reader["cpf_cnpj"].ToString());
                    string email = (reader["email"].ToString());

                    ListViewItem item = new ListViewItem(new[] { id_pessoa, nome, cpf, email });
                    lv_funcionario.Items.Add(item);

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro detectado " + erro);
            }
        }

        public string id;
        public string nome;

        private void lv_funcionario_Click(object sender, EventArgs e)
        {
            if (lv_funcionario.SelectedItems.Count != 0)
            {

                if (lv_funcionario.SelectedItems[0].Selected)
                {

                    id = lv_funcionario.FocusedItem.SubItems[0].Text;
                    nome = lv_funcionario.FocusedItem.SubItems[1].Text;

                }


            }



        }
        

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja continuar?", "Você editará o cadastro do usuário " + nome, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditarFuncionario editarFuncionario = new EditarFuncionario(id, nome);
                editarFuncionario.Show();
                this.Hide();

            }
        }
    }
}
