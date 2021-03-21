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
    public partial class CadastrarFuncionario : Form
    {
        public int id;
        public int id_controle;
         
        List<string> listaDeControles = new List<string>();

        public CadastrarFuncionario()
        {
            InitializeComponent();

           Controles();

        }
        public void Editar()
        {
            pnl_cad_funcionario.Enabled = true;
        }

        public List<string> Listar()
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
                listaDeControles.Add(controle);
                             
            }
            return listaDeControles;
        }
        public async void Controles()
        {
            List<string> lista = await Task.Run(() => Listar());

            foreach (string controle in lista)
            {
                checkedListBox1.Items.Add(controle);
            }
        }


        public void Cadastrar_Funcionario()
        {
            try
            {




                Criptografia criptografia = new Criptografia();
                string senhaEncriptada = criptografia.ComputeSHA1Hash(txt_Senha.Text);

                Conexao conexao = new Conexao();
                conexao.openConnection();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = conexao.openConnection();

                cmd2.CommandText = "insert into Pessoa " +
                    "(nome,data_nascimento,sexo,cpf_cnpj,email,senha,data_cadastro,flg_pessoa_juridica,flg_funcionario) " +
                    "values" +
                    " (@nome,@datanasc,@sexo,@cpf,@email,@senha,now(),0,1);";
                cmd2.Parameters.AddWithValue("@nome", txt_Nome.Text);
                cmd2.Parameters.AddWithValue("@datanasc", mskTxtNascimento.Text);
                cmd2.Parameters.AddWithValue("@sexo", cb_sexo.Text);
                cmd2.Parameters.AddWithValue("@cpf", mskTxtCpf.Text);
                cmd2.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd2.Parameters.AddWithValue("@senha", senhaEncriptada);
                cmd2.ExecuteNonQuery();

                cmd2.CommandText = "select max(id_pessoa) from Pessoa;";
                MySqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt16(reader["max(id_pessoa)"].ToString());
                }

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.openConnection();
                cmd.CommandText = "insert into Endereco (id_pessoa,endereco,bairro,numero,cidade_id,cep) " +
                    "values " +
                                  "(@idpessoa,@endereço,@bairro,@numero,1,@cep)";
                cmd.Parameters.AddWithValue("@idpessoa", id);
                cmd.Parameters.AddWithValue("@endereço", txt_endereco.Text);
                cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                cmd.Parameters.AddWithValue("@cep", mskTxtCpf.Text);
                cmd.Parameters.AddWithValue("@cidade", cbCidade.Text);
                cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text);
                cmd.ExecuteNonQuery();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro \n" + "erro: " + erro);
            }
        }
        public void ChecarBox()
        {
            try
            {
                Conexao conexao = new Conexao();
               

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1.Connection = conexao.openConnection();
                    if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                    {
                        id_controle = i + 1;
                        string controler = checkedListBox1.Items[i].ToString();

                        cmd1.CommandText = "insert into Controle_pessoa (id_pessoa,id_controle,id_pessoa_registro,data_registro)" +
                        "values " +
                                      "(@idpessoa,@idcontrole,1,now())";
                        cmd1.Parameters.AddWithValue("@idpessoa", id);
                        cmd1.Parameters.AddWithValue("@idcontrole", id_controle);

                        cmd1.ExecuteNonQuery();
                        

                    }
                    

                }
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }

        private void btn_salvar_f_Click(object sender, EventArgs e)
        {
            Cadastrar_Funcionario();
            ChecarBox();
            
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            bool e_prosseguir;
            if (btn_proximo.ButtonText == "Prosseguir")
            {
                Ani_pnl_controle.ShowSync(pnl_controles);
                pnl_controles.Visible = true;
                checkedListBox1.Visible = true;
                btn_salvar_f.Visible = true;
                pnl_cad_funcionario.Enabled = false;

                e_prosseguir = false;

                if (e_prosseguir == false)
                {
                    btn_proximo.ButtonText = "Voltar";
                }


            }
            else if (btn_proximo.ButtonText == "Voltar")
            {
                e_prosseguir = true;
                if (e_prosseguir == true)
                {
                    btn_proximo.ButtonText = "Prosseguir";
                    Ani_pnl_controle.ShowSync(pnl_controles);
                    pnl_controles.Visible = false;
                    checkedListBox1.Visible = false;
                    btn_salvar_f.Visible = false;
                    pnl_cad_funcionario.Enabled = true;
                }
            }



        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
