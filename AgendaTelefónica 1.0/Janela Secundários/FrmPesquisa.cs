using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefónica_1._0
{
    //.......................................................................
    public partial class FrmPesquisa : Form
    {
        public string textoPesquisa { get; set; }
        public bool cancelado { get; set; }
        
        //Código da Construnção do Form
        //.......................................................................
        public FrmPesquisa()
        {
            InitializeComponent();
        }
        private void FrmPesquisa_Load(object sender, EventArgs e)
        {

        }
        
        //.......................................................................
        //Código do btn PESQUISAR
        //.......................................................................
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Executa a pesquisa mas se apenas existir texto na textBox
            if (txtPesquisa.Texts == "")
            {
                cancelado = true;
            }
            else
            {
                textoPesquisa = txtPesquisa.Texts;
            }

            this.Close();

        }
        
        //.......................................................................
        //Código do btn CANCELAR
        //.......................................................................
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fecha a janela, e cancela a pesquisa
            cancelado = true;
            this.Close();
        }
        private void FrmPesquisa_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.MediumSlateBlue, ButtonBorderStyle.Solid);
        }

        //.......................................................................
        //Código para  arrsastar o formulário
        //.......................................................................
        private Point _mousePosition;
        private void FrmPesquisa_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            _mousePosition = new Point(e.X, e.Y);
        }


    }

}
