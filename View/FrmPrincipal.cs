using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace infoQmaisEstoq
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conecta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Sair()
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente sair?", "infoQ+Estoq", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogon frmLogon = new FrmLogon();
            frmLogon.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmCadastroPessoas"))
            {
                FrmCadastroPessoas frmCadastroPessoas = new FrmCadastroPessoas();
                frmCadastroPessoas.MdiParent = this;
                Controle.AbriuForm("frmCadastroPessoas");
                frmCadastroPessoas.Show();
            }
            else
            {
                MessageBox.Show("Tela de cadastros já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmListagemIndividual"))
            {
                FrmListagemIndividual frmListagemIndividual = new FrmListagemIndividual();
                frmListagemIndividual.MdiParent = this;
                Controle.AbriuForm("frmListagemIndividual");
                frmListagemIndividual.Show();
            }
            else
            {
                MessageBox.Show("Tela de Listagem Individual já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmListagemTodos"))
            {
                FrmListagemTodos frmListagemTodos = new FrmListagemTodos();
                frmListagemTodos.MdiParent = this;
                Controle.AbriuForm("frmListagemTodos");
                frmListagemTodos.Show();
            }
            else
            {
                MessageBox.Show("Tela de Listagem Geral já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listaPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controle.AbreRelatorio("RptPessoas", "");
        }

        private void listaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controle.AbreRelatorio("RptIndividual", "");
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmCadastroVendas"))
            {
                FrmCadastroVendas frmCadastroVendas = new FrmCadastroVendas();
                frmCadastroVendas.MdiParent = this;
                Controle.AbriuForm("frmCadastroVendas");
                frmCadastroVendas.Show();
            }
            else
            {
                MessageBox.Show("Tela de Cadastro de Vendas já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vendasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmListagemVendas"))
            {
                FrmVizualizaVendas frmVizualizaVendas = new FrmVizualizaVendas();
                frmVizualizaVendas.MdiParent = this;
                Controle.AbriuForm("frmListagemVendas");
                frmVizualizaVendas.Show();
            }
            else
            {
                MessageBox.Show("Tela de Vizualização de Vendas já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void assinaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Controle.FormsAbertos("frmAssinaturas"))
            {
                FrmAssinaturas frmAssinaturas = new FrmAssinaturas();
                frmAssinaturas.MdiParent = this;
                Controle.AbriuForm("frmAssinaturas");
                frmAssinaturas.Show();
            }
            else
            {
                MessageBox.Show("Tela de Assinaturas já está em execução.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
