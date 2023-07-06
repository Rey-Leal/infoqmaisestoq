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
    public partial class FrmCadastroPessoas : Form
    {
        public int nivel, idPessoa, idEndereco;
        public string nome, rg, cpf, telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou;
        public string dataDeNascimento, dataDeCadastro, logon, senha, dataInglesa;
        public string rua, numero, bairro, complemento, cidade, estado, cep;

        public FrmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void FrmCadastroPessoas_Load(object sender, EventArgs e)
        {
            dtpDataCadastro.Text = Controle.DataDeAgora().ToString();
            cbxEstadoCivil.SelectedIndex = 0;
            cbxComplemento.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void FrmCadastroPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controle.FechouForm("frmCadastroPessoas");
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtRg.Clear();
            mskCpf.Clear();
            txtRua.Clear();
            mskNumero.Clear();
            txtBairro.Clear();
            cbxComplemento.SelectedIndex = 0;
            txtCidade.Clear();
            cbxEstado.SelectedIndex = 0;
            mskCep.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            txtProfissao.Clear();
            txtConvenio.Clear();
            cbxEstadoCivil.SelectedIndex = 0;
            txtQuemIndicou.Clear();
            dtpDataNascimento.Text = Controle.DataDeAgora().ToShortDateString();
            txtLogon.Clear();
            mskSenha.Clear();
            rbtCliente.Checked = true;
            gbxLogon.Visible = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            try
            {
                if ((txtNome.Text != "") && (txtRg.Text != "") && (mskCpf.Text != "") && (txtRua.Text != "") && (mskNumero.Text != "") && (txtBairro.Text != "") && (txtCidade.Text != "") && (cbxEstado.Text != "") && (dtpDataNascimento.Text != "") && (dtpDataCadastro.Text != ""))
                {
                    if (rbtCliente.Checked)
                    {
                        nivel = Convert.ToInt32(Enumeracoes.NivelUsuario.Cliente); //3
                    }
                    else
                    {
                        if (rbtFuncionario.Checked)
                        {
                            nivel = Convert.ToInt32(Enumeracoes.NivelUsuario.Funcionario);  //2
                        }
                        else
                        {
                            nivel = Convert.ToInt32(Enumeracoes.NivelUsuario.Supervisor);   //1
                        }
                    }

                    nome = txtNome.Text;
                    rg = txtRg.Text;
                    cpf = mskCpf.Text;
                    telefone = mskTelefone.Text;
                    celular = mskCelular.Text;
                    email = txtEmail.Text;
                    profissao = txtProfissao.Text;
                    convenio = txtConvenio.Text;
                    estadoCivil = cbxEstadoCivil.Text;
                    quemIndicou = txtQuemIndicou.Text;
                    dataDeNascimento = Controle.ConverteFormatoData(dtpDataNascimento.Value.ToShortDateString());
                    dataDeCadastro = Controle.ConverteFormatoData(dtpDataCadastro.Value.ToShortDateString());
                    logon = txtLogon.Text;
                    senha = mskSenha.Text;

                    idEndereco = 0;
                    rua = txtRua.Text;
                    numero = mskNumero.Text;
                    bairro = txtBairro.Text;
                    complemento = cbxComplemento.Text;
                    cidade = txtCidade.Text;
                    estado = cbxEstado.Text;
                    cep = mskCep.Text;

                    bool validaCpf = Controle.ValidaCpf(cpf);

                    if (validaCpf)
                    {
                        if ((nivel < 3 && logon != "" && senha != "") || (nivel == 3))
                        {
                            //Salva endereco
                            BoEnderecos endereco = new BoEnderecos(rua, numero, bairro, complemento, cidade, estado, cep);
                            idEndereco = Controle.SalvaEndereco(endereco);
                            
                            //Salva pessoa
                            BoPessoas pessoa = new BoPessoas(nivel, nome, rg, cpf, idEndereco, telefone, celular, email, profissao, convenio, estadoCivil, quemIndicou, dataDeNascimento, dataDeCadastro, logon, senha);
                            string salva = Controle.SalvaPessoa(pessoa);
                            MessageBox.Show(salva, "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Logon e senha são campos obrigatórios, para que você possa logar no sistema.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtLogon.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O CPF digitado é inválido ou está incorreto, verifique por favor.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLogon.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Os campos marcados com '*' são de preenchimento obrigatório.", "infoQ+Estoq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
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

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = false;
            txtLogon.Clear();
            mskSenha.Clear();
        }

        private void rbtSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = true;
        }

        private void rbtFuncionário_CheckedChanged(object sender, EventArgs e)
        {
            gbxLogon.Visible = true;
        }
    }
}
