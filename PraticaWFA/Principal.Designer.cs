namespace PraticaWFA
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuNAV = new BunifuAnimatorNS.Animator(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.btnListarFuncionarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_relatorio = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrarFuncionario = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_cadastrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnListarClientes = new Bunifu.Framework.UI.BunifuTileButton();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MenuNAV
            // 
            this.MenuNAV.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.MenuNAV.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.MenuNAV.DefaultAnimation = animation1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.MenuNAV.SetDecoration(this.lblNome, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.lblNome, BunifuAnimatorNS.DecorationType.None);
            this.lblNome.Location = new System.Drawing.Point(932, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 13;
            // 
            // btnListarFuncionarios
            // 
            this.btnListarFuncionarios.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnListarFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListarFuncionarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarFuncionarios.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnListarFuncionarios, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.btnListarFuncionarios, BunifuAnimatorNS.DecorationType.None);
            this.btnListarFuncionarios.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnListarFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnListarFuncionarios.Image = global::PraticaWFA.Properties.Resources.icons8_usuário_de_gênero_neutro_100;
            this.btnListarFuncionarios.ImagePosition = 20;
            this.btnListarFuncionarios.ImageZoom = 28;
            this.btnListarFuncionarios.LabelPosition = 46;
            this.btnListarFuncionarios.LabelText = "Funcionários";
            this.btnListarFuncionarios.Location = new System.Drawing.Point(402, 448);
            this.btnListarFuncionarios.Margin = new System.Windows.Forms.Padding(6);
            this.btnListarFuncionarios.Name = "btnListarFuncionarios";
            this.btnListarFuncionarios.Size = new System.Drawing.Size(284, 139);
            this.btnListarFuncionarios.TabIndex = 12;
            this.btnListarFuncionarios.Click += new System.EventHandler(this.btnListarFuncionarios_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_relatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_relatorio.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_relatorio.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btn_relatorio, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.btn_relatorio, BunifuAnimatorNS.DecorationType.None);
            this.btn_relatorio.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_relatorio.ForeColor = System.Drawing.Color.White;
            this.btn_relatorio.Image = global::PraticaWFA.Properties.Resources.medical_history;
            this.btn_relatorio.ImagePosition = 20;
            this.btn_relatorio.ImageZoom = 40;
            this.btn_relatorio.LabelPosition = 41;
            this.btn_relatorio.LabelText = "Relatórios";
            this.btn_relatorio.Location = new System.Drawing.Point(698, 76);
            this.btn_relatorio.Margin = new System.Windows.Forms.Padding(6);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(284, 209);
            this.btn_relatorio.TabIndex = 7;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click_1);
            this.btn_relatorio.MouseLeave += new System.EventHandler(this.btn_relatorio_MouseLeave);
            this.btn_relatorio.MouseHover += new System.EventHandler(this.btn_relatorio_MouseHover);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     Relatório Serviços";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuNAV.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::PraticaWFA.Properties.Resources.medical_history;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconZoom = 80D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(698, 183);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(284, 48);
            this.bunifuFlatButton4.TabIndex = 11;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Relatório Pessoa Juridica";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuNAV.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::PraticaWFA.Properties.Resources.medical_history;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(698, 130);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(284, 48);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Relatório Pagamento";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuNAV.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::PraticaWFA.Properties.Resources.medical_history;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(698, 237);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(284, 48);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Relatório Pessoa Fisica";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuNAV.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PraticaWFA.Properties.Resources.medical_history;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(698, 76);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(284, 48);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCadastrarFuncionario.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarFuncionario.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnCadastrarFuncionario, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.btnCadastrarFuncionario, BunifuAnimatorNS.DecorationType.None);
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Image = global::PraticaWFA.Properties.Resources.icons8_adicionar_usuário_masculino_64;
            this.btnCadastrarFuncionario.ImagePosition = 20;
            this.btnCadastrarFuncionario.ImageZoom = 25;
            this.btnCadastrarFuncionario.LabelPosition = 41;
            this.btnCadastrarFuncionario.LabelText = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(109, 448);
            this.btnCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(281, 139);
            this.btnCadastrarFuncionario.TabIndex = 6;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton5.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = global::PraticaWFA.Properties.Resources.icons8_configurações_64;
            this.bunifuTileButton5.ImagePosition = 20;
            this.bunifuTileButton5.ImageZoom = 23;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Configurações";
            this.bunifuTileButton5.Location = new System.Drawing.Point(109, 297);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(281, 139);
            this.bunifuTileButton5.TabIndex = 4;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::PraticaWFA.Properties.Resources.icons8_logout_arredondado_à_esquerda_64;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Logout";
            this.bunifuTileButton3.Location = new System.Drawing.Point(848, 448);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(134, 139);
            this.bunifuTileButton3.TabIndex = 5;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_cadastrar.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btn_cadastrar, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.btn_cadastrar, BunifuAnimatorNS.DecorationType.None);
            this.btn_cadastrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = global::PraticaWFA.Properties.Resources.icons8_adicionar_usuário_masculino_64;
            this.btn_cadastrar.ImagePosition = 20;
            this.btn_cadastrar.ImageZoom = 25;
            this.btn_cadastrar.LabelPosition = 41;
            this.btn_cadastrar.LabelText = "Cadastrar Cliente";
            this.btn_cadastrar.Location = new System.Drawing.Point(402, 297);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(284, 139);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::PraticaWFA.Properties.Resources.icons8_receber_dinheiro_100;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 40;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Pagamentos";
            this.bunifuTileButton2.Location = new System.Drawing.Point(402, 76);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(284, 209);
            this.bunifuTileButton2.TabIndex = 2;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnListarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListarClientes.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarClientes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnListarClientes, BunifuAnimatorNS.DecorationType.None);
            this.MenuNAV.SetDecoration(this.btnListarClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnListarClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnListarClientes.ForeColor = System.Drawing.Color.White;
            this.btnListarClientes.Image = global::PraticaWFA.Properties.Resources.icons8_usuário_de_gênero_neutro_100;
            this.btnListarClientes.ImagePosition = 20;
            this.btnListarClientes.ImageZoom = 40;
            this.btnListarClientes.LabelPosition = 46;
            this.btnListarClientes.LabelText = "Usuarios";
            this.btnListarClientes.Location = new System.Drawing.Point(109, 76);
            this.btnListarClientes.Margin = new System.Windows.Forms.Padding(6);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(281, 209);
            this.btnListarClientes.TabIndex = 1;
            this.btnListarClientes.Click += new System.EventHandler(this.btn_ListaUsuario_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1081, 616);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnListarFuncionarios);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.btnListarClientes);
            this.MenuNAV.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BunifuAnimatorNS.Animator MenuNAV;
        private Bunifu.Framework.UI.BunifuTileButton btnListarClientes;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton btn_cadastrar;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton btnCadastrarFuncionario;
        private Bunifu.Framework.UI.BunifuTileButton btn_relatorio;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private BunifuAnimatorNS.Animator animator1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton btnListarFuncionarios;
        private System.Windows.Forms.Label lblNome;
    }
}