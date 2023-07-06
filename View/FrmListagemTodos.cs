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
    public partial class FrmListagemTodos : Form
    {
        public FrmListagemTodos()
        {
            InitializeComponent();
        }

        private void FrmListagemTodos_Load(object sender, EventArgs e)
        {
            ListarDados();
        }

        public void LimparCampos()
        {
            dgvListagem.Rows.Clear();
        }

        public void ListarDados()
        {
            try
            {
                if (rbtTodos.Checked)
                {
                    List<BoPessoas> todasPessoas = Controle.BuscaTodasPessoas();
                    PreencheCampos(todasPessoas);
                }
                if (rbtSupervisor.Checked)
                {
                    List<BoPessoas> todasPessoas = Controle.BuscaTodosSupervisores();
                    PreencheCampos(todasPessoas);
                }
                if (rbtCliente.Checked)
                {
                    List<BoPessoas> todasPessoas = Controle.BuscaTodosClientes();
                    PreencheCampos(todasPessoas);
                }
                if (rbtFuncionario.Checked)
                {
                    List<BoPessoas> todasPessoas = Controle.BuscaTodosFuncionarios();
                    PreencheCampos(todasPessoas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtTodos.Checked = true;
            }
        }

        public void PreencheCampos(List<BoPessoas> todasPessoas)
        {
            LimparCampos();
            try
            {
                for (int i = 0; i < todasPessoas.Count; i++)
                {
                    BoPessoas pessoa = todasPessoas[i];
                    dgvListagem.Rows.Add(pessoa.Nivel, pessoa.Nome, pessoa.Logon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmListagemTodos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmListagemTodos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTodos.Checked == true)
            {
                ListarDados();
            }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliente.Checked == true)
            {
                ListarDados();
            }
        }

        private void rbtMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSupervisor.Checked == true)
            {
                ListarDados();
            }
        }

        private void rbtFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFuncionario.Checked == true)
            {
                ListarDados();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string parametro = "";
            //    if (rbtTodos.Checked)
            //    {
            //        parametro = "";
            //    }                
            //    if (rbtMedico.Checked)
            //    {
            //        parametro = "1";
            //    }               
            //    if (rbtFuncionario.Checked)
            //    {
            //        parametro = "2";
            //    }
            //    if (rbtCliente.Checked)
            //    {
            //        parametro = "3";
            //    }
            //    Controle.AbreRelatorio("RptPessoas", parametro);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    rbtTodos.Checked = true;
            //}
        }
    }
}
