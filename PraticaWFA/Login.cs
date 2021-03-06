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
    public partial class Login : Form
    {
        Conexao conexao = new Conexao();


        public Login()
        {
            InitializeComponent();
        }


        private Usuario Enter_clicado()
        {

            try
            {

                Criptografia criptografia = new Criptografia();
                string senhaSHA1 = criptografia.ComputeSHA1Hash(txtSenha.Text);

                conexao.openConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT p.id_pessoa,senha,nome,descricao_controle FROM Pessoa p" +
                    " INNER join Controle_pessoa c on (p.id_pessoa=c.id_pessoa)" +
                    "inner join Controle co on(c.id_controle = co.id_controle)" +
                    " where nome = @email and senha = @senha and flg_funcionario;");
                cmd.Connection = conexao.openConnection();


                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaSHA1;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.erroLogin = "login_erro";


                    return usuario;
                }
                else
                {

                    string id_pessoa = reader["id_pessoa"].ToString();
                    string nome = (reader["nome"].ToString());
                    List<string> listaDeDescricoes = new List<string>();

                    while (reader.Read())
                    {

                        string descricao_controle = (reader["descricao_controle"].ToString());

                        listaDeDescricoes.Add(descricao_controle);


                    }

                    Usuario usuario = new Usuario(Convert.ToInt16(id_pessoa), nome, listaDeDescricoes, null);

                    return usuario;
                }


            }
            catch (Exception erro)

            {
                Usuario usuario = new Usuario();

                usuario.erroLogin = erro.Message;
                return usuario;

            }
            finally
            {
                conexao.closeConnection();
            }
        }
        public bool VerificarCampo(TextBox textBox)
        {
            bool CampoVazio = false;
            errorProvider_login.Clear();

            if (textBox.Text == string.Empty)
            {
                errorProvider_login.SetError(textBox, "Campo Obrigatório");
                textBox.Focus();
                CampoVazio = true;

                return CampoVazio;
            }


            return CampoVazio;
        }


        public async void Logar()
        {
            bool CampoVazio;

            CampoVazio = VerificarCampo(txtUsuario);
            if (!CampoVazio)
            {
                CampoVazio = VerificarCampo(txtSenha);
            }
            if (!CampoVazio)
            {

                pnl_login.Visible = false;
                pbCarregar_login.Visible = true;


                var task = await Task.Run(() => Enter_clicado());


                Usuario usuario = task;

                if (usuario.erroLogin == null)
                {
                    Principal principal = new Principal(usuario);
                    principal.Show();

                    this.Hide();
                }
                else if (usuario.erroLogin.Equals("login_erro"))
                {

                    pnl_login.Visible = true;
                    pbCarregar_login.Visible = false;
                    MessageBox.Show("Usuario ou senha incorreta!");

                }
                else if(!usuario.Equals("login_erro"))
                {

                    pnl_login.Visible = true;
                    pbCarregar_login.Visible = false;
                    MessageBox.Show("Não foi possível acessar o banco de dados!");

                }



            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Logar();
            }

        }
        private void btn_entrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Logar();
            }
        }

        private void swLembrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


            }
        }
    }
}

