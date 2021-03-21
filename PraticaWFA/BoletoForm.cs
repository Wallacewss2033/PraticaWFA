using Impactro.Cobranca;
using MySql.Data.MySqlClient;
using PraticaWFA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticaWFA
{
    public partial class BoletoForm : Form
    {
        public BoletoForm()
        {
            InitializeComponent();
            Sacado();
        }

        public void Sacado()
        {
            Conexao conexao = new Conexao();
            conexao.closeConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM magiclink.InfoBoleto where id_pessoa = 83");

            cmd.Connection = conexao.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            SacadoInfo sacado = new SacadoInfo();
            while (reader.Read())
            {

                string id_pessoa = reader["id_pessoa"].ToString();
               
              //  SacadoInfo sacado = new SacadoInfo();
                sacado.Sacado = reader["nome"].ToString(); 
                sacado.Documento = reader["cpf_cnpj"].ToString(); 
                sacado.Endereco =  reader["endereco"].ToString() +", "+ reader["numero"].ToString();
                sacado.Cidade = reader["nome_cidade"].ToString();
                sacado.Bairro = reader["bairro"].ToString();
                sacado.Cep = reader["cep"].ToString();
                sacado.UF = "BA";
                sacado.Avalista = " Magic Link / NF 1 1/1";


            }

            CedenteInfo cedente = new CedenteInfo();
            cedente.Cedente = "Magic Link";
            cedente.Banco = "237";
            cedente.Agencia = "9999-7";
            cedente.Conta = "999999-7";
            cedente.Carteira = "18";
            cedente.Modalidade = "19";
            cedente.Convenio = "123456";
            cedente.CodCedente = "123456";
            cedente.CNPJ = "00.456.789/0001-99";

            

            // Definição das Variáveis do boleto
            BoletoInfo boleto = new BoletoInfo();
            boleto.NossoNumero = "12345";
            boleto.NumeroDocumento = "12345";
            boleto.ValorDocumento = 160.0;
            boleto.DataDocumento = DateTime.Now;
            boleto.DataVencimento = DateTime.Now;
            lblVencimento.Text = boleto.DataVencimento.ToShortDateString();
            boleto.Instrucoes = "Após o vencimento, pagar apenas na empresa. juros de 1% / dia";

            Boleto blt = new Boleto();
            blt.MakeBoleto(cedente, sacado, boleto);
            blt.CalculaBoleto();

            lbl_cpfSecador.Text = "CPF: "+ sacado.Documento;
            lblSecador.Text = "Sacador: " + sacado.Sacado;
            lblEndereco.Text = "Endereço: " + sacado.Endereco;
            lblBairroSacador.Text = "Bairro: " + sacado.Bairro;
            lblCidadeSecador.Text = "Cidade: " + sacado.Cidade;
            lblCepSacador.Text = "CEP: " + sacado.Cep;
            lblEstadoSacador.Text = "UF: " + sacado.UF;
            

            lbl_IPTE.Text = blt.LinhaDigitavel;
            lblNossoNumero.Text = blt.NossoNumeroExibicao;
            lblValor.Text = string.Format("{0:#,###,##0.00}", blt.ValorDocumento);
            lblAvalista.Text = "Avalista: " + sacado.Avalista;
            lblCedente.Text = cedente.Cedente;
            picBarra.Image = CobUtil.BarCodeImage(blt.CodigoBarras);
            //lblNossoNumero.Text = boleto.DataVencimento.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // criando um documento de impressão
            // para que eu mande os objeto serem renderizados neste.
            PrintDocument pDoc = new PrintDocument();
            PrintPreviewDialog ppw = new PrintPreviewDialog();
            
            pDoc.PrintPage += new PrintPageEventHandler(pDoc_PrintPage);
            ppw.Document = pDoc;
            ppw.MdiParent = this.MdiParent;
            ppw.WindowState = FormWindowState.Maximized;
            ppw.Show();
        }
        void pDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Define o ponto (0,0) para centralizar o boleto na página
                e.Graphics.TranslateTransform(50, 50);

                // Desenha o fundo
                e.Graphics.DrawImage(picFundo.Image, Fat(1), Fat(1));

                //Define a região de impressão dos textos, sempre alinhando para a direita (a região do ipte é maior)
                StringFormat StringRight = new StringFormat();
                StringRight.Alignment = StringAlignment.Far;


                //Imprime os textos, nas mesmas posições 

                // uma pequena margem de correção de posicionamento
                int nMargemX = 30;
                int nMargemY = 5;

                // Define a fonte para o IPTE (linha digitável)
                Font fnt = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString(lbl_IPTE.Text, fnt, Brushes.Black, Fat(nMargemX + lbl_IPTE.Left + lbl_IPTE.Width), Fat(nMargemY + lbl_IPTE.Top), StringRight);

                // Define a fonte para textos comuns
                fnt = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString(lblVencimento.Text, fnt, Brushes.Black, Fat(nMargemX + lblVencimento.Left + lblVencimento.Width), Fat(nMargemY + lblVencimento.Top), StringRight);
                e.Graphics.DrawString(lblNossoNumero.Text, fnt, Brushes.Black, Fat(nMargemX + lblNossoNumero.Left + lblNossoNumero.Width), Fat(nMargemY + lblNossoNumero.Top), StringRight);
                e.Graphics.DrawString(lblValor.Text, fnt, Brushes.Black, Fat(nMargemX + lblValor.Left + lblValor.Width), Fat(nMargemY + lblValor.Top), StringRight);
                e.Graphics.DrawString(lblAvalista.Text, fnt, Brushes.Black, Fat(nMargemX + lblAvalista.Left + lblAvalista.Width), Fat(nMargemY + lblAvalista.Top), StringRight);
                e.Graphics.DrawString(lblCedente.Text, fnt, Brushes.Black, Fat(lblCedente.Width), Fat(nMargemY + lblCedente.Top), StringRight);

                //Define a fonte para sacador
                e.Graphics.DrawString(lblSecador.Text, fnt, Brushes.Black,       Fat(lblSecador.Left + lblSecador.Width), Fat(323), StringRight);
                e.Graphics.DrawString(lbl_cpfSecador.Text, fnt, Brushes.Black,   Fat(4+lbl_cpfSecador.Left + lbl_cpfSecador.Width), Fat(nMargemY + lbl_cpfSecador.Top), StringRight);
                e.Graphics.DrawString(lblEndereco.Text, fnt, Brushes.Black,      Fat(lblEndereco.Left + lblEndereco.Width), Fat(nMargemY + lblEndereco.Top), StringRight);
                e.Graphics.DrawString(lblBairroSacador.Text, fnt, Brushes.Black, Fat(15+lblBairroSacador.Left + lblBairroSacador.Width), Fat(nMargemY + lblBairroSacador.Top), StringRight);
                e.Graphics.DrawString(lblCidadeSecador.Text, fnt, Brushes.Black, Fat(24+lblCidadeSecador.Left + lblCidadeSecador.Width), Fat(nMargemY + lblCidadeSecador.Top), StringRight);
                e.Graphics.DrawString(lblCepSacador.Text, fnt, Brushes.Black,    Fat(9+lblCepSacador.Left + lblCepSacador.Width), Fat(nMargemY + lblCepSacador.Top), StringRight);
                e.Graphics.DrawString(lblEstadoSacador.Text, fnt, Brushes.Black, Fat(16+lblEstadoSacador.Left + lblEstadoSacador.Width), Fat(nMargemY + lblEstadoSacador.Top), StringRight);
                // desenha o código de barras
                e.Graphics.DrawImage(picBarra.Image, Fat(picBarra.Left), Fat(picBarra.Top + nMargemY + 5));

                // O objeto "e" possui um ponteiro grafico para o dispositivo de saida de impressão
                // Vale lembrar que a resolução da impressora é quase sempre maior que a resolução do computador,
                // portanto de acordo as coordenadas são diferente. se for usado a escada: GraphicsUnit.Document
               //e.Graphics.PageUnit = GraphicsUnit.Document;

                

                
                


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // esta relação permite-se converter pixel convertido em milimetros
        // double _fat = 300d / 25.4d; => 300 dpi / 25.4 cm
        double _fat = 1d; // escala normal (pixel)
        private int Fat(int n)
        {
            return (int)(_fat * n);
        }


    }
}


