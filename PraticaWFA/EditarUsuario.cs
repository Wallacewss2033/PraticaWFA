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
	public partial class EditarUsuario : Form
	{
        public string id;
        public EditarUsuario(string id, string nome)
        {
            this.id = id;
            InitializeComponent();

            txt_Usuario.Text = nome;

        }

        private void btnCancelEditJ_Click(object sender, EventArgs e)
		{
			Principal principal = new Principal();
			principal.Show();

			this.Close();
		}

		private void btnCancelEdit_Click(object sender, EventArgs e)
		{
			Principal principal = new Principal();
			principal.Show();

			this.Close();
		}

		private void btnSalvarEdit_Click(object sender, EventArgs e)
		{

			try
			{



				Conexao conexao = new Conexao();
				conexao.openConnection();

				MySqlCommand cmd2 = new MySqlCommand();
				cmd2.Connection = conexao.openConnection();

				Criptografia criptografia = new Criptografia();
				string senhaEncriptada = criptografia.ComputeSHA1Hash(txt_senha_J.Text);

				cmd2.CommandText = "insert into Pessoa " +
					"(nome,nome_fantasia,data_nascimento,cpf_cnpj,email,inscricao_estadual,inscricao_municipal,senha,id_nivel_usuario,data_cadastro,flg_pessoa_juridica)" +
					" values (@nome,@nomefanta,@datanasc,@cnpj,@email,@IE,@IM,@senha,1,now(),1);";
				cmd2.Parameters.AddWithValue("@nome", txt_nome_J.Text);
				cmd2.Parameters.AddWithValue("@nomefanta", txt_nome_fantasia.Text);
				//cmd2.Parameters.AddWithValue("@datanasc", converteData(dataDeNascimento));
				//cmd2.Parameters.AddWithValue("@cnpj", cnpj);
				cmd2.Parameters.AddWithValue("@email", txt_email_J.Text);
				cmd2.Parameters.AddWithValue("@IE", txt_incri_estad.Text);
				cmd2.Parameters.AddWithValue("@IM", txt_inscri_mulni.Text);
				cmd2.Parameters.AddWithValue("@senha", senhaEncriptada);
				cmd2.ExecuteNonQuery();

				

				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = conexao.openConnection();
				cmd.CommandText = "insert into Endereco (id_pessoa,endereco,bairro,numero,cidade_id,cep) values (@idpessoa,@endereço,@bairro,@numero,@cidade,@cep)";
				//cmd.Parameters.AddWithValue("@idpessoa", id);
				cmd.Parameters.AddWithValue("@endereço", txt_endereco_J.Text);
				cmd.Parameters.AddWithValue("@numero", txtNumeroJ.Text);
				//cmd.Parameters.AddWithValue("@cep", cep);
				cmd.Parameters.AddWithValue("@cidade", txt_cidade_J.Text);
				cmd.Parameters.AddWithValue("@bairro", txt_bairro_J.Text);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Cadastro realizado com sucesso!");
			}
			catch (Exception erro)
			{
				MessageBox.Show("Não foi possivel realizar o cadastro \n" + "erro: " + erro);
			}

		}
	}
}
