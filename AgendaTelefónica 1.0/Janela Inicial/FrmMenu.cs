using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxCustomizada;

namespace AgendaTelefónica_1._0
{
    public partial class FrmMenu : Form
    {
        //.......................................................................
        public FrmMenu()
        {
            InitializeComponent();

            //Apresentar a verao do Software
            lblVrsao.Text = ClassVar.versao;
        }

        //.......................................................................
        //Código do btn VER LISTA
        //.......................................................................
        
        private void btnVerLista_Click(object sender, EventArgs e)
        {
            //Abrir a janela que vai apresentar todos os contactos
            FrmVerListaCont g = new FrmVerListaCont();
            g.Show();
            this.Hide();
        }

        //.......................................................................
        //Código do btn ADICIONAR e EDITAR
        //.......................................................................
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Abrir a Janela de adicionar novos registro e editar
            FrmEditarAdicionar a = new FrmEditarAdicionar();
            a.Show();
            this.Hide();
        }
       
        //.......................................................................
        //Código do btn SAIR
        //.......................................................................
        private void btnSair_Click(object sender, EventArgs e)
        {
            //Confirmar se desejas sai ou não
            DialogResult resultado = CMMessageBox.Show("Desejas Sair!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes) this.Close();
        }

        //.......................................................................
        //Código do btn PESQUISAR
        //.......................................................................
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Abrir a janela de pesquisa
            FrmPesquisa p = new FrmPesquisa();
            this.Hide();
            p.ShowDialog();
            this.Show();

            //Executa a pesquisa se a janela não for cancelado
            if (p.cancelado) 
            {
                p.Dispose();
                return;             
            }
            
            //Executa a pesquisa           
            FrmVerListaCont f = new FrmVerListaCont(p.textoPesquisa);
            f.ShowDialog();

        }

        private void FrmMenu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.MediumSlateBlue, ButtonBorderStyle.Solid);
        }

        //.......................................................................
        //Código para  arrsastar o formulário
        //.......................................................................
        private Point _mousePosition;
        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            _mousePosition = new Point(e.X, e.Y);
        }
    }
}
