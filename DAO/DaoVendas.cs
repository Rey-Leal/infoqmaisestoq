using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace infoQmaisEstoq
{
    class DaoVendas
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

        public static ApplicationException ConsultaJaCadastrada()
        {
            System.ApplicationException ex = new ApplicationException("Este CPF já existe no sistema, verifique nas listagens se esta pessoa já foi cadastrada anteriormente");
            return ex;
        }

        //conexao 1 - salva venda
        public static string SalvaVenda(BoVendas venda)
        {
            try
            {
                int funcionario = 0;
                int cliente = 0;
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nome = '" + venda.Cliente + "'", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente = Convert.ToInt32(dr["idPessoa"]);
                }
                conexao.Close();

                SqlConnection conexao2 = Conexao.Conecta();
                conexao2.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Pessoas WHERE nome = '" + venda.Funcionario + "'", conexao2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    funcionario = Convert.ToInt32(dr2["idPessoa"]);
                }
                conexao2.Close();

                SqlConnection conexao3 = Conexao.Conecta();
                conexao3.Open();
                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO Vendas (idVenda, idCliente, idFuncionario, dataDaVenda, descricaoDaVenda, observacoes, produtos, valor) 
                                                   VALUES ((SELECT ISNULL(MAX(idVenda) + 1, 1) AS ProximoId FROM Vendas), " + cliente + ", " + funcionario + ",'" + venda.DataDaVenda + "','" + venda.DescricaoDaVenda + "','" + venda.Observacoes + "','" + venda.Produtos + "', " + Controle.ConverteParaDecimal(venda.Valor) + ")", conexao3);
                cmd3.ExecuteScalar();
                conexao3.Close();

                return "Venda Cadastrada com sucesso";
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 2 - busca ultima venda
        public string BuscaVendas()
        {
            try
            {
                String consulta = "erro";
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT ultimo FROM RELATORIOS WHERE relatorio = 'Vendas'", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    consulta = dr["ultimo"].ToString();
                }
                conexao.Close();
                return consulta;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 3 - busca vendas de um cliente
        public List<string> ListaVendasCliente(string nome)
        {
            try
            {
                List<string> todasVendas = new List<string>();
                todasVendas.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT descricaoDaVenda FROM Vendas WHERE idCliente = (SELECT idPessoa FROM Pessoas WHERE nome = '" + nome + "')", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    todasVendas.Add(dr["descricaoDaVenda"].ToString());
                }
                conexao.Close();
                return todasVendas;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 4 - busca idPessoa pelo cpf         
        public string BuscaIdPeloCpf(string cpf)
        {
            try
            {
                string consulta = "";
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT idPessoa FROM Pessoas WHERE Pessoas.cpf = '" + cpf + "'", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    consulta = dr["idPessoa"].ToString();
                }
                conexao.Close();
                return consulta;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 5 - salva assinaturas
        public string SalvaAssinaturas(string diretor, string supervisor, string outros)
        {
            try
            {                
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT idAssinatura FROM Assinaturas", conexao);
                SqlDataReader dr = cmd.ExecuteReader();                
                if (dr.Read())
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE Assinaturas SET diretor='" + diretor + "', supervisor='" + supervisor + "', outros = '" + outros + "'", conexao);
                    cmd2.ExecuteScalar();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Assinaturas (idAssinatura, diretor, supervisor, outros) VALUES (1, '" + diretor + "', '" + supervisor + "', '" + outros + "')", conexao);
                    cmd2.ExecuteScalar();
                }                
                conexao.Close();

                return "Assinaturas salvas com sucesso";
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 6 - busca assinaturas        
        public List<string> BuscaAssinaturas()
        {
            try
            {
                List<string> assinaturas = new List<string>();
                assinaturas.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Assinaturas", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    assinaturas.Add(dr["diretor"].ToString());
                    assinaturas.Add(dr["supervisor"].ToString());
                    assinaturas.Add(dr["outros"].ToString());
                }
                conexao.Close();
                return assinaturas;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
