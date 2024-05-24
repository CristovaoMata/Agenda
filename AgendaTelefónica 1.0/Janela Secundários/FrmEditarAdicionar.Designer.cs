namespace AgendaTelefónica_1._0
{
    partial class FrmEditarAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnFechar = new ControlesPersonalizados.CMControles.CMButton();
            this.txtNome = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtNumero = new ControlesPersonalizados.CMControles.CMTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adicionar e Editar Registros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGravar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGravar.BorderColor = System.Drawing.Color.Plum;
            this.btnGravar.BorderRadius = 32;
            this.btnGravar.BorderSize = 0;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(154, 170);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(121, 37);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextColor = System.Drawing.Color.White;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFechar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFechar.BorderColor = System.Drawing.Color.Plum;
            this.btnFechar.BorderRadius = 32;
            this.btnFechar.BorderSize = 0;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(17, 170);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(115, 37);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Cancelar";
            this.btnFechar.TextColor = System.Drawing.Color.White;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderFocusColor = System.Drawing.Color.MediumSpringGreen;
            this.txtNome.BorderRadius = 20;
            this.txtNome.BorderSize = 2;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(16, 63);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(259, 35);
            this.txtNome.TabIndex = 14;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.MediumSpringGreen;
            this.txtNumero.BorderRadius = 20;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumero.Location = new System.Drawing.Point(16, 119);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "Número";
            this.txtNumero.ReadOnly = false;
            this.txtNumero.Size = new System.Drawing.Size(259, 35);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumero.Texts = "";
            this.txtNumero.UnderlinedStyle = false;
            // 
            // FrmEditarAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 229);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarAdicionar";
            this.Load += new System.EventHandler(this.FrmEditarAdicionar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmEditarAdicionar_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMButton btnGravar;
        private ControlesPersonalizados.CMControles.CMButton btnFechar;
        private ControlesPersonalizados.CMControles.CMTextBox txtNome;
        private ControlesPersonalizados.CMControles.CMTextBox txtNumero;
    }
}