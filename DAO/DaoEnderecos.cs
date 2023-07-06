using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace infoQmaisEstoq
{
    public class DaoEnderecos
    {
        public ApplicationException ErroConexao()
        {
            System.ApplicationException ex = new ApplicationException("Erro na conexão com o banco de dados, ou SQL inválida");
            return ex;
        }

        public ApplicationException DadoInexistente()
        {
            System.ApplicationException ex = new ApplicationException("O dado utilizado na pesquisa não existe no banco de dados");
            return ex;
        }

        public static ApplicationException PessoaJaCadastrada()
        {
            System.ApplicationException ex = new ApplicationException("Este CPF já existe no sistema, verifique nas listagens se esta pessoa já foi cadastrada anteriormente");
            return ex;
        }

        public static ApplicationException LogonEmUso()
        {
            System.ApplicationException ex = new ApplicationException("Este Logon já esta em uso tente outro por favor");
            return ex;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------        
        //conexao 1 - salva novo endereco
        public static int SalvaEndereco(BoEnderecos endereco)
        {
            try
            {
                int idEndereco = BuscaProximoIdEndereco();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Enderecos (idEndereco,  rua, numero, bairro, complemento, cidade, estado, cep)                                                   
                                                  VALUES (" + idEndereco + ", '" + endereco.Rua + "','" + endereco.Numero + "','" + endereco.Bairro + "','" + endereco.Complemento + "','" + endereco.Cidade + "','" + endereco.Estado + "','" + endereco.Cep + "')", conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
                return idEndereco;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 2 - busca proximo idEndereco
        public static int BuscaProximoIdEndereco()
        {
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(idEndereco) + 1, 1) AS ProximoId FROM Enderecos", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return Convert.ToInt32(dr["ProximoId"]);
                }
                else
                {
                    return 1;
                }
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        //conexao 3 - busca todos dados de um endereco por idPessoa
        public BoEnderecos BuscaEnderecoPeloIdEndereco(int idEndereco)
        {
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Enderecos WHERE idEndereco = '" + idEndereco + "'", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BoEnderecos endereco = new BoEnderecos(dr["rua"].ToString(), dr["numero"].ToString(), dr["bairro"].ToString(), dr["complemento"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["cep"].ToString());
                    return endereco;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }
    }
}
