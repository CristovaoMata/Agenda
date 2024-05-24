namespace AgendaTelefónica_1._0
{
    partial class FrmPesquisa
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
            this.btnCancelar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnPesquisar = new ControlesPersonalizados.CMControles.CMButton();
            this.txtPesquisa = new ControlesPersonalizados.CMControles.CMTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.Plum;
            this.btnCancelar.BorderRadius = 32;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(81, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 37);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.BorderColor = System.Drawing.Color.Plum;
            this.btnPesquisar.BorderRadius = 32;
            this.btnPesquisar.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(218, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 37);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextColor = System.Drawing.Color.White;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPesquisa.BorderFocusColor = System.Drawing.Color.MediumSpringGreen;
            this.txtPesquisa.BorderRadius = 20;
            this.txtPesquisa.BorderSize = 2;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisa.Location = new System.Drawing.Point(20, 65);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Multiline = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPesquisa.PasswordChar = false;
            this.txtPesquisa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPesquisa.PlaceholderText = "Pesquisar...";
            this.txtPesquisa.ReadOnly = false;
            this.txtPesquisa.Size = new System.Drawing.Size(319, 35);
            this.txtPesquisa.TabIndex = 16;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.Texts = "";
            this.txtPesquisa.UnderlinedStyle = false;
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 165);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPesquisa_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPesquisa_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMButton btnCancelar;
        private ControlesPersonalizados.CMControles.CMButton btnPesquisar;
        private ControlesPersonalizados.CMControles.CMTextBox txtPesquisa;
    }
}