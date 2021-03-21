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
    public partial class GerarRelatorio : Form
    {
        public GerarRelatorio()
        {
            InitializeComponent();
        }

       

        private void Relatorio_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'magiclinkDataSet_p_fisica.p_fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.p_fisicaTableAdapter.Fill(this.magiclinkDataSet_p_fisica.p_fisica);
            // TODO: esta linha de código carrega dados na tabela 'magiclinkDataSet_p_juridica.p_juridica'. Você pode movê-la ou removê-la conforme necessário.
            this.p_juridicaTableAdapter.Fill(this.magiclinkDataSet_p_juridica.p_juridica);

            this.reportViewer2.RefreshReport();
        }
    }
}
