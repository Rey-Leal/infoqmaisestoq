using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace infoQmaisEstoq
{
    public partial class FrmListagemIndividual : Form
    {
        public FrmListagemIndividual()
        {
            InitializeComponent();
        }

        private void FrmListagemIndividual_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList todosNomes = new ArrayList();
                todosNomes = Controle.BuscaTodosNomes();
                for (int i = 0; i < todosNomes.Count; i++)
                {
                    cbxNome.Items.Add(todosNomes[i]);
                }
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmListagemIndividual_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmListagemIndividual");
        }

        public void LimparCampos()
        {
            cbxNome.Text = "";
            txtNome.Clear();
            txtRg.Clear();
            mskCpf.Clear();
            mskCpfPesquisa.Clear();            
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            txtProfissao.Clear();
            txtConvenio.Clear();
            txtEstadoCivil.Clear();
            txtQuemIndicou.Clear();
            mskDataNascimento.Clear();
            dtpDataCadastro.Clear();            

            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            mskCep.Clear();

            cbxNome.Focus();
        }

        public void PreencheCampos(BoPessoas pessoa, BoEnderecos endereco)
        {
            txtNome.Text = pessoa.Nome;
            txtRg.Text = pessoa.Rg;
            mskCpf.Text = pessoa.Cpf;
            mskCpfPesquisa.Text = pessoa.Cpf;            
            mskTelefone.Text = pessoa.Telefone;
            mskCelular.Text = pessoa.Celular;
            txtEmail.Text = pessoa.Email;
            txtProfissao.Text = pessoa.Profissao;
            txtConvenio.Text = pessoa.Convenio;
            txtEstadoCivil.Text = pessoa.EstadoCivil;
            txtQuemIndicou.Text = pessoa.QuemIndicou;
            mskDataNascimento.Text = pessoa.DataDeNascimento;
            dtpDataCadastro.Text = pessoa.DataDeCadastro;

            txtRua.Text = endereco.Rua;
            txtNumero.Text = endereco.Numero;
            txtBairro.Text = endereco.Bairro;
            txtComplemento.Text = endereco.Complemento;
            txtCidade.Text = endereco.Cidade;
            txtEstado.Text = endereco.Estado;
            mskCep.Text = endereco.Cep;
        }

        private void cbxNome_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = cbxNome.Text;
                BoPessoas pessoa = Controle.BuscaDadosPorNome(nome);
                BoEnderecos endereco = Controle.BuscaEnderecoPeloIdEndereco(pessoa.IdEndereco);
                PreencheCampos(pessoa, endereco);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCpfPesquisa.Text.Length == 14)
                {
                    string cpf = mskCpfPesquisa.Text;
                    BoPessoas pessoa = Controle.BuscaDadosPorCpf(cpf);
                    BoEnderecos endereco = Controle.BuscaEnderecoPeloIdEndereco(pessoa.IdEndereco);
                    PreencheCampos(pessoa, endereco);
                }
                else
                {
                    MessageBox.Show("Preencha o campo CPF corretamente, antes de efetuar a busca.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCpfPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //string parametro = mskCpf.Text;
            //try
            //{
            //    Controle.AbreRelatorio("RptIndividual", parametro);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }        
    }
}
