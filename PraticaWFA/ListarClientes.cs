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
    public partial class ListarClientes : Form
    {

        Conexao conexao = new Conexao();
        List<Cliente> listaDeFisicos = new List<Cliente>();
        List<Cliente> listaDeJuridicos = new List<Cliente>();

        public ListarClientes()
        {
            InitializeComponent();


            ListarPessoaFisica();

            btn_fisica.Normalcolor = Color.FromArgb(36, 36, 36);
            btn_empresa.Normalcolor = Color.FromArgb(28, 28, 28);


            lv_usuario.Columns.Insert(0, "COD", 100, HorizontalAlignment.Left);
            lv_usuario.Columns.Insert(1, "NOME", 250, HorizontalAlignment.Left);
            lv_usuario.Columns.Insert(2, "CPF", 250, HorizontalAlignment.Center);
            lv_usuario.Columns.Insert(3, "EMAIL", 250, HorizontalAlignment.Left);


        }

        public void ListarPessoaJuridica()
        {
            if (listaDeJuridicos.Count() == 0)
            {
                lv_usuario.Columns.RemoveAt(2);

                lv_usuario.Columns.Insert(2, "CNPJ", 250, HorizontalAlignment.Center);

                Conexao conexao = new Conexao();
                MySqlCommand cmd = new MySqlCommand("SELECT id_pessoa, nome, cpf_cnpj, email FROM Pessoa WHERE flg_pessoa_juridica = 1;");

                cmd.Connection = conexao.openConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                lv_usuario.Items.Clear();

                while (reader.Read())
                {
                   
                   string id_pessoa = reader["id_pessoa"].ToString();
                    string nome = (reader["nome"].ToString());
                    string cnpj = (reader["cpf_cnpj"].ToString());
                    string email = (reader["email"].ToString());

                    ListViewItem item = new ListViewItem(new[] { id_pessoa, nome, cnpj, email });
                    lv_usuario.Items.Add(item);

                    Cliente cliente = new Cliente(Convert.ToInt16(id_pessoa), nome, cnpj, email);

                    listaDeJuridicos.Add(cliente);
                }
            }
            else {

                lv_usuario.Items.Clear();

                lv_usuario.Columns.RemoveAt(2);

                lv_usuario.Columns.Insert(2, "CNPJ", 250, HorizontalAlignment.Center);


                foreach (Cliente cliente in listaDeJuridicos)
                {
                    ListViewItem item = new ListViewItem(new[] { cliente.id_cliente.ToString(), cliente.nome, cliente.cpf_cnpj.ToString(), cliente.email });
                    lv_usuario.Items.Add(item);
                }
            }


        }
        public void ListarPessoaFisica()
        {

            try
            {

                if (listaDeFisicos.Count == 0)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id_pessoa, nome, cpf_cnpj, email FROM Pessoa WHERE flg_pessoa_juridica = 0;");

                    cmd.Connection = conexao.openConnection();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        string id_pessoa = reader["id_pessoa"].ToString();
                        string nome = (reader["nome"].ToString());
                        string cpf = (reader["cpf_cnpj"].ToString());
                        string email = (reader["email"].ToString());

                        ListViewItem item = new ListViewItem(new[] { id_pessoa, nome, cpf, email });
                        lv_usuario.Items.Add(item);

                        Cliente cliente = new Cliente(Convert.ToInt16(id_pessoa), nome, cpf, email);

                        listaDeFisicos.Add(cliente);

                    }

                }
                else {

                    lv_usuario.Items.Clear();

                    lv_usuario.Columns.RemoveAt(2);

                    lv_usuario.Columns.Insert(2, "CPF", 250, HorizontalAlignment.Center);


                    foreach (Cliente cliente in listaDeFisicos)
                    {
                        ListViewItem item = new ListViewItem(new[] { cliente.id_cliente.ToString(), cliente.nome, cliente.cpf_cnpj.ToString(), cliente.email });
                        lv_usuario.Items.Add(item);
                    }

                }

                /// if (lv_usuario.Columns.Count != 0)
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro detectado " + erro);
            }
            finally
            {

                //conexao.closeConnection();
            }
        }

        public string id;
        public string nome;

        private void lv_usuario_Click(object sender, EventArgs e)
        {
            if (lv_usuario.SelectedItems.Count != 0)
            {

                if (lv_usuario.SelectedItems[0].Selected)
                {

                    id = lv_usuario.FocusedItem.SubItems[0].Text;
                    nome = lv_usuario.FocusedItem.SubItems[1].Text;

                }


            }



        }

        private void btn_fisica_Click(object sender, EventArgs e)
        {

            btn_fisica.Normalcolor = Color.FromArgb(36, 36, 36);
            btn_empresa.Normalcolor = Color.FromArgb(28, 28, 28);

              ListarPessoaFisica();

         
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            btn_empresa.Normalcolor = Color.FromArgb(36, 36, 36);
            btn_fisica.Normalcolor = Color.FromArgb(28, 28, 28);

            ListarPessoaJuridica();
        }

      
        private void btn_editarUsu_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja continuar?", "Você editará o cadastro do usuário " + nome, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditarUsuario editar = new EditarUsuario(id, nome);
                this.Close();
                editar.Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.Show();
        }
    }
}


