namespace PraticaWFA
{
    partial class ListarFuncionarios
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
            this.btnEditarFuncionario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lv_funcionario = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEditarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarFuncionario.BorderRadius = 0;
            this.btnEditarFuncionario.ButtonText = "              Editar";
            this.btnEditarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarFuncionario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarFuncionario.Iconimage = global::PraticaWFA.Properties.Resources.icons8_editar_usuário_masculino_64;
            this.btnEditarFuncionario.Iconimage_right = null;
            this.btnEditarFuncionario.Iconimage_right_Selected = null;
            this.btnEditarFuncionario.Iconimage_Selected = null;
            this.btnEditarFuncionario.IconZoom = 70D;
            this.btnEditarFuncionario.IsTab = false;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(161, 466);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEditarFuncionario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditarFuncionario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarFuncionario.selected = false;
            this.btnEditarFuncionario.Size = new System.Drawing.Size(212, 40);
            this.btnEditarFuncionario.TabIndex = 2;
            this.btnEditarFuncionario.Textcolor = System.Drawing.Color.White;
            this.btnEditarFuncionario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // lv_funcionario
            // 
            this.lv_funcionario.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lv_funcionario.AutoArrange = false;
            this.lv_funcionario.BackColor = System.Drawing.Color.White;
            this.lv_funcionario.CheckBoxes = true;
            this.lv_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_funcionario.ForeColor = System.Drawing.Color.Black;
            this.lv_funcionario.FullRowSelect = true;
            this.lv_funcionario.GridLines = true;
            this.lv_funcionario.Location = new System.Drawing.Point(12, 15);
            this.lv_funcionario.Name = "lv_funcionario";
            this.lv_funcionario.Size = new System.Drawing.Size(1032, 445);
            this.lv_funcionario.TabIndex = 1;
            this.lv_funcionario.UseCompatibleStateImageBehavior = false;
            this.lv_funcionario.View = System.Windows.Forms.View.Details;
            this.lv_funcionario.SelectedIndexChanged += new System.EventHandler(this.lv_funcionario_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditarFuncionario);
            this.panel1.Controls.Add(this.lv_funcionario);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 516);
            this.panel1.TabIndex = 6;
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1081, 616);
            this.Controls.Add(this.panel1);
            this.Name = "ListarFuncionarios";
            this.Text = "ListarFuncionarios";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnEditarFuncionario;
        private System.Windows.Forms.ListView lv_funcionario;
        private System.Windows.Forms.Panel panel1;
    }
}