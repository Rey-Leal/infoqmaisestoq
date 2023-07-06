using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoQmaisEstoq
{
    public class BoEnderecos
    {
        //construtores
        public BoEnderecos(string rua, string numero, string bairro, string complemento, string cidade, string estado, string cep)
        {           
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

        public BoEnderecos()
        {
        }

        //atributos
        private string _rua, _numero, _bairro, _complemento, _cidade, _estado, _cep;        

        //propriedades

        public string Rua
        {
            get { return _rua; }
            set
            {
                if (value.Length > 30)
                {
                    _rua = value.Substring(0, 30);
                }
                else
                {
                    _rua = value;
                }
            }
        }

        public string Numero
        {
            get { return _numero; }
            set
            {
                if (value.Length > 5)
                {
                    _numero = value.Substring(0, 5);
                }
                else
                {
                    _numero = value;
                }
            }
        }

        public string Bairro
        {
            get { return _bairro; }
            set
            {
                if (value.Length > 20)
                {
                    _bairro = value.Substring(0, 20);
                }
                else
                {
                    _bairro = value;
                }
            }
        }

        public string Complemento
        {
            get { return _complemento; }
            set
            {
                if (value.Length > 15)
                {
                    _complemento = value.Substring(0, 15);
                }
                else
                {
                    _complemento = value;
                }
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set
            {
                if (value.Length > 30)
                {
                    _cidade = value.Substring(0, 30);
                }
                else
                {
                    _cidade = value;
                }
            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (value.Length > 2)
                {
                    _estado = value.Substring(0, 2);
                }
                else
                {
                    _estado = value;
                }
            }
        }

        public string Cep
        {
            get { return _cep; }
            set
            {
                if (value.Length > 9)
                {
                    _cep = value.Substring(0, 9);
                }
                else
                {
                    _cep = value;
                }
            }
        }        
    }
}