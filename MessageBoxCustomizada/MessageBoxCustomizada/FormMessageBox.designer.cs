namespace MessageBoxCustomizada
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.cmButton1 = new ControlesPersonalizados.CMControles.CMButton();
            this.cmButton2 = new ControlesPersonalizados.CMControles.CMButton();
            this.cmButton3 = new ControlesPersonalizados.CMControles.CMButton();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlTitulo.Controls.Add(this.lblCaption);
            this.pnlTitulo.Controls.Add(this.btnClose);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(2, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(346, 35);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(9, 8);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(44, 18);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Titulo";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(306, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblMessage);
            this.pnlBody.Controls.Add(this.pictureBoxIcon);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(2, 37);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlBody.Size = new System.Drawing.Size(346, 51);
            this.pnlBody.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(50, 10);
            this.lblMessage.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.lblMessage.Size = new System.Drawing.Size(106, 37);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "lblMensagem";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = global::MessageBoxCustomizada.Properties.Resources.Message;
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 41);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 84;
            this.pictureBoxIcon.TabStop = false;
            // 
            // cmButton1
            // 
            this.cmButton1.BackColor = System.Drawing.Color.Green;
            this.cmButton1.BackGroundColor = System.Drawing.Color.Green;
            this.cmButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cmButton1.BorderRadius = 20;
            this.cmButton1.BorderSize = 0;
            this.cmButton1.FlatAppearance.BorderSize = 0;
            this.cmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmButton1.ForeColor = System.Drawing.Color.White;
            this.cmButton1.Location = new System.Drawing.Point(20, 12);
            this.cmButton1.Name = "cmButton1";
            this.cmButton1.Size = new System.Drawing.Size(100, 35);
            this.cmButton1.TabIndex = 0;
            this.cmButton1.Text = "cmButton1";
            this.cmButton1.TextColor = System.Drawing.Color.White;
            this.cmButton1.UseVisualStyleBackColor = false;
            this.cmButton1.Visible = false;
            // 
            // cmButton2
            // 
            this.cmButton2.BackColor = System.Drawing.Color.Green;
            this.cmButton2.BackGroundColor = System.Drawing.Color.Green;
            this.cmButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cmButton2.BorderRadius = 20;
            this.cmButton2.BorderSize = 0;
            this.cmButton2.FlatAppearance.BorderSize = 0;
            this.cmButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmButton2.ForeColor = System.Drawing.Color.White;
            this.cmButton2.Location = new System.Drawing.Point(127, 12);
            this.cmButton2.Name = "cmButton2";
            this.cmButton2.Size = new System.Drawing.Size(100, 35);
            this.cmButton2.TabIndex = 1;
            this.cmButton2.Text = "cmButton2";
            this.cmButton2.TextColor = System.Drawing.Color.White;
            this.cmButton2.UseVisualStyleBackColor = false;
            this.cmButton2.Visible = false;
            // 
            // cmButton3
            // 
            this.cmButton3.BackColor = System.Drawing.Color.Green;
            this.cmButton3.BackGroundColor = System.Drawing.Color.Green;
            this.cmButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cmButton3.BorderRadius = 20;
            this.cmButton3.BorderSize = 0;
            this.cmButton3.FlatAppearance.BorderSize = 0;
            this.cmButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmButton3.ForeColor = System.Drawing.Color.White;
            this.cmButton3.Location = new System.Drawing.Point(235, 12);
            this.cmButton3.Name = "cmButton3";
            this.cmButton3.Size = new System.Drawing.Size(100, 35);
            this.cmButton3.TabIndex = 2;
            this.cmButton3.Text = "cmButton3";
            this.cmButton3.TextColor = System.Drawing.Color.White;
            this.cmButton3.UseVisualStyleBackColor = false;
            this.cmButton3.Visible = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlButtons.Controls.Add(this.cmButton3);
            this.pnlButtons.Controls.Add(this.cmButton2);
            this.pnlButtons.Controls.Add(this.cmButton1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(2, 88);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(346, 60);
            this.pnlButtons.TabIndex = 1;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(350, 149);
            this.Name = "FormMessageBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMMessageBox";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel pnlBody;
        private ControlesPersonalizados.CMControles.CMButton cmButton1;
        private ControlesPersonalizados.CMControles.CMButton cmButton2;
        private ControlesPersonalizados.CMControles.CMButton cmButton3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnClose;
    }
}