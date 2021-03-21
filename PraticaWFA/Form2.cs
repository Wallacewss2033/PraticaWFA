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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                int a = 0;
                button.Text = "Wallace " + i;
                button.Size = new Size(386, 52);
                button.Location = new Point(374, 0 + a);
                button.Visible = true;
                button.BackColor = Color.Green;
                a = 3;

            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 47)
            {
                btn_Menu.Location = new Point(276, 584);
                panel3.Visible = false;
                panel3.Width = 318;
                MenuNAV.ShowSync(panel3);

                


            }
            else
            {




                btn_Menu.Location = new Point(3, 584);
                panel3.Visible = false;
                panel3.Width = 47;
                MenuNAV.ShowSync(panel3);
                

            }
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
