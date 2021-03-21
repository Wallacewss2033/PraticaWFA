namespace PraticaWFA
{
    partial class EditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionario));
            this.pnl_controles = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_salvar_f = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.pnl_cad_funcionario = new System.Windows.Forms.Panel();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.mskTxtCep = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.pb_carregar1 = new System.Windows.Forms.PictureBox();
            this.pnl_controles.SuspendLayout();
            this.pnl_cad_funcionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carregar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_controles
            // 
            this.pnl_controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnl_controles.Controls.Add(this.checkedListBox1);
            this.pnl_controles.Controls.Add(this.btn_salvar_f);
            this.pnl_controles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_controles.Location = new System.Drawing.Point(835, 0);
            this.pnl_controles.Name = "pnl_controles";
            this.pnl_controles.Size = new System.Drawing.Size(246, 616);
            this.pnl_controles.TabIndex = 74;
            this.pnl_controles.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(219, 420);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btn_salvar_f
            // 
            this.btn_salvar_f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar_f.BackgroundImage")));
            this.btn_salvar_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar_f.ButtonText = "cadastrar";
            this.btn_salvar_f.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_f.ForeColor = System.Drawing.Color.White;
            this.btn_salvar_f.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_salvar_f.Iconimage = null;
            this.btn_salvar_f.IconVisible = true;
            this.btn_salvar_f.IconZoom = 90D;
            this.btn_salvar_f.ImageIconOverlay = false;
            this.btn_salvar_f.Location = new System.Drawing.Point(49, 535);
            this.btn_salvar_f.Name = "btn_salvar_f";
            this.btn_salvar_f.Size = new System.Drawing.Size(162, 36);
            this.btn_salvar_f.TabIndex = 71;
            this.btn_salvar_f.Click += new System.EventHandler(this.btn_atualizar_f_Click);
            // 
            // pnl_cad_funcionario
            // 
            this.pnl_cad_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cad_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnl_cad_funcionario.Controls.Add(this.cbCidade);
            this.pnl_cad_funcionario.Controls.Add(this.mskTxtCep);
            this.pnl_cad_funcionario.Controls.Add(this.mskTxtCpf);
            this.pnl_cad_funcionario.Controls.Add(this.mskTxtNascimento);
            this.pnl_cad_funcionario.Controls.Add(this.label1);
            this.pnl_cad_funcionario.Controls.Add(this.label12);
            this.pnl_cad_funcionario.Controls.Add(this.txt_numero);
            this.pnl_cad_funcionario.Controls.Add(this.label11);
            this.pnl_cad_funcionario.Controls.Add(this.label10);
            this.pnl_cad_funcionario.Controls.Add(this.txt_bairro);
            this.pnl_cad_funcionario.Controls.Add(this.label9);
            this.pnl_cad_funcionario.Controls.Add(this.label2);
            this.pnl_cad_funcionario.Controls.Add(this.txt_endereco);
            this.pnl_cad_funcionario.Controls.Add(this.cb_sexo);
            this.pnl_cad_funcionario.Controls.Add(this.label8);
            this.pnl_cad_funcionario.Controls.Add(this.txt_Senha);
            this.pnl_cad_funcionario.Controls.Add(this.label6);
            this.pnl_cad_funcionario.Controls.Add(this.txt_Email);
            this.pnl_cad_funcionario.Controls.Add(this.label5);
            this.pnl_cad_funcionario.Controls.Add(this.label4);
            this.pnl_cad_funcionario.Controls.Add(this.label3);
            this.pnl_cad_funcionario.Controls.Add(this.txt_Nome);
            this.pnl_cad_funcionario.Controls.Add(this.pb_carregar1);
            this.pnl_cad_funcionario.Location = new System.Drawing.Point(17, 61);
            this.pnl_cad_funcionario.Name = "pnl_cad_funcionario";
            this.pnl_cad_funcionario.Size = new System.Drawing.Size(1011, 468);
            this.pnl_cad_funcionario.TabIndex = 75;
            // 
            // cbCidade
            // 
            this.cbCidade.AllowDrop = true;
            this.cbCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cbCidade.DropDownHeight = 150;
            this.cbCidade.Enabled = false;
            this.cbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCidade.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.ForeColor = System.Drawing.Color.Black;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.IntegralHeight = false;
            this.cbCidade.Location = new System.Drawing.Point(294, 334);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(258, 31);
            this.cbCidade.TabIndex = 54;
            // 
            // mskTxtCep
            // 
            this.mskTxtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.mskTxtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTxtCep.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.mskTxtCep.Location = new System.Drawing.Point(36, 334);
            this.mskTxtCep.Name = "mskTxtCep";
            this.mskTxtCep.Size = new System.Drawing.Size(200, 29);
            this.mskTxtCep.TabIndex = 9;
            // 
            // mskTxtCpf
            // 
            this.mskTxtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.mskTxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTxtCpf.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.mskTxtCpf.Location = new System.Drawing.Point(36, 122);
            this.mskTxtCpf.Name = "mskTxtCpf";
            this.mskTxtCpf.Size = new System.Drawing.Size(200, 29);
            this.mskTxtCpf.TabIndex = 2;
            // 
            // mskTxtNascimento
            // 
            this.mskTxtNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.mskTxtNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTxtNascimento.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.mskTxtNascimento.Location = new System.Drawing.Point(469, 122);
            this.mskTxtNascimento.Name = "mskTxtNascimento";
            this.mskTxtNascimento.Size = new System.Drawing.Size(161, 29);
            this.mskTxtNascimento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(537, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 24);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nº";
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numero.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(581, 262);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(59, 29);
            this.txt_numero.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(321, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 51;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(677, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = "Bairro";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_bairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bairro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(681, 334);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(300, 29);
            this.txt_bairro.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "CEP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Endereço";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_endereco.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(40, 264);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(435, 29);
            this.txt_endereco.TabIndex = 7;
            // 
            // cb_sexo
            // 
            this.cb_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sexo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.ForeColor = System.Drawing.Color.White;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M ",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(326, 120);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(66, 31);
            this.cb_sexo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(321, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(325, 194);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(200, 29);
            this.txt_Senha.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(520, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "E-mail";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(524, 56);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(459, 29);
            this.txt_Email.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(465, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(40, 56);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(388, 29);
            this.txt_Nome.TabIndex = 0;
            // 
            // pb_carregar1
            // 
            this.pb_carregar1.Image = global::PraticaWFA.Properties.Resources.carregamento;
            this.pb_carregar1.Location = new System.Drawing.Point(530, 334);
            this.pb_carregar1.Name = "pb_carregar1";
            this.pb_carregar1.Size = new System.Drawing.Size(66, 31);
            this.pb_carregar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_carregar1.TabIndex = 68;
            this.pb_carregar1.TabStop = false;
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1081, 616);
            this.Controls.Add(this.pnl_controles);
            this.Controls.Add(this.pnl_cad_funcionario);
            this.Name = "EditarFuncionario";
            this.Text = "EditarFuncionario";
            this.pnl_controles.ResumeLayout(false);
            this.pnl_cad_funcionario.ResumeLayout(false);
            this.pnl_cad_funcionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carregar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_controles;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_salvar_f;
        private System.Windows.Forms.Panel pnl_cad_funcionario;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.MaskedTextBox mskTxtCep;
        private System.Windows.Forms.MaskedTextBox mskTxtCpf;
        private System.Windows.Forms.MaskedTextBox mskTxtNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.PictureBox pb_carregar1;
    }
}