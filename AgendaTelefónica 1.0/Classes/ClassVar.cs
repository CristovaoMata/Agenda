using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;
using System.Threading.Tasks;


namespace AgendaTelefónica_1._0
{
    //.......................................................................
    public static partial class ClassVar
    {
        //Variáveis Público e Estático
        public static string versao = "v.1.0.1";
        public static string Infor;
        public static string pastaDados;
        public static string baseDados;  
        
        //.......................................................................
        //Métodos do Programa
        //.......................................................................        
        public static void Iniciar() 
        {
           
            //procder ao mecanismo de iniciação do programa
            pastaDados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Agenda Telefónica\";

            //Verifique se a pasta de dados existe. Se não cria a pasta de Dados
            if (!Directory.Exists(pastaDados))
                Directory.CreateDirectory(pastaDados);

            //Verifique se existe a base de dados de nõa cria a base de dados
            baseDados = pastaDados + "dados.sdf";
            if (!File.Exists(baseDados))
                CriarBaseDados();
        }
        public static void CriarBaseDados()
        {
            //Criação da Base de Dados
            SqlCeEngine motor = new SqlCeEngine("Data source = " + baseDados);
            motor.CreateDatabase();
            
            //criar estrutura da base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "Data source = " + baseDados;
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText =
                    "CREATE TABLE contactos(" +
                    "id_contacto            int not null primary key, " +
                    "nome                   nvarchar(50), " +
                    "telefone               nvarchar(20), " +
                    "atualizacao            datetime)";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

        }

    }
}
