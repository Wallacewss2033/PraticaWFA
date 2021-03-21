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
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();

            pnl_cad_fisico.Visible = true;
            pnl_cad_juridica.Visible = false;

            if (pnl_cad_fisico.Visible == true)
            {
                btn_fisica.Normalcolor = Color.FromArgb(28, 28, 28);
                btn_juridica.Normalcolor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                btn_juridica.Normalcolor = Color.FromArgb(28, 28, 28);
                btn_fisica.Normalcolor = Color.FromArgb(36, 36, 36);
            }
            mskTxtNascimento.Mask = "00/00/0000";
            mskTxtCpf.Mask = "000,000,000-00";
            mskTxtCep.Mask = "00000-000";

            mskTxtNascimentoJ.Mask = "00/00/0000";
            mskTxtCnpj.Mask = "00,000,000/0000-00";
            mskTxtCepJ.Mask = "00000-000";

            mskTxtInscriEstad.Mask = "000,000,00-0";
            mskTxtInscriMuni.Mask = "000,000,00-0";



            Atribui();
            //	txt_cidade_J.AutoCompleteCustomSource = cidades;

        }


        private async void Atribui()
        {
            var task = await Task.Run(() => BuscaListaDeCidades());

           // List<Cidade> cidades = task;
          
            cbCidade.DataSource = task;
            cbCidade.DisplayMember = "nome_cidade";
            cbCidade.ValueMember = "id_cidade";



            cbCidade_J.DisplayMember = "nome_cidade";
            cbCidade_J.ValueMember = "id_cidade";
			cbCidade_J.DataSource = task;

			cbCidade.Enabled = true;
            cbCidade_J.Enabled = true;
            pb_carregar.Visible = false;
            pb_carregar.Enabled = false;

            pb_carregar1.Visible = false;
            pb_carregar1.Enabled = false;
        }


        public static List<Cidade> BuscaListaDeCidades()
        {

            try
            {
                Conexao conexao = new Conexao();

                MySqlCommand cmd2 = new MySqlCommand();

                cmd2.Connection = conexao.openConnection();

                cmd2.CommandText = "SELECT nome,id_cidade FROM Cidade ORDER BY nome asc;";

                MySqlDataReader reader = cmd2.ExecuteReader();

                var lista = new List<Cidade>();

                while (reader.Read())
                {

                    Cidade cidade = new Cidade();

                    if (lista.Count() == 0)
                    {
                        cidade.nome_cidade = null;
                        cidade.id_cidade = 0;
                    }
                    else
                    {
                        cidade.nome_cidade = reader["nome"].ToString();
                        cidade.id_cidade = Convert.ToInt16(reader["id_cidade"].ToString());
                    }

                    lista.Add(cidade);
                }




                return lista;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro \n" + "erro: " + erro);
                return null;
            }


        }

        public static int id = 0;

        public void Verificar_Campo_fisica()
        {
            bool Campo_vazio = false;
            errorProvider1.Clear();
            if (txt_bairro.Text == string.Empty)
            {
                errorProvider1.SetError(txt_bairro, "Campo Obrigatório");
                txt_bairro.Focus();
                Campo_vazio = true;
            }
            if (cbCidade.Text == string.Empty)
            {
                errorProvider1.SetError(cbCidade, "Campo Obrigatório");
                cbCidade.Focus();
                Campo_vazio = true;
            }
            if (mskFormato(mskTxtCep) == string.Empty)
            {
                errorProvider1.SetError(mskTxtCep, "Campo Obrigatório");
                mskTxtCep.Focus();
                Campo_vazio = true;
            }
            if (txt_numero.Text == string.Empty)
            {
                errorProvider1.SetError(txt_numero, "Campo Obrigatório");
                txt_numero.Focus();
                Campo_vazio = true;
            }
            if (txt_endereco.Text == string.Empty)
            {
                errorProvider1.SetError(txt_endereco, "Campo Obrigatório");
                txt_endereco.Focus();
                Campo_vazio = true;
            }
            if (txt_Senha.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Senha, "Campo Obrigatório");
                txt_Senha.Focus();
                Campo_vazio = true;
            }
            if (txt_Usuario.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Usuario, "Campo Obrigatório");
                txt_Usuario.Focus();
                Campo_vazio = true;
            }
            if (mskFormato(mskTxtNascimento) == string.Empty)
            {
                errorProvider1.SetError(mskTxtNascimento, "Campo Obrigatório");
                mskTxtNascimento.Focus();
                Campo_vazio = true;
            }
            if (cb_sexo.Text == string.Empty)
            {
                errorProvider1.SetError(cb_sexo, "Campo Obrigatório");
                cb_sexo.Focus();
                Campo_vazio = true;
            }
            if (mskFormato(mskTxtCpf) == string.Empty)
            {
                errorProvider1.SetError(mskTxtCpf, "Campo Obrigatório");
                mskTxtCpf.Focus();
                Campo_vazio = true;
            }
            if (txt_Email.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Email, "Campo Obrigatório");
                txt_Email.Focus();
                Campo_vazio = true;
            }
            if (txt_Nome.Text == string.Empty)
            {

                errorProvider1.SetError(txt_Nome, "Campo Obrigatório");
                txt_Nome.Focus();
                Campo_vazio = true;
            }
            if (Campo_vazio == false)
            {
                cadastrar_fisica();
            }
        }
        public void Verificar_Campo_juridica()
        {
            cadastrar_juridica();
        }

        public void cadastrar_fisica()
        {
            try
            {


                string dataDeNascimento = mskFormato(mskTxtNascimento);
                string cpf = mskFormato(mskTxtCpf);
                string cep = mskFormato(mskTxtCep);

                Criptografia criptografia = new Criptografia();
                string senhaEncriptada = criptografia.ComputeSHA1Hash(txt_Senha.Text);

                Conexao conexao = new Conexao();
                conexao.openConnection();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = conexao.openConnection();

                cmd2.CommandText = "insert into Pessoa " +
                    "(nome,data_nascimento,sexo,cpf_cnpj,email,senha,data_cadastro,flg_pessoa_juridica) " +
                    "values" +
                    " (@nome,@datanasc,@sexo,@cpf,@email,@senha,now(),0);";
                cmd2.Parameters.AddWithValue("@nome", txt_Nome.Text);
                cmd2.Parameters.AddWithValue("@datanasc", converteData(dataDeNascimento));
                cmd2.Parameters.AddWithValue("@sexo", cb_sexo.Text);
                cmd2.Parameters.AddWithValue("@cpf", cpf);
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
                cmd.CommandText = "insert into Endereco (id_pessoa,endereco,bairro,numero,cidade_id,cep) values (@idpessoa,@endereço,@bairro,@numero,@cidade,@cep)";
                cmd.Parameters.AddWithValue("@idpessoa", id);
                cmd.Parameters.AddWithValue("@endereço", txt_endereco.Text);
                cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cbCidade.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro \n" + "erro: " + erro);
            }
        }
        public void cadastrar_juridica()
        {
            try
            {

                string dataDeNascimento = mskFormato(mskTxtNascimentoJ);
                string cnpj = mskFormato(mskTxtCnpj);
                string cep = mskFormato(mskTxtCepJ);
                string inscricaoEstadual = mskFormato(mskTxtInscriEstad);
                string inscricaoMunicipal = mskFormato(mskTxtInscriMuni);

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
                cmd2.Parameters.AddWithValue("@datanasc", converteData(dataDeNascimento));
                cmd2.Parameters.AddWithValue("@cnpj", cnpj);
                cmd2.Parameters.AddWithValue("@email", txt_email_J.Text);
                cmd2.Parameters.AddWithValue("@IE", inscricaoEstadual);
                cmd2.Parameters.AddWithValue("@IM", inscricaoMunicipal);
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
                cmd.CommandText = "insert into Endereco (id_pessoa,endereco,bairro,numero,cidade_id,cep) values (@idpessoa,@endereço,@bairro,@numero,@cidade,@cep)";
                cmd.Parameters.AddWithValue("@idpessoa", id);
                cmd.Parameters.AddWithValue("@endereço", txt_endereco_J.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumeroJ.Text);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cbCidade_J.Text);
                cmd.Parameters.AddWithValue("@bairro", txt_bairro_J.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro \n" + "erro: " + erro);
            }
        }


        public static string mskFormato(MaskedTextBox _mask)
        {
            string result = null;

            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            result = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (result != string.Empty && _mask.Text.Contains("/"))
            {
                return _mask.Text;
            }
            else
            {
                return result;
            }
        }
        public string converteData(string dataNascimento)
        {
            DateTime dateTime = Convert.ToDateTime(dataNascimento);
            string dataAlterada = dateTime.ToString("yyyyMMdd");

            return dataAlterada;
        }


        private void btn_SalvaCad_Click(object sender, EventArgs e)
        {
            Verificar_Campo_fisica();
        }
        private void btn_salvarCad_J_Click(object sender, EventArgs e)
        {
            Verificar_Campo_juridica();
        }

        private void btn_juridica_Click(object sender, EventArgs e)
        {
            pnl_cad_juridica.Visible = true;
            pnl_cad_fisico.Visible = false;

            btn_juridica.Normalcolor = Color.FromArgb(36, 36, 36);
            btn_fisica.Normalcolor = Color.FromArgb(28, 28, 28);
        }
        private void btn_fisica_Click(object sender, EventArgs e)
        {
            pnl_cad_juridica.Visible = false;
            pnl_cad_fisico.Visible = true;

            btn_fisica.Normalcolor = Color.FromArgb(36, 36, 36);
            btn_juridica.Normalcolor = Color.FromArgb(28, 28, 28);
        }

        private void mskTxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtCpf) == string.Empty)
            {
                mskTxtCpf.Clear();

            }
        }
        private void mskTxtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtNascimento) == string.Empty)
            {
                mskTxtNascimento.Clear();

            }

        }
        private void mskTxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtCep) == string.Empty)
            {
                mskTxtCep.Clear();

            }
        }
        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
        private void txtNumeroJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
        private void mskTxtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtCnpj) == string.Empty)
            {
                mskTxtCnpj.Clear();

            }
        }
        private void mskTxtNascimentoJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtNascimentoJ) == string.Empty)
            {
                mskTxtNascimentoJ.Clear();

            }
        }
        private void mskTxtCepJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtCepJ) == string.Empty)
            {
                mskTxtCepJ.Clear();

            }
        }
        private void mskTxtInscriMuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtInscriMuni) == string.Empty)
            {
                mskTxtInscriMuni.Clear();

            }

        }

        private void mskTxtInscriEstad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskFormato(mskTxtInscriEstad) == string.Empty)
            {
                mskTxtInscriEstad.Clear();

            }
        }

        private void btnCancelCadJ_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Close();
        }
        private void btnCancelCad_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Close();
        }

        private void mskTxtCep_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtCep).Length < 8 || mskTxtCep.Text.Contains("_"))
            {
                mskTxtCep.Clear();

            }
        }
        private void mskTxtCpf_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtCpf).Length < 11 || mskTxtCpf.Text.Contains("_"))
            {
                mskTxtCpf.Clear();

            }
        }
        private void mskTxtNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtNascimento).Length < 8 || mskTxtNascimento.Text.Contains("_"))
            {
                mskTxtNascimento.Clear();

            }
        }



        private void mskTxtCnpj_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtCnpj).Length < 14 || mskTxtCnpj.Text.Contains("_"))
            {
                mskTxtCnpj.Clear();

            }
        }

        private void mskTxtNascimentoJ_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtNascimentoJ).Length < 8 || mskTxtNascimentoJ.Text.Contains("_"))
            {
                mskTxtNascimentoJ.Clear();

            }
        }

        private void mskTxtCepJ_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtCepJ).Length < 8 || mskTxtCepJ.Text.Contains("_"))
            {
                mskTxtCepJ.Clear();

            }
        }

        private void mskTxtInscriMuni_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtInscriMuni).Length < 9 || mskTxtInscriMuni.Text.Contains("_"))
            {
                mskTxtInscriMuni.Clear();

            }
        }

        private void mskTxtInscriEstad_Validating(object sender, CancelEventArgs e)
        {
            if (mskFormato(mskTxtInscriEstad).Length < 9 || mskTxtInscriEstad.Text.Contains("_"))
            {
                mskTxtInscriEstad.Clear();

            }
        }

        private void bunifuCustomLabel2_MouseHover(object sender, EventArgs e)
        {
            lbl_MB3.ForeColor = Color.FromArgb(0, 192, 192);
            lbl_MB_P.Text = lbl_MB3.Text;
            timer1.Interval = 30;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbl_MB_P.Text == "3 MB" && CircleProgressbar1.Value < 30)
            {
                CircleProgressbar1.Value = CircleProgressbar1.Value + 1;
            }
            else if (lbl_MB_P.Text == "5 MB" && CircleProgressbar1.Value < 50)
            {
                CircleProgressbar1.Value = CircleProgressbar1.Value + 1;
            }
            else if (lbl_MB_P.Text == "10 MB" && CircleProgressbar1.Value < 100)
            {
                CircleProgressbar1.Value = CircleProgressbar1.Value + 4;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void lbl_MB3_MouseLeave(object sender, EventArgs e)
        {
            CircleProgressbar1.Value = 0;
            lbl_MB_P.Text = "";
            lbl_MB3.ForeColor = Color.FromArgb(28,28,28);
        }

        private void lbl_MB5_MouseHover(object sender, EventArgs e)
        {
            lbl_MB5.ForeColor = Color.FromArgb(0, 192, 192);
            lbl_MB_P.Text = lbl_MB5.Text;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void lbl_MB10_MouseHover(object sender, EventArgs e)
        {
            lbl_MB10.ForeColor = Color.FromArgb(0, 192, 192);
            lbl_MB_P.Text = lbl_MB10.Text;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void lbl_MB5_MouseLeave(object sender, EventArgs e)
        {
            CircleProgressbar1.Value = 0;
            lbl_MB_P.Text = "";
            lbl_MB5.ForeColor = Color.FromArgb(28, 28, 28);
        }

        private void lbl_MB10_MouseLeave(object sender, EventArgs e)
        {
            CircleProgressbar1.Value = 0;
            lbl_MB_P.Text = "";
            lbl_MB10.ForeColor = Color.FromArgb(28, 28, 28);
        }
    }
}