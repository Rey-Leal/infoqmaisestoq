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
    public partial class FrmAssinaturas : Form
    {
        public string diretor, supervisor, outros;

        public FrmAssinaturas()
        {
            InitializeComponent();
        }

        private void FrmAssinaturas_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> assinaturas = new List<string>();
                assinaturas = Controle.BuscaAssinaturas();
                txtDiretor.Text = assinaturas[0];
                txtSupervisor.Text = assinaturas[1];
                txtOutros.Text = assinaturas[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparCampos()
        {
            txtDiretor.Clear();
            txtSupervisor.Clear();
            txtOutros.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!((txtDiretor.Text.Equals("")) && (txtSupervisor.Text.Equals("")) && (txtOutros.Text.Equals(""))))
            {
                try
                {
                    diretor = txtDiretor.Text;
                    supervisor = txtSupervisor.Text;
                    outros = txtOutros.Text;
                    string salva = Controle.SalvaAssinaturas(diretor, supervisor, outros);
                    MessageBox.Show(salva, "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todas assinaturas", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void FrmAssinaturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmAssinaturas");
        }
    }
}
