using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace infoQmaisEstoq
{
    class Controle
    {
        public static ArrayList arrayRelatorio = new ArrayList();
        public static ArrayList arrayParametro = new ArrayList();
        public static ArrayList arrayFormAberto = new ArrayList();
        public static ArrayList arrayConsultas = new ArrayList();

        //realiza logon
        public static bool Logon(string logon, string senha)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.Logon(logon, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //retorna diretorio raiz
        public static string DiretorioRaiz()
        {
            try
            {
                string diretorioRaiz = System.IO.Directory.GetCurrentDirectory().ToString();
                return diretorioRaiz;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //controla abertura de forms
        public static void AbriuForm(string frm)
        {
            arrayFormAberto.Add(frm);
        }

        //controla fechamento de forms
        public static void FechouForm(string frm)
        {
            arrayFormAberto.Remove(frm);
        }

        //testa se form esta aberto
        public static bool FormsAbertos(string frm)
        {
            for (int i = 0; i < arrayFormAberto.Count; i++)
            {
                if (arrayFormAberto[i].Equals(frm))
                {
                    return true;
                }
            }
            return false;
        }

        //abre form cadastro
        public static void AbreFormCadastroPessoa()
        {
            FrmCadastroPessoas frmCadastroPessoas = new FrmCadastroPessoas();
            frmCadastroPessoas.Show();
        }

        //salva uma nova pessoa
        public static string SalvaPessoa(BoPessoas pessoa)
        {
            try
            {
                string salva = DaoPessoas.SalvaPessoas(pessoa);
                return salva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //salva um novo endereco e retorna idEndereco salvo
        public static int SalvaEndereco(BoEnderecos endereco)
        {
            try
            {
                int idEndereco = DaoEnderecos.SalvaEndereco(endereco);
                return idEndereco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //salva uma nova consuta
        public static string SalvaVenda(BoVendas venda)
        {
            try
            {
                string salva = DaoVendas.SalvaVenda(venda);
                return salva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //traz a data de hoje
        public static DateTime DataDeAgora()
        {
            //Access
            return System.DateTime.Now;

            //SQL
            //DaoPessoas daoPessoas = new DaoPessoas();
            //return daoPessoas.DataDeAgora();
        }

        //converte data portuguesa para formato ingles
        public static string ConverteFormatoData(string dataPortuguesa)
        {
            try
            {
                DateTime data = DateTime.Parse(dataPortuguesa);
                string dia = data.Day.ToString();
                string mes = data.Month.ToString();
                string ano = data.Year.ToString();
                string dataInglesa = mes + "/" + dia + "/" + ano;
                return dataInglesa;
            }
            catch
            {
                return "01/01/1900";
            }
        }

        //busca todos os nomes de pessoas
        public static ArrayList BuscaTodosNomes()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosNomes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca ultima venda
        public static string BuscaVendas()
        {
            try
            {
                DaoVendas daoVendas = new DaoVendas();
                return daoVendas.BuscaVendas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca todos dados de uma pessoa por nome
        public static BoPessoas BuscaDadosPorNome(string nome)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaDadosPorNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca todos dados de uma pessoa por cpf
        public static BoPessoas BuscaDadosPorCpf(string cpf)
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaDadosPorCpf(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //lista todos dados de todas pessoas
        public static List<BoPessoas> BuscaTodasPessoas()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodasPessoas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos supervisores
        public static List<BoPessoas> BuscaTodosSupervisores()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosSupervisores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos funcionarios
        public static List<BoPessoas> BuscaTodosFuncionarios()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosFuncionarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //lista todos dados de todos clientes
        public static List<BoPessoas> BuscaTodosClientes()
        {
            try
            {
                DaoPessoas daoPessoas = new DaoPessoas();
                return daoPessoas.BuscaTodosClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //lista vendas de uma pessoa
        public static List<string> ListaVendasCliente(string nome)
        {
            try
            {
                DaoVendas daoVendas = new DaoVendas();
                return daoVendas.ListaVendasCliente(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca idPessoa pelo cpf
        public static string BuscaIdPeloCpf(string cpf)
        {
            try
            {
                DaoVendas daoVendas = new DaoVendas();
                return daoVendas.BuscaIdPeloCpf(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //busca endereco pelo idPessoa
        public static BoEnderecos BuscaEnderecoPeloIdEndereco(int idEndereco)
        {
            try
            {
                DaoEnderecos daoEnderecos = new DaoEnderecos();
                return daoEnderecos.BuscaEnderecoPeloIdEndereco(idEndereco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //salva assinaturas
        public static string SalvaAssinaturas(string diretor, string supervisor, string outros)
        {
            DaoVendas daoVendas = new DaoVendas();
            return daoVendas.SalvaAssinaturas(diretor, supervisor, outros);
        }

        //busca assinaturas
        public static List<String> BuscaAssinaturas()
        {
            DaoVendas daoVendas = new DaoVendas();
            return daoVendas.BuscaAssinaturas();
        }

        //valida cpf
        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        //trata campos com valores monetarios
        public static string ConverteParaTextoMonetario(string textoEntrada)
        { 
            double textoRetorno;
            double.TryParse(textoEntrada, out textoRetorno);
            return textoRetorno.ToString("N");
        }

        //trata campos com valores monetarios
        public static string ConverteParaDecimal(decimal valorEntrada)
        {
            return valorEntrada.ToString().Replace("R$", "").Replace(".", "").Replace(",", ".");            
        }

        //abre vizualizador de relatórios
        public static void AbreRelatorio(string relatorio, string parametro)
        {
            //arrayRelatorio.Clear();
            //arrayParametro.Clear();
            //arrayRelatorio.Add(relatorio);
            //arrayParametro.Add(parametro);
            //FrmRelatorios frmRelatorios = new FrmRelatorios();
            //frmRelatorios.MdiParent = FrmPrincipal.ActiveForm;
            //frmRelatorios.Show();
        }

        //busca relatorio a imprimir
        public static string ImprimirRelatorio()
        {
            return arrayRelatorio[arrayRelatorio.Count - 1].ToString();
        }

        //retorna parametro do relatorio a imprimir
        public static string ParametroRelatorio()
        {
            return arrayParametro[arrayParametro.Count - 1].ToString();
        }
    }
}
