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
    public partial class Principal : Form
    {
        Usuario usuario;
 

        public Principal()
        {
            InitializeComponent();

        }

        public Principal(Usuario usuario)
        {
            
            InitializeComponent();

            this.usuario = usuario;

            lblNome.Text = usuario.nome;

        }

        //private void bunifuImageButton1_Click(object sender, EventArgs e)
        //{
        //    if (panel3.Width == 47)
        //    {
        //        btn_Menu.Location = new Point(276, 584);
        //        panel3.Visible = false;
        //        panel3.Width = 318;
        //        MenuNAV.ShowSync(panel3);




        //    }
        //    else
        //    {




        //        btn_Menu.Location = new Point(3, 584);
        //        panel3.Visible = false;
        //        panel3.Width = 47;
        //        MenuNAV.ShowSync(panel3);


        //    }
        //}



        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastro = new CadastrarUsuario();
            cadastro.Show();
            this.Close();

        }


        private void btn_ListaUsuario_Click(object sender, EventArgs e)
        {
            ListarClientes listaUsuario = new ListarClientes();
            listaUsuario.Show();
            this.Close();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio relatorio = new GerarRelatorio();
            relatorio.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

            // Application.Exit();
        }

        private void btn_relatorio_MouseHover(object sender, EventArgs e)
        {
            animator1.ShowSync(btn_relatorio);
            btn_relatorio.Visible = false;
        }

        private void btn_relatorio_MouseLeave(object sender, EventArgs e)
        {

            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            animator1.ShowSync(btn_relatorio);
            btn_relatorio.Visible = true;
        }

        private void btn_relatorio_Click_1(object sender, EventArgs e)
        {
            animator1.ShowSync(btn_relatorio);
            btn_relatorio.Visible = false;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario cadastrarFuncionario = new CadastrarFuncionario();
            cadastrarFuncionario.Show();
            this.Close();

        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            ListarFuncionarios listarFuncionarios = new ListarFuncionarios();
            listarFuncionarios.Show();

        }
    }
}
