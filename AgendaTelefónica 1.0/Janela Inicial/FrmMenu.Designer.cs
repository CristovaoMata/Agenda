namespace AgendaTelefónica_1._0
{
    partial class FrmMenu
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
            this.lblVrsao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerLista = new ControlesPersonalizados.CMControles.CMButton();
            this.btnEditarAdicionar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnPesquisar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnSair = new ControlesPersonalizados.CMControles.CMButton();
            this.SuspendLayout();
            // 
            // lblVrsao
            // 
            this.lblVrsao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrsao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVrsao.Location = new System.Drawing.Point(92, 298);
            this.lblVrsao.Name = "lblVrsao";
            this.lblVrsao.Size = new System.Drawing.Size(100, 23);
            this.lblVrsao.TabIndex = 5;
            this.lblVrsao.Text = "Versão";
            this.lblVrsao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agenda Telefónica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerLista.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerLista.BorderColor = System.Drawing.Color.Plum;
            this.btnVerLista.BorderRadius = 40;
            this.btnVerLista.BorderSize = 0;
            this.btnVerLista.FlatAppearance.BorderSize = 0;
            this.btnVerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLista.ForeColor = System.Drawing.Color.White;
            this.btnVerLista.Location = new System.Drawing.Point(26, 95);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(239, 40);
            this.btnVerLista.TabIndex = 7;
            this.btnVerLista.Text = "Ver Contactos";
            this.btnVerLista.TextColor = System.Drawing.Color.White;
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnEditarAdicionar
            // 
            this.btnEditarAdicionar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditarAdicionar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditarAdicionar.BorderColor = System.Drawing.Color.Plum;
            this.btnEditarAdicionar.BorderRadius = 40;
            this.btnEditarAdicionar.BorderSize = 0;
            this.btnEditarAdicionar.FlatAppearance.BorderSize = 0;
            this.btnEditarAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEditarAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnEditarAdicionar.Location = new System.Drawing.Point(23, 144);
            this.btnEditarAdicionar.Name = "btnEditarAdicionar";
            this.btnEditarAdicionar.Size = new System.Drawing.Size(239, 40);
            this.btnEditarAdicionar.TabIndex = 8;
            this.btnEditarAdicionar.Text = "Adicionar";
            this.btnEditarAdicionar.TextColor = System.Drawing.Color.White;
            this.btnEditarAdicionar.UseVisualStyleBackColor = false;
            this.btnEditarAdicionar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.BorderColor = System.Drawing.Color.Plum;
            this.btnPesquisar.BorderRadius = 40;
            this.btnPesquisar.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(23, 190);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(239, 40);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextColor = System.Drawing.Color.White;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.BorderColor = System.Drawing.Color.Plum;
            this.btnSair.BorderRadius = 40;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(23, 245);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(239, 40);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditarAdicionar);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVrsao);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMenu_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVrsao;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMButton btnVerLista;
        private ControlesPersonalizados.CMControles.CMButton btnEditarAdicionar;
        private ControlesPersonalizados.CMControles.CMButton btnPesquisar;
        private ControlesPersonalizados.CMControles.CMButton btnSair;
    }
}

