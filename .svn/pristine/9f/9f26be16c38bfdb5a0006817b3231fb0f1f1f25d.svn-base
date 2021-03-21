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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (pnl_cad_fisico.Visible == true)
            {
                btn_fisica.Normalcolor = Color.FromArgb(36, 36, 36);
                btn_juridica.Normalcolor = Color.FromArgb(28,28,28);
            }
            if (pnl_cad_juridica.Visible == true)
            {
                btn_juridica.BackColor = Color.FromArgb(36, 36, 36);
                btn_fisica.Normalcolor = Color.FromArgb(28, 28, 28);
            }
        }
        public void Campo_Obrigatorio()
        {
            errorProvider1.Clear();
            if (txt_Nome.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Nome, "Campo Obrigatório");
                txt_Nome.Focus();
            }
            if (txt_Email.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Email, "Campo Obrigatório");
                txt_Email.Focus();
            }
            if (txt_Nascimento.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Nascimento, "Campo Obrigatório");
                txt_Nascimento.Focus();
            }
            if (Txt_Cpf.Text == string.Empty)
            {
                errorProvider1.SetError(Txt_Cpf, "Campo Obrigatório");
                Txt_Cpf.Focus();
            }
            if (txt_Usuario.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Usuario, "Campo Obrigatório");
                txt_Usuario.Focus();
            }
            if (txt_Senha.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Senha, "Campo Obrigatório");
                txt_Senha.Focus();
            }


        }

        private void btn_SalvaCad_Click(object sender, EventArgs e)
        {
            Campo_Obrigatorio();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

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
    }
}
