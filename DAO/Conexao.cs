using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace infoQmaisEstoq
{
    class Conexao
    {
        //SQL
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public static SqlConnection Conecta()
        {
            try
            {
                //Instancia Local
                //String caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\infoQmais\infoQmaisEstoq\infoQmaisEstoq.mdf;Integrated Security=True;Connect Timeout=60";                
                //Instancia SQLExpress
                string caminho = @"Data Source=REINALDO-PC\SQLEXPRESS;Initial Catalog=infoQmaisEstoq;Integrated Security=True;Connect Timeout=60";
                SqlConnection conexao = new SqlConnection(caminho);
                return conexao;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        //Access
        //-------------------------------------------------------------------------------------------------------------------------------------------------------- -
        //public static OleDbConnection Conecta()
        //{
        //    try
        //    {
        //        String mapa = Controle.DiretorioRaiz();
        //        String caminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + mapa + @"\infoQ+Estoq.mdb";
        //        OleDbConnection conexao = new OleDbConnection(caminho);
        //        return conexao;
        //    }
        //    catch (OleDbException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
}
