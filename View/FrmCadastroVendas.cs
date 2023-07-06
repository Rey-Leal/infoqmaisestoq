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
    public partial class FrmCadastroVendas : Form
    {
        public string cliente, funcionario;
        public int codigoDoCliente, codigoDoFuncionario;
        public string descricaoDaVenda, observacoes, produtos, dtVenda;
        public decimal valor; 

        public FrmCadastroVendas()
        {
            InitializeComponent();
        }

        private void FrmCadastroVendas_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList todosNomes = new ArrayList();
                List<BoPessoas> todosFuncionarios = new List<BoPessoas>();

                todosNomes = Controle.BuscaTodosNomes();                
                for (int i = 0; i < todosNomes.Count; i++)
                {
                    cbxCliente.Items.Add(todosNomes[i]);
                }

                todosFuncionarios = Controle.BuscaTodosFuncionarios();                
                for (int i = 0; i < todosFuncionarios.Count; i++)
                {
                    cbxFuncionario.Items.Add(todosFuncionarios[i].Nome);
                }

                todosFuncionarios.Clear(); 
                todosFuncionarios = Controle.BuscaTodosSupervisores();
                for (int i = 0; i < todosFuncionarios.Count; i++)
                {
                    cbxFuncionario.Items.Add(todosFuncionarios[i].Nome);
                }
                dtpDataCadastro.Text = Controle.DataDeAgora().ToString();
                cbxCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnImprimir.Enabled = false;
        }

        public void LimparCampos()
        {
            cbxCliente.Text = "";
            cbxFuncionario.Text = "";
            txtDescVenda.Clear();
            txtObservacoes.Clear();
            txtProdutos.Clear();
            mskValor.Clear();
            btnSalvar.Enabled = true;
        }

        private void mskValor_Leave(object sender, EventArgs e)
        {
            mskValor.Text = Controle.ConverteParaTextoMonetario(mskValor.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmCadastroVendas");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cbxCliente.Text != "") && (cbxFuncionario.Text != "") && (txtDescVenda.Text != "") && (txtProdutos.Text != "") && (dtpDataCadastro.Text != "") && (mskValor.Text != ""))
                {
                    cliente = cbxCliente.Text;
                    funcionario = cbxFuncionario.Text;
                    descricaoDaVenda = txtDescVenda.Text;
                    observacoes = txtObservacoes.Text;
                    produtos = txtProdutos.Text;
                    valor = Convert.ToDecimal(mskValor.Text);
                    dtVenda = Controle.ConverteFormatoData(dtpDataCadastro.Value.ToShortDateString());
                    BoVendas venda = new BoVendas(cliente, funcionario, dtVenda, descricaoDaVenda, observacoes, produtos, valor);
                    string salva = Controle.SalvaVenda(venda);
                    MessageBox.Show(salva, "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnImprimir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnImprimir.Focus();
                    LimparCampos(); 
                }
                else
                {
                    MessageBox.Show("Os campos marcados com '*' são de preenchimento obrigatório.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {            
            //try
            //{
            //    string parametro = Controle.BuscaConsultas();
            //    Controle.AbreRelatorio("RptConsultas", parametro);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
    }
}
