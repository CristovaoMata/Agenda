using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MessageBoxCustomizada
{
    public partial class FormMessageBox : Form
    {
        //Fields
        private Color primaryColor  = Color.MediumSlateBlue;
        private int borderSize = 2;   

        //Propriedades
        public Color PrimaryColor
        {
            get {return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;// Cor da Borda do formulario
                this.pnlTitulo.BackColor = primaryColor;// Cor de fundo barra de titulo
            }
        }

        //Construtores do formulario
        public FormMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//set default button
        }
        public FormMessageBox(string text, string caption)
        {
            InitializeComponent();            
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//set default button
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons butttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(butttons, MessageBoxDefaultButton.Button1);//set [default button1]
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons butttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(butttons, MessageBoxDefaultButton.Button1);//set [default button1]
            SetIcon(icon);
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons butttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(butttons, defaultButton);
            SetIcon(icon);
        }

        //----Private Metodos
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//set border size
            this.lblMessage.MaximumSize = new Size(550, 0);
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.cmButton1.DialogResult = DialogResult.OK;
            this.cmButton1.Visible = false;
            this.cmButton2.Visible = false;
            this.cmButton3.Visible = false;

        }
        private void SetFormSize()
        {
            int widht = this.lblMessage.Width + this.pictureBoxIcon.Width + this.pnlBody.Padding.Left;
            int height = this.pnlTitulo.Height + this.lblMessage.Height + this.pnlButtons.Height + this.pnlBody.Padding.Top;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnlButtons.Width - cmButton1.Width) / 2;
            int yCenter = (this.pnlButtons.Height - cmButton1.Height) / 2;

            switch(buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter, yCenter);
                    cmButton1.Text = "OK";
                    cmButton1.DialogResult = DialogResult.OK;// set dialogResult

                    //Set default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.OKCancel:
                    //OK Buttton
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter - (cmButton1.Width/ 2)- 5, yCenter);
                    cmButton1.Text = "OK";
                    cmButton1.DialogResult = DialogResult.OK;// set dialogResult

                    //Cancel Buttton
                    cmButton2.Visible = true;
                    cmButton2.Location = new Point(xCenter + (cmButton2.Width / 2) + 5, yCenter);
                    cmButton2.Text = "Cancelar";
                    cmButton2.DialogResult = DialogResult.Cancel; // set dialogResult
                    cmButton2.BackColor = Color.DimGray;

                    //set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//They are only 2 button, so the default
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter - (cmButton1.Width / 2) - 5, yCenter);
                    cmButton1.Text = "Repetir";
                    cmButton1.DialogResult = DialogResult.Retry;// set dialogResult

                    //Cancel Buttton
                    cmButton2.Visible = true;
                    cmButton2.Location = new Point(xCenter + (cmButton2.Width / 2) + 5, yCenter);
                    cmButton2.Text = "Cancelar";
                    cmButton2.DialogResult = DialogResult.Cancel; // set dialogResult
                    cmButton2.BackColor = Color.DimGray;

                    //set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//They are only 2 button, so the default
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter - (cmButton1.Width / 2) - 5, yCenter);
                    cmButton1.Text = "Sim";
                    cmButton1.DialogResult = DialogResult.Yes;// set dialogResult

                    //No Button
                    cmButton2.Visible = true;
                    cmButton2.Location = new Point(xCenter + (cmButton2.Width / 2) + 5, yCenter);
                    cmButton2.Text = "Não";
                    cmButton2.DialogResult = DialogResult.No; // set dialogResult
                    cmButton2.BackColor = Color.IndianRed;

                    //set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//They are only 2 button, so the default
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter - cmButton1.Width - 5, yCenter);
                    cmButton1.Text = "Sim";
                    cmButton1.DialogResult = DialogResult.Yes;// set dialogResult

                    //No Button
                    cmButton2.Visible = true;
                    cmButton2.Location = new Point(xCenter, yCenter);
                    cmButton2.Text = "Não";
                    cmButton2.DialogResult = DialogResult.No; // set dialogResult
                    cmButton2.BackColor = Color.IndianRed;

                    //Cancel Button
                    cmButton3.Visible = true;
                    cmButton3.Location = new Point(xCenter + cmButton2.Width + 5, yCenter);
                    cmButton3.Text = "Cancelar";
                    cmButton3.DialogResult = DialogResult.Cancel; // set dialogResult
                    cmButton3.BackColor = Color.DimGray;

                    //Set default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    cmButton1.Visible = true;
                    cmButton1.Location = new Point(xCenter - cmButton1.Width - 5, yCenter);
                    cmButton1.Text = "Abortar";
                    cmButton1.DialogResult = DialogResult.Abort;// set dialogResult
                    cmButton1.BackColor = Color.Goldenrod;

                    //Retry Button
                    cmButton2.Visible = true;
                    cmButton2.Location = new Point(xCenter, yCenter);
                    cmButton2.Text = "Repetir";
                    cmButton2.DialogResult = DialogResult.Retry; // set dialogResult

                    //Cancel Ignore
                    cmButton3.Visible = true;
                    cmButton3.Location = new Point(xCenter + cmButton2.Width + 5, yCenter);
                    cmButton3.Text = "Ignorar";
                    cmButton3.DialogResult = DialogResult.Ignore; // set dialogResult
                    cmButton3.BackColor = Color.DimGray;

                    //Set default Button
                    SetDefaultButton(defaultButton);
                    break;


            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaulButton)
        {
            switch(defaulButton)
            {

                case MessageBoxDefaultButton.Button1: // Focus button1  
                    cmButton1.Select();
                    cmButton1.ForeColor = Color.White;
                    cmButton1.Font = new Font(cmButton1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2: // Focus button2 
                    cmButton2.Select();
                    cmButton2.ForeColor = Color.White;
                    cmButton2.Font = new Font(cmButton2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3: // Focus button3  
                    cmButton3.Select();
                    cmButton3.ForeColor = Color.White;
                    cmButton3.Font = new Font(cmButton3.Font, FontStyle.Underline);
                    break;

            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch(icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.Error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.Information;
                    PrimaryColor = Color.FromArgb(38, 191, 165);
                    break;
                case MessageBoxIcon.Question: //Question
                    this.pictureBoxIcon.Image = Properties.Resources.Question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation: //Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.Warning;
                    PrimaryColor = Color.FromArgb(255, 148, 8 );
                    break;
                case MessageBoxIcon.None: //None
                    this.pictureBoxIcon.Image = Properties.Resources.Message;
                    PrimaryColor = Color.MediumSlateBlue;
                    break;

            }
        }

        //----Eventos Metodos
        private void btnClose_Clique(object sender, EventArgs e)
        {
            this.Close();
        }

        #region -> Arrastar Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
