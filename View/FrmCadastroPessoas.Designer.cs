namespace infoQmaisEstoq
{
    partial class FrmCadastroPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroPessoas));
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxNivel = new System.Windows.Forms.GroupBox();
            this.rbtFuncionario = new System.Windows.Forms.RadioButton();
            this.rbtSupervisor = new System.Windows.Forms.RadioButton();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtQuemIndicou = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxComplemento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gbxLogon = new System.Windows.Forms.GroupBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLogon = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.gbxDadosPessoais.SuspendLayout();
            this.gbxNivel.SuspendLayout();
            this.gbxEndereco.SuspendLayout();
            this.gbxLogon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gbxDadosPessoais.Controls.Add(this.txtEmail);
            this.gbxDadosPessoais.Controls.Add(this.label11);
            this.gbxDadosPessoais.Controls.Add(this.mskCelular);
            this.gbxDadosPessoais.Controls.Add(this.label10);
            this.gbxDadosPessoais.Controls.Add(this.mskTelefone);
            this.gbxDadosPessoais.Controls.Add(this.label9);
            this.gbxDadosPessoais.Controls.Add(this.label7);
            this.gbxDadosPessoais.Controls.Add(this.txtConvenio);
            this.gbxDadosPessoais.Controls.Add(this.label6);
            this.gbxDadosPessoais.Controls.Add(this.cbxEstadoCivil);
            this.gbxDadosPessoais.Controls.Add(this.label5);
            this.gbxDadosPessoais.Controls.Add(this.txtProfissao);
            this.gbxDadosPessoais.Controls.Add(this.label4);
            this.gbxDadosPessoais.Controls.Add(this.mskCpf);
            this.gbxDadosPessoais.Controls.Add(this.txtRg);
            this.gbxDadosPessoais.Controls.Add(this.label3);
            this.gbxDadosPessoais.Controls.Add(this.label2);
            this.gbxDadosPessoais.Controls.Add(this.txtNome);
            this.gbxDadosPessoais.Controls.Add(this.label1);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(12, 62);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(859, 164);
            this.gbxDadosPessoais.TabIndex = 1;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados Pessoais";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(634, 121);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.dtpDataNascimento.TabIndex = 20;
            this.dtpDataNascimento.Value = new System.DateTime(2010, 3, 18, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(512, 121);
            this.mskCelular.Mask = "(99) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(116, 20);
            this.mskCelular.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Celular";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(396, 121);
            this.mskTelefone.Mask = "(99) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(110, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(633, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de Nascimento*";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(633, 82);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(219, 20);
            this.txtConvenio.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Convênio";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo",
            "Divorciado",
            "Outros"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(397, 81);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(230, 21);
            this.cbxEstadoCivil.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado Civil";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(6, 81);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(384, 20);
            this.txtProfissao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profisão";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(397, 37);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(230, 20);
            this.mskCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(633, 37);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(219, 20);
            this.txtRg.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(633, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(397, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(766, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data Cadastro*";
            // 
            // gbxNivel
            // 
            this.gbxNivel.Controls.Add(this.rbtFuncionario);
            this.gbxNivel.Controls.Add(this.rbtSupervisor);
            this.gbxNivel.Controls.Add(this.rbtCliente);
            this.gbxNivel.Location = new System.Drawing.Point(12, 12);
            this.gbxNivel.Name = "gbxNivel";
            this.gbxNivel.Size = new System.Drawing.Size(249, 44);
            this.gbxNivel.TabIndex = 0;
            this.gbxNivel.TabStop = false;
            this.gbxNivel.Text = "Nível do Usuário";
            // 
            // rbtFuncionario
            // 
            this.rbtFuncionario.AutoSize = true;
            this.rbtFuncionario.Location = new System.Drawing.Point(78, 15);
            this.rbtFuncionario.Name = "rbtFuncionario";
            this.rbtFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rbtFuncionario.TabIndex = 2;
            this.rbtFuncionario.Text = "Funcionário";
            this.rbtFuncionario.UseVisualStyleBackColor = true;
            this.rbtFuncionario.CheckedChanged += new System.EventHandler(this.rbtFuncionário_CheckedChanged);
            // 
            // rbtSupervisor
            // 
            this.rbtSupervisor.AutoSize = true;
            this.rbtSupervisor.Location = new System.Drawing.Point(166, 15);
            this.rbtSupervisor.Name = "rbtSupervisor";
            this.rbtSupervisor.Size = new System.Drawing.Size(75, 17);
            this.rbtSupervisor.TabIndex = 1;
            this.rbtSupervisor.Text = "Supervisor";
            this.rbtSupervisor.UseVisualStyleBackColor = true;
            this.rbtSupervisor.CheckedChanged += new System.EventHandler(this.rbtSupervisor_CheckedChanged);
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Checked = true;
            this.rbtCliente.Location = new System.Drawing.Point(7, 15);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtCliente.TabIndex = 0;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            this.rbtCliente.CheckedChanged += new System.EventHandler(this.rbtCliente_CheckedChanged);
            // 
            // gbxEndereco
            // 
            this.gbxEndereco.Controls.Add(this.mskNumero);
            this.gbxEndereco.Controls.Add(this.txtQuemIndicou);
            this.gbxEndereco.Controls.Add(this.mskCep);
            this.gbxEndereco.Controls.Add(this.label19);
            this.gbxEndereco.Controls.Add(this.cbxEstado);
            this.gbxEndereco.Controls.Add(this.txtCidade);
            this.gbxEndereco.Controls.Add(this.label18);
            this.gbxEndereco.Controls.Add(this.label17);
            this.gbxEndereco.Controls.Add(this.label16);
            this.gbxEndereco.Controls.Add(this.cbxComplemento);
            this.gbxEndereco.Controls.Add(this.label15);
            this.gbxEndereco.Controls.Add(this.txtBairro);
            this.gbxEndereco.Controls.Add(this.txtRua);
            this.gbxEndereco.Controls.Add(this.label14);
            this.gbxEndereco.Controls.Add(this.label13);
            this.gbxEndereco.Controls.Add(this.label12);
            this.gbxEndereco.Location = new System.Drawing.Point(12, 233);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(859, 117);
            this.gbxEndereco.TabIndex = 2;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereço";
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(400, 36);
            this.mskNumero.Mask = "00000";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(106, 20);
            this.mskNumero.TabIndex = 1;
            // 
            // txtQuemIndicou
            // 
            this.txtQuemIndicou.Location = new System.Drawing.Point(636, 78);
            this.txtQuemIndicou.Name = "txtQuemIndicou";
            this.txtQuemIndicou.Size = new System.Drawing.Size(216, 20);
            this.txtQuemIndicou.TabIndex = 7;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(515, 81);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(112, 20);
            this.mskCep.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(633, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Quem Indicou";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "BA",
            "DF",
            "ES",
            "GO",
            "MG",
            "PR",
            "RG",
            "RJ",
            "RS",
            "SC",
            "SP"});
            this.cbxEstado.Location = new System.Drawing.Point(400, 81);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(106, 21);
            this.cbxEstado.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 80);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(383, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(512, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "CEP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(397, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Estado*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(8, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Cidade*";
            // 
            // cbxComplemento
            // 
            this.cbxComplemento.FormattingEnabled = true;
            this.cbxComplemento.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Fundos",
            "Área Rural",
            "Outros"});
            this.cbxComplemento.Location = new System.Drawing.Point(512, 34);
            this.cbxComplemento.Name = "cbxComplemento";
            this.cbxComplemento.Size = new System.Drawing.Size(115, 21);
            this.cbxComplemento.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(512, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(634, 34);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(219, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(7, 37);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(383, 20);
            this.txtRua.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(633, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Bairro*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(397, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Número*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rua*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 62);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(136, 387);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 62);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(754, 427);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Purple;
            this.label20.Location = new System.Drawing.Point(12, 353);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "* Dados Obrigatórios";
            // 
            // gbxLogon
            // 
            this.gbxLogon.Controls.Add(this.mskSenha);
            this.gbxLogon.Controls.Add(this.label22);
            this.gbxLogon.Controls.Add(this.txtLogon);
            this.gbxLogon.Controls.Add(this.label21);
            this.gbxLogon.Location = new System.Drawing.Point(268, 13);
            this.gbxLogon.Name = "gbxLogon";
            this.gbxLogon.Size = new System.Drawing.Size(495, 43);
            this.gbxLogon.TabIndex = 17;
            this.gbxLogon.TabStop = false;
            this.gbxLogon.Visible = false;
            // 
            // mskSenha
            // 
            this.mskSenha.Location = new System.Drawing.Point(295, 14);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(190, 20);
            this.mskSenha.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(248, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Senha";
            // 
            // txtLogon
            // 
            this.txtLogon.Location = new System.Drawing.Point(53, 14);
            this.txtLogon.Name = "txtLogon";
            this.txtLogon.Size = new System.Drawing.Size(186, 20);
            this.txtLogon.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Logon";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(769, 28);
            this.dtpDataCadastro.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDataCadastro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(102, 20);
            this.dtpDataCadastro.TabIndex = 21;
            this.dtpDataCadastro.Value = new System.DateTime(2010, 3, 18, 0, 0, 0, 0);
            // 
            // FrmCadastroPessoas
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.gbxLogon);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxEndereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxNivel);
            this.Controls.Add(this.gbxDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastroPessoas_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadastroPessoas_Load);
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.gbxNivel.ResumeLayout(false);
            this.gbxNivel.PerformLayout();
            this.gbxEndereco.ResumeLayout(false);
            this.gbxEndereco.PerformLayout();
            this.gbxLogon.ResumeLayout(false);
            this.gbxLogon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxNivel;
        private System.Windows.Forms.RadioButton rbtFuncionario;
        private System.Windows.Forms.RadioButton rbtSupervisor;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxComplemento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtQuemIndicou;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.GroupBox gbxLogon;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLogon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
    }
}