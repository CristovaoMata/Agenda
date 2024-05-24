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
    //.......................................................................
    public partial class FrmVerListaCont : Form
    {
        
        int id_contacto;
        string itemPesquisa;

        //.......................................................................
        //Construção do Form
        //......................................................................
        public FrmVerListaCont(string itemPesquisa = "")
        {
            InitializeComponent();
            this.itemPesquisa = itemPesquisa;
        }
        private void FrmVerListaCont_Load(object sender, EventArgs e)
        {
            ConstruirDgtLista();
        }

        //.......................................................................
        //Métodos
        //......................................................................
        private void ConstruirDgtLista()
        {
            //Constoi a grelha de registros

            // Ligar Banco de Dados
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + ClassVar.baseDados);
            ligacao.Open();

            string query = "SELECT * FROM contactos";
            if (itemPesquisa != "")
                query = "SELECT * FROM contactos " +
                        "WHERE nome LIKE @item OR telefone LIKE @item";

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item", "%" + itemPesquisa + "%");
            comando.CommandText = query;
            comando.Connection = ligacao;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            dgvLista.DataSource = dados;
            //Apresenta o numero de registro na bd
            lblResultado.Text = "Resultados: " + dgvLista.Rows.Count + " contactos na minha Lista";

            //Esconder Colunas
                        
            dgvLista.Columns["id_contacto"].Visible = false;
            dgvLista.Columns["atualizacao"].Visible = false;

            //Alterar as dimensões das colunas
            dgvLista.Columns["nome"].Width = CalcularLargura(70);
            dgvLista.Columns["telefone"].Width = CalcularLargura(30);

            //Controla a disponiblidade dos botões
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
          
        }

        //.......................................................................
        //Código do btn FECHAR
        //.......................................................................
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu f = new FrmMenu();
            f.Show();
        }

        //.......................................................................
        //Código do btn ELIMINAR
        //.......................................................................
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Pergunta se relmente desejas eliminar o registro selecionado
            DialogResult resultado = CMMessageBox.Show("Tem a certeza que pretende eliminar o registro selecionado?", "Atenção", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            

            // verifica se vai eliminar ou não
            if (resultado == DialogResult.No) return;

            //Elimina a linha que está selecionada
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + ClassVar.baseDados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contactos WHERE id_contacto = " + id_contacto, ligacao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligacao.Dispose();

            //Reconstruir a grelha de Registos
            ConstruirDgtLista();
            
        } 

        //.......................................................................
        //Código do btn EDITAR
        //.......................................................................
        private void btnEditar_Click(object sender, EventArgs e)
        {
             //Edita o Registro Selecionado
            this.Close();
            FrmEditarAdicionar h = new FrmEditarAdicionar(id_contacto);
            h.Show();
            
            //Actualliza a Grellha de Registros
            ConstruirDgtLista();
            
        }
        
        //.......................................................................
        //Código do btn VER TUDO
        //.......................................................................
        private void btnVerTudo_Click(object sender, EventArgs e)
        {
            //Volta a presentar todos os registos de contacto
            itemPesquisa = "";
            ConstruirDgtLista();
        } 
       
        //.......................................................................
        //Código das Acções do DataGridView
        //.......................................................................
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                id_contacto = Convert.ToInt32(dgvLista.Rows[e.RowIndex].Cells["id_contacto"].Value);
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
            }
            
        }

        private int CalcularLargura(int percentegem)
        {
            int larguraGrelha = dgvLista.Width - 20;
            int resultado = (larguraGrelha * percentegem) / 100;
            return resultado;
        }

        private void FrmVerLista_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.MediumSlateBlue, ButtonBorderStyle.Solid);
        }

        //.......................................................................
        //Código para  arrsastar o formulário
        //.......................................................................
        private Point _mousePosition;
        private void FrmVerLista_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            _mousePosition = new Point(e.X, e.Y);
        }

    }
}

