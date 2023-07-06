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
    public partial class FrmVizualizaVendas : Form
    {
        public string nome, nomeCpf, dtVenda, id;

        public FrmVizualizaVendas()
        {
            InitializeComponent();
        }

        private void FrmVizualizaConsultas_Load(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
            try
            {
                List<BoPessoas> todasPessoas = new List<BoPessoas>();
                todasPessoas = Controle.BuscaTodasPessoas();
                for (int i = 0; i < todasPessoas.Count; i++)
                {
                    cbxNome.Items.Add(todasPessoas[i].Nome + " - " + todasPessoas[i].Cpf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListagemVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmListagemVendas");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxNome.Text != "" && cbxNome.Text != null)
            {
                try
                {
                    clbDescVendas.Items.Clear();
                    nomeCpf = cbxNome.Text;
                    nome = nomeCpf.Substring(0, nomeCpf.Length - 17);
                    btnImprimir.Enabled = true;
                    List<string> consultasCliente = new List<string>();
                    consultasCliente = Controle.ListaVendasCliente(nome);
                    for (int i = 0; i < consultasCliente.Count; i++)
                    {
                        clbDescVendas.Items.Add(consultasCliente[i]);
                    }
                    if (clbDescVendas.Items.Count == 0)
                    {
                        MessageBox.Show("Sem histórico de vendas", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nome é obrigatório!", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clbDescVendas.Items.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Controle.AbreRelatorio("RptVendas", Controle.BuscaIdPeloCpf(nomeCpf.Substring(nomeCpf.Length - 14)));
        }
    }
}
