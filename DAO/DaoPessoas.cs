using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace infoQmaisEstoq
{
    public class DaoPessoas
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

        //conexao 1 - logon
        public bool Logon(string logon, string senha)
        {
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT idPessoa FROM Pessoas WHERE logon = '" + logon + "' AND senha = '" + senha + "' AND nivel <> 3", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 2 - salva nova pessoa
        public static string SalvaPessoas(BoPessoas pessoa)
        {
            try
            {
                //testa uso do cpf
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT idPessoa FROM Pessoas WHERE cpf = '" + pessoa.Cpf + "'", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    throw PessoaJaCadastrada();
                }
                conexao.Close();
                //testa validade logon
                SqlConnection conexao2 = Conexao.Conecta();
                conexao2.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT idPessoa FROM Pessoas WHERE logon = '" + pessoa.Logon + "' AND nivel <> 3", conexao2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    throw LogonEmUso();
                }
                else
                {
                    //insere nova pessoa
                    SqlConnection conexao3 = Conexao.Conecta();
                    conexao3.Open();
                    SqlCommand cmd3 = new SqlCommand(@"INSERT INTO Pessoas (idPessoa, nivel, nome, rg, cpf, dataDeNascimento, dataDeCadastro, idEndereco, telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou, logon, senha) 
                                                       VALUES ((SELECT ISNULL(MAX(idPessoa) + 1, 1) AS ProximoId FROM Pessoas), " + pessoa.Nivel + ",'" + pessoa.Nome + "','" + pessoa.Rg + "','" + pessoa.Cpf + "','" + pessoa.DataDeNascimento + "','" + pessoa.DataDeCadastro + "','" + pessoa.IdEndereco + "','" + pessoa.Telefone + "','" + pessoa.Celular + "','" + pessoa.Email + "','" + pessoa.Profissao + "','" + pessoa.Convenio + "','" + pessoa.EstadoCivil + "','" + pessoa.QuemIndicou + "','" + pessoa.Logon + "','" + pessoa.Senha + "')", conexao3);
                    cmd3.ExecuteNonQuery();
                    conexao3.Close();
                    return "Pessoa Cadastrada com sucesso";
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //conexao 3 - traz a data do servidor OleDb
        public DateTime DataDeAgora()
        {
            DateTime agora = Convert.ToDateTime("01/01/1900");
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT CURRENT_TIMESTAMP AS agora", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    agora = (DateTime)dr["agora"];
                }
                conexao.Close();
                return (agora);
            }
            catch (SqlException)
            {
                return (agora);
            }
        }

        //conexao 4 - busca todos nomes de pessoas
        public ArrayList BuscaTodosNomes()
        {
            try
            {
                ArrayList todosNomes = new ArrayList();
                todosNomes.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT nome FROM Pessoas WHERE nivel <> 0 ORDER BY nome", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    todosNomes.Add(dr["nome"].ToString());
                }
                conexao.Close();
                return (todosNomes);
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }

        //conexao 5 - busca todos dados de uma pessoa por nome
        public BoPessoas BuscaDadosPorNome(string nome)
        {
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nome = '" + nome + "' AND nivel <> 0", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    return pessoa;
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

        //conexao 6 - busca todos os dados de uma pessoa por cpf
        public BoPessoas BuscaDadosPorCpf(string cpf)
        {
            try
            {
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE cpf = '" + cpf + "' AND nivel <> 0", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    return pessoa;
                }
                else
                {
                    throw DadoInexistente();
                }
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }

        //conexao 7 - busca todos os dados de todas pessoas
        public List<BoPessoas> BuscaTodasPessoas()
        {
            try
            {
                List<BoPessoas> todasPessoas = new List<BoPessoas>();
                bool efetuouLeitura = false;
                todasPessoas.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nivel <> 0 ORDER BY nome", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    todasPessoas.Add(pessoa);
                    efetuouLeitura = true;
                }
                if (!efetuouLeitura)
                {
                    throw DadoInexistente();
                }
                return todasPessoas;
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }

        //conexao 8 - busca todos os dados de todos médicos
        public List<BoPessoas> BuscaTodosSupervisores()
        {
            try
            {
                List<BoPessoas> todosSupervisores = new List<BoPessoas>();
                bool efetuouLeitura = false;
                todosSupervisores.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nivel = 1 ORDER BY nome", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    todosSupervisores.Add(pessoa);
                    efetuouLeitura = true;
                }
                if (!efetuouLeitura)
                {
                    throw DadoInexistente();
                }
                return todosSupervisores;
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }

        //conexao 9 - busca todos os dados de todos clientes
        public List<BoPessoas> BuscaTodosClientes()
        {
            try
            {
                List<BoPessoas> todosClientes = new List<BoPessoas>();
                bool efetuouLeitura = false;
                todosClientes.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nivel = 3 ORDER BY nome", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    todosClientes.Add(pessoa);
                    efetuouLeitura = true;
                }
                if (!efetuouLeitura)
                {
                    throw DadoInexistente();
                }
                return todosClientes;
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }

        //conexao 10 - busca todos os dados de todos funcionarios
        public List<BoPessoas> BuscaTodosFuncionarios()
        {
            try
            {
                List<BoPessoas> todosFuncionarios = new List<BoPessoas>();
                bool efetuouLeitura = false;
                todosFuncionarios.Clear();
                SqlConnection conexao = Conexao.Conecta();
                conexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoas WHERE nivel = 2 ORDER BY nome", conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BoPessoas pessoa = new BoPessoas(Convert.ToInt32(dr["nivel"]), dr["nome"].ToString(), dr["rg"].ToString(), dr["cpf"].ToString(), Convert.ToInt32(dr["idEndereco"]), dr["telefone"].ToString(), dr["celular"].ToString(), dr["email"].ToString(), dr["profissao"].ToString(), dr["convenio"].ToString(), dr["estadoCivil"].ToString(), dr["quemIndicou"].ToString(), dr["dataDeNascimento"].ToString(), dr["dataDeCadastro"].ToString(), dr["logon"].ToString(), dr["senha"].ToString());
                    todosFuncionarios.Add(pessoa);
                    efetuouLeitura = true;
                }
                if (!efetuouLeitura)
                {
                    throw DadoInexistente();
                }
                return todosFuncionarios;
            }
            catch (SqlException)
            {
                throw ErroConexao();
            }
        }
    }
}
