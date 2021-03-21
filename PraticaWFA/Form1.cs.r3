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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			textUsuario.TabIndex = 0;
			textSenha.TabIndex = 1;
		
		}


		private void enter_clicado()
		{
			try
			{
				Criptografia criptografia = new Criptografia();
				string senhaSHA1 = criptografia.ComputeSHA1Hash(textSenha.Text);

				Conexao conexao = new Conexao();
				conexao.openConnection();

				MySqlCommand cmd = new MySqlCommand("SELECT nome,senha FROM Pessoa where nome=@nome and senha=@senha;");
				Task.Run(() =>
				{
					cmd.Connection = conexao.openConnection();
				});
				while (cmd.Connection == null)
				{
					//int i = 0;
					//timer1.Start();
					//progresso_Inicial.Value = i;
					//timer1.Stop();
					//i++;
				}


				cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = textUsuario.Text;
				cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaSHA1;

				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{

					Form2 form2 = new Form2();
					form2.Show();

					this.Hide();
				}
				else
				{
					MessageBox.Show("Usuario ou senha incorreta!");
				}
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro + " ");
			}
		}

		private void btn_entrar_Click(object sender, EventArgs e)
		{
			enter_clicado();
		}



		private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{

				enter_clicado();
			}

			if (e.KeyChar == Convert.ToChar(Keys.Tab))
			{

				textUsuario.TabIndex = 3;
			}

		}

	}
}

