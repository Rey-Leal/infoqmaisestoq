using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoQmaisEstoq
{
    public class BoProdutos
    {
        //construtores
        public BoProdutos(string idGrupo, string descricaoDoProduto, string unidade, string observacao, decimal quantidadeMinima, bool ativo)
        {
            this.IdGrupo = idGrupo;
            this.DescricaoDoProduto = descricaoDoProduto;
            this.Unidade = unidade;
            this.Observacao = observacao;
            this.QuantidadeMinima = quantidadeMinima;
            this.Ativo = ativo;
        }

        public BoProdutos()
        {
        }

        //atributos
        private string _idGrupo, _descricaoDoProduto, _unidade, _observacao;
        private decimal _quantidadeMinima;
        private bool _ativo;

        //propriedades

        public string IdGrupo
        {
            get { return _idGrupo; }
            set
            {
                if (value.Length > 6)
                {
                    _idGrupo = value.Substring(0, 6);
                }
                else
                {
                    _idGrupo = value;
                }
            }
        }

        public string DescricaoDoProduto
        {
            get { return _descricaoDoProduto; }
            set
            {
                if (value.Length > 5)
                {
                    _descricaoDoProduto = value.Substring(0, 150);
                }
                else
                {
                    _descricaoDoProduto = value;
                }
            }
        }

        public string Unidade
        {
            get { return _unidade; }
            set
            {
                if (value.Length > 10)
                {
                    _unidade = value.Substring(0, 10);
                }
                else
                {
                    _unidade = value;
                }
            }
        }

        public string Observacao
        {
            get { return _observacao; }
            set
            {
                if (value.Length > 255)
                {
                    _observacao = value.Substring(0, 255);
                }
                else
                {
                    _observacao = value;
                }
            }
        }

        public decimal QuantidadeMinima
        {
            get { return _quantidadeMinima; }
            set
            {
                _quantidadeMinima = value;
            }
        }

        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value;
            }
        }
    }
}