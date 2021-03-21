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
    public partial class EditarFuncionario : Form
    {
        public int id_f;
        public EditarFuncionario(string id_f, string nome)
        {
           
            InitializeComponent();
            mskTxtNascimento.Mask = "00/00/0000";
            mskTxtCpf.Mask = "000,000,000-00";
            mskTxtCep.Mask = "00000-000";
            
            
            cbCidade.ValueMember = "id_cidade";
            cbCidade.DisplayMember = "nome_cidade";
            
            this.id_f = Convert.ToInt16(id_f);
            this.txt_Nome.Text = nome;
            ListaDeControle();
            Verificarcontroles();
            DadosEdicao();

        }
        public void Verificarcontroles()
        {
            Conexao conexao = new Conexao();
            conexao.openConnection();


            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = conexao.openConnection();

            cmd2.CommandText = "SELECT * FROM magiclink.Controle_pessoa where id_pessoa = " + id_f + ";";

            MySqlDataReader reader = cmd2.ExecuteReader();



            while (reader.Read())
            {
                int id_controle = Convert.ToInt16(reader["id_controle"].ToString());

                checkedListBox1.SetItemCheckState(id_controle - 1, CheckState.Checked);

            }


        }

        public void ListaDeControle()
        {
            Conexao conexao = new Conexao();
            conexao.openConnection();

            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = conexao.openConnection();

            cmd2.CommandText = "SELECT * FROM Controle;";

            MySqlDataReader reader = cmd2.ExecuteReader();



            while (reader.Read())
            {
                string controle = reader["descricao_controle"].ToString();
                checkedListBox1.Items.Add(controle);

            }
        }
        public void DadosEdicao()
        {
            Conexao conexao = new Conexao();
            conexao.openConnection();


            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexao.openConnection();

            cmd.CommandText = "select * from  Pessoa p inner join Endereco e on(p.id_pessoa = e.id_pessoa) where e.id_pessoa =  " + id_f;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              
                mskTxtNascimento.Text = reader["data_nascimento"].ToString();
                cb_sexo.Text = reader["sexo"].ToString();
                mskTxtCpf.Text = reader["cpf_cnpj"].ToString();
                txt_Email.Text = reader["email"].ToString();
                txt_endereco.Text = reader["endereco"].ToString();
                txt_numero.Text = reader["numero"].ToString();
                txt_bairro.Text = reader["bairro"].ToString();
                mskTxtCep.Text = reader["cep"].ToString();
            }

        }
        private void btn_atualizar_f_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.openConnection();

            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = conexao.openConnection();

            cmd2.CommandText = "UPDATE Pessoa SET nome = @nome ,data_nascimento = @datanasc, sexo = @sexo, cpf_cnpj = @cpf, email = @email WHERE id_pessoa = '02';";
            cmd2.Parameters.AddWithValue("@nome", txt_Nome.Text);
            cmd2.Parameters.AddWithValue("@datanasc", mskTxtNascimento.Text);
            cmd2.Parameters.AddWithValue("@sexo", cb_sexo.Text);
            cmd2.Parameters.AddWithValue("@cpf", mskTxtCpf.Text);
            cmd2.Parameters.AddWithValue("@email", txt_Email.Text);
            cmd2.ExecuteNonQuery();

            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.Connection = conexao.openConnection();

            cmd1.CommandText = "update Endereco set endereco = @endereco, numero = '000', bairro = 'monte', cep = '0000' WHERE id_pessoa = '02'";
            cmd1.Parameters.AddWithValue("@endereco", txt_endereco.Text);
            cmd1.Parameters.AddWithValue("@numero", txt_numero.Text);
            cmd1.Parameters.AddWithValue("@cep", mskTxtCep.Text);
          //  cmd1.Parameters.AddWithValue("@cidade", cbCidade.ValueMember);



        }
    }
}
