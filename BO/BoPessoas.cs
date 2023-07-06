using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoQmaisEstoq
{
    public class BoPessoas
    {
        //construtores
        public BoPessoas(int nivel, string nome, string rg, string cpf, int idEndereco, string telefone, string celular, string email, string profissao, string convenio, string estadoCivil, string quemIndicou, string dataDeNascimento, string dataDeCadastro, string logon, string senha)
        {
            this.Nivel = nivel;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.IdEndereco = idEndereco;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Profissao = profissao;
            this.Convenio = convenio;
            this.EstadoCivil = estadoCivil;
            this.QuemIndicou = quemIndicou;
            this.DataDeNascimento = dataDeNascimento;
            this.DataDeCadastro = dataDeCadastro;
            this.Logon = logon;
            this.Senha = senha;
        }

        public BoPessoas()
        {
        }

        //atributos
        private int _nivel, _idEndereco;
        private string _nome, _rg, _cpf;
        private string _telefone, _celular, _email, _profissao, _convenio, _estadoCivil, _quemIndicou;
        private string _dataDeNascimento, _dataDeCadastro, _logon, _senha;

        //propriedades
        public int Nivel
        {
            get { return _nivel; }
            set
            {
                if (value > 3)
                {
                    _nivel = 3;
                }
                else
                {
                    _nivel = value;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length > 50)
                {
                    _nome = value.Substring(0, 50);
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public string Rg
        {
            get { return _rg; }
            set
            {
                if (value.Length > 15)
                {
                    _rg = value.Substring(0, 15);
                }
                else
                {
                    _rg = value;
                }
            }
        }

        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (value.Length > 15)
                {
                    _cpf = value.Substring(0, 15);
                }
                else
                {
                    _cpf = value;
                }
            }
        }

        public int IdEndereco
        {
            get { return _idEndereco; }
            set
            {
                _idEndereco = value;
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (value.Length > 15)
                {
                    _telefone = value.Substring(0, 15);
                }
                else
                {
                    _telefone = value;
                }
            }
        }

        public string Celular
        {
            get { return _celular; }
            set
            {
                if (value.Length > 15)
                {
                    _celular = value.Substring(0, 15);
                }
                else
                {
                    _celular = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    _email = value.Substring(0, 50);
                }
                else
                {
                    _email = value;
                }
            }
        }

        public string Profissao
        {
            get { return _profissao; }
            set
            {
                if (value.Length > 20)
                {
                    _profissao = value.Substring(0, 20);
                }
                else
                {
                    _profissao = value;
                }
            }
        }

        public string Convenio
        {
            get { return _convenio; }
            set
            {
                if (value.Length > 30)
                {
                    _convenio = value.Substring(0, 30);
                }
                else
                {
                    _convenio = value;
                }
            }
        }

        public string EstadoCivil
        {
            get { return _estadoCivil; }
            set
            {
                if (value.Length > 10)
                {
                    _estadoCivil = value.Substring(0, 10);
                }
                else
                {
                    _estadoCivil = value;
                }
            }
        }

        public string QuemIndicou
        {
            get { return _quemIndicou; }
            set
            {
                if (value.Length > 50)
                {
                    _quemIndicou = value.Substring(0, 50);
                }
                else
                {
                    _quemIndicou = value;
                }
            }
        }

        public string DataDeNascimento
        {
            get { return _dataDeNascimento; }
            set { _dataDeNascimento = value; }
        }

        public string DataDeCadastro
        {
            get { return _dataDeCadastro; }
            set { _dataDeCadastro = value; }
        }        

        public string Logon
        {
            get { return _logon; }
            set
            {
                if (value.Length > 15)
                {
                    _logon = value.Substring(0, 15);
                }
                else
                {
                    _logon = value;
                }
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (value.Length > 15)
                {
                    _senha = value.Substring(0, 15);
                }
                else
                {
                    _senha = value;
                }
            }
        }
    }
}