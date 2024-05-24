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
    public partial class FrmEditarAdicionar : Form
    {
        //Variáveis Globais
        int id_contacto;
        bool editar, estado;
        string info = "";

        //.......................................................................
        //Construção do form
        //.......................................................................
        public FrmEditarAdicionar(int id_contacto = -1)
        {
            InitializeComponent();
            this.id_contacto = id_contacto;

            //definir se vou adicionar ou editar registo
            editar = id_contacto == -1 ? false : true;
        }
        private void FrmEditarAdicionar_Load(object sender, EventArgs e)
        {
            txtNome.Focus();

            //Apresenta os dados do contacto se for necessário
            if (editar)
                ApresentaContacto();
        }

        //.......................................................................
        //Métodos
        //.......................................................................        
        private void ApresentaContacto()
        {
            //Apresentar o contanto que vai ser editado
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + ClassVar.baseDados);
            ligacao.Open();
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contactos WHERE id_contacto = " + id_contacto, ligacao);
            adaptador.Fill(dados);

            //Colocar os dados nos text Box
            txtNome.Texts = dados.Rows[0]["nome"].ToString();
            txtNumero.Texts = dados.Rows[0]["telefone"].ToString();

            ligacao.Dispose();
            estado = true;

        }

        //.......................................................................
        //Código do btn Gravar
        //.......................................................................
        private void btnGravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + ClassVar.baseDados);
            ligacao.Open();

            //Grava novo Registro ou Edita registo existente

            #region Verificações

            //Verifica se os campos estão todos preechidos
            if (txtNome.Texts == "" || txtNumero.Texts == "")
            {
                CMMessageBox.Show("Os campos Nome e Número são obrigatórios! \n Preeche e tenta novamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            //------------------------------------------------
            #region NOVO CONTACTO
            if (!editar)
            {
                //Buscar o id_contacto disponível
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_contacto) AS maxid FROM contactos", ligacao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Verifica se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    id_contacto = 0;

                else
                    id_contacto = Convert.ToInt16(dados.Rows[0][0]) + 1;

                //Gravar o Novo contacto na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros 
                comando.Parameters.AddWithValue("@id_contacto", id_contacto);
                comando.Parameters.AddWithValue("@nome", txtNome.Texts);
                comando.Parameters.AddWithValue("@telefone", txtNumero.Texts);
                comando.Parameters.AddWithValue("@actualizacao", DateTime.Now);

                //Verifique se ja existe um contacto com mesmo nome e numero 
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM  contactos WHERE nome = @nome AND telefone = @telefone";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);
                if (dados.Rows.Count != 0)
                {
                    //Já existe registro com mesmo nome numero
                    info = "Já existem um Registro com o mesmo Nome e Número!\n" +
                                   "Desejas gravar ainda assim?";
                  DialogResult resultado = CMMessageBox.Show(info, "Atneção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                  //Avalia se vai gravar ou não
                  if (resultado == DialogResult.No)return;                                   
                     
                }
                //texto da Query
                comando.CommandText = "INSERT INTO contactos VALUES(" +
                    "@id_contacto, @nome, @telefone, @actualizacao)";


                comando.ExecuteNonQuery();
                comando.Dispose();
                ligacao.Dispose();

                //Abre a janela de dialogo informando que o registro foi gravado
                CMMessageBox.Show("Gravado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpar os campos
                txtNome.Texts = "";
                txtNumero.Texts = "";
                txtNome.Focus();


            }
            #endregion

            //------------------------------------------------
            #region EDITAR CONTACTO
            else
            {
                //Edita o contacto na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros 
                comando.Parameters.AddWithValue("@id_contacto", id_contacto);
                comando.Parameters.AddWithValue("@nome", txtNome.Texts);
                comando.Parameters.AddWithValue("@telefone", txtNumero.Texts);
                comando.Parameters.AddWithValue("@actualizacao", DateTime.Now);

                //Verifica se já existe um contacto como mesmo nome e id_contacto diferente
                DataTable dados = new DataTable();
                comando.CommandText = "SELECT * FROM contactos WHERE nome = @nome AND id_contacto <> @id_contacto";
                SqlCeDataAdapter adatador = new SqlCeDataAdapter();
                adatador.SelectCommand = comando;
                adatador.Fill(dados);
                if (dados.Rows.Count != 0)
                {
                    //foi encontrado um registro com o mesmo nome
                    info = "já existe um registo com o mesmo nome!\n Desejas gravar ainda assim?";
                    DialogResult resultado = CMMessageBox.Show(info, "Atneção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    //Avalia se vai gravar ou não
                    if (resultado == DialogResult.No) return;

                }

                //Editar o registro Selecionado
                comando.CommandText = "UPDATE contactos SET " +
                                      "nome = @nome, " +
                                      "telefone = @telefone, " +
                                      "atualizacao = @actualizacao " +
                                      "WHERE id_contacto = @id_contacto ";
                comando.ExecuteNonQuery();

                //Apresenta a Informação que foi gravado o registro com sucesso
                CMMessageBox.Show("Gravado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fecha a janela
                this.Close();
                FrmVerListaCont c = new FrmVerListaCont();
                c.Show();

            }

            #endregion
        }
       

        //.......................................................................
        //Código do btn Fechar
        //.......................................................................
        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha esta Janela
            if (estado)
            {
                this.Close();
                FrmVerListaCont a = new FrmVerListaCont();
                a.Show();
                return;
            }
            else
            {
                this.Close();
                FrmMenu b = new FrmMenu();
                b.Show();
            }
        }
        private void FrmEditarAdicionar_Paint(object sender, PaintEventArgs e)
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
