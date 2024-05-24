using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxCustomizada.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //--Text-somente mensagem Box
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMsgText_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            DialogResult resultado = CMMessageBox.Show("Este é um Exemplo do Text-somente Mesage Box.");
            if (resultado == DialogResult.OK)
                labelDialogResult.Text = "You have selected the OK BUTTON";
            else labelDialogResult.Text = "You have selected CANCEL";
        }

        //--Text + Caption Messagem Box
        private void btnMsgTextCaption1_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            DialogResult resultado = CMMessageBox.Show("Este é um Exemplo do Text + Caption Mesage Box.",
                "Message Importante");
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgTextCaption2_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n\nWhy do we use it?\n\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                "System: Save Changes");
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        //--Butons Message Box
        private void btnMsgOk_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão OK Message Box",
                "OK Button",
                MessageBoxButtons.OK);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgOkCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão OK e Cancel Message Box",
                "OK-Cancel Button",
                MessageBoxButtons.OKCancel);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão Abort, Retry, Ignore Message Box",
                "Abort-Retry-Ignore Button",
                MessageBoxButtons.AbortRetryIgnore);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgYesNo_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão Yes e No Message Box",
                "Yes-No Button",
                MessageBoxButtons.YesNo);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgYesNoCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão Yes, No e Cancel Message Box",
                "Yes-No-Cancel Button",
                MessageBoxButtons.YesNoCancel);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgRetryCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Botão Retry e Cancel Message Box",
                "Retry-Cancel Button",
                MessageBoxButtons.RetryCancel);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        //--Icons Message Box

        private void btnMsgWarning_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Icon Warning-Exclamation Message Box",
                "Warning-Exclamation Icon",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgQuestion_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Icon Question Message Box",
                "Question Icon",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgError_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Icon Error-Stop Message Box",
                "Error-Stop Icon",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgInformation_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("Este é exemplo do Icon Information Message Box",
                "Information Icon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        //--Default Button
        private void btnMsgButton1_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("This is an example of a Message Box that sets Button1 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button1.",
               "Warning-Exclamation Icon",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgButton2_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("This is an example of a Message Box that sets Button2 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button2.",
               "Warning-Exclamation Icon",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }

        private void btnMsgButton3_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var resultado = CMMessageBox.Show("This is an example of a Message Box that sets Button3 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button3.",
               "Warning-Exclamation Icon",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button3);
            labelDialogResult.Text = resultado.ToString() + " Selected";
        }


        private void Any()
        {
            //-| IWin32Window owner:
            //Displays a message box in front of the specified object and with the other specified parameters.           
            CMMessageBox.Show(this, "Text");
            CMMessageBox.Show(this, "Text", "Caption");
            CMMessageBox.Show(this, "Text", "Caption", MessageBoxButtons.OKCancel);
            //Etc
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Any();
        }
    }
}
