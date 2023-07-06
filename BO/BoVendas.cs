using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoQmaisEstoq
{
    class BoVendas
    {
        //construtores
        public BoVendas(string cliente, string funcionario, string dataDaVenda, string descricaoDaVenda, string observacoes, string produtos, decimal valor)
        {
            this.Cliente = cliente;
            this.Funcionario = funcionario;
            this.DataDaVenda = dataDaVenda;
            this.DescricaoDaVenda = descricaoDaVenda;
            this.Observacoes = observacoes;
            this.Produtos = produtos;
            this.Valor = valor;
        }

        //atributos
        private int _idCliente, _idFuncionario;
        private string _cliente, _funcionario;
        private string _dataDaVenda, _descricaoDaVenda, _observacoes, _produtos;
        private decimal _valor;


        //propriedades
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public int IdFuncionario
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }

        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public string Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }

        public string DataDaVenda
        {
            get { return _dataDaVenda; }
            set { _dataDaVenda = value; }
        }

        public string DescricaoDaVenda
        {
            get { return _descricaoDaVenda; }
            set
            {
                if (value.Length > 255)
                {
                    _descricaoDaVenda = value.Substring(0, 255);
                }
                else
                {
                    _descricaoDaVenda = value;
                }
            }
        }

        public string Observacoes
        {
            get { return _observacoes; }
            set
            {
                if (value.Length > 255)
                {
                    _observacoes = value.Substring(0, 255);
                }
                else
                {
                    _observacoes = value;
                }
            }
        }

        public string Produtos
        {
            get { return _produtos; }
            set
            {
                if (value.Length > 255)
                {
                    _produtos = value.Substring(0, 255);
                }
                else
                {
                    _produtos = value;
                }
            }
        }

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
            }
        }
    }
}
