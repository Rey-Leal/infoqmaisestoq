namespace infoQmaisEstoq
{
    partial class FrmListagemIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemIndividual));
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtQuemIndicou = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.mskCpfPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxEndereco.SuspendLayout();
            this.gbxDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(12, 23);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(386, 21);
            this.cbxNome.TabIndex = 0;
            this.cbxNome.SelectedValueChanged += new System.EventHandler(this.cbxNome_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma pessoa";
            // 
            // gbxEndereco
            // 
            this.gbxEndereco.Controls.Add(this.txtEstado);
            this.gbxEndereco.Controls.Add(this.txtComplemento);
            this.gbxEndereco.Controls.Add(this.txtNumero);
            this.gbxEndereco.Controls.Add(this.txtQuemIndicou);
            this.gbxEndereco.Controls.Add(this.mskCep);
            this.gbxEndereco.Controls.Add(this.label19);
            this.gbxEndereco.Controls.Add(this.txtCidade);
            this.gbxEndereco.Controls.Add(this.label18);
            this.gbxEndereco.Controls.Add(this.label17);
            this.gbxEndereco.Controls.Add(this.label16);
            this.gbxEndereco.Controls.Add(this.label15);
            this.gbxEndereco.Controls.Add(this.txtBairro);
            this.gbxEndereco.Controls.Add(this.txtRua);
            this.gbxEndereco.Controls.Add(this.label14);
            this.gbxEndereco.Controls.Add(this.label13);
            this.gbxEndereco.Controls.Add(this.label12);
            this.gbxEndereco.Location = new System.Drawing.Point(8, 220);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(859, 117);
            this.gbxEndereco.TabIndex = 5;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereço";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(400, 80);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(106, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(512, 36);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(116, 20);
            this.txtComplemento.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(400, 36);
            this.txtNumero.Mask = "00000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(106, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtQuemIndicou
            // 
            this.txtQuemIndicou.Location = new System.Drawing.Point(633, 80);
            this.txtQuemIndicou.Name = "txtQuemIndicou";
            this.txtQuemIndicou.ReadOnly = true;
            this.txtQuemIndicou.Size = new System.Drawing.Size(220, 20);
            this.txtQuemIndicou.TabIndex = 7;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(512, 81);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.ReadOnly = true;
            this.mskCep.Size = new System.Drawing.Size(115, 20);
            this.mskCep.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(637, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Quem Indicou";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 80);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(383, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(512, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "CEP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Estado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Cidade";
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
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(219, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(7, 37);
            this.txtRua.Name = "txtRua";
            this.txtRua.ReadOnly = true;
            this.txtRua.Size = new System.Drawing.Size(383, 20);
            this.txtRua.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(637, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Bairro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Número";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(762, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data Cadastro";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Location = new System.Drawing.Point(765, 23);
            this.dtpDataCadastro.Mask = "00/00/0000";
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.ReadOnly = true;
            this.dtpDataCadastro.Size = new System.Drawing.Size(99, 20);
            this.dtpDataCadastro.TabIndex = 3;
            this.dtpDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.txtEstadoCivil);
            this.gbxDadosPessoais.Controls.Add(this.txtNome);
            this.gbxDadosPessoais.Controls.Add(this.label21);
            this.gbxDadosPessoais.Controls.Add(this.txtEmail);
            this.gbxDadosPessoais.Controls.Add(this.label11);
            this.gbxDadosPessoais.Controls.Add(this.mskCelular);
            this.gbxDadosPessoais.Controls.Add(this.label10);
            this.gbxDadosPessoais.Controls.Add(this.mskTelefone);
            this.gbxDadosPessoais.Controls.Add(this.label9);
            this.gbxDadosPessoais.Controls.Add(this.mskDataNascimento);
            this.gbxDadosPessoais.Controls.Add(this.label7);
            this.gbxDadosPessoais.Controls.Add(this.txtConvenio);
            this.gbxDadosPessoais.Controls.Add(this.label6);
            this.gbxDadosPessoais.Controls.Add(this.label5);
            this.gbxDadosPessoais.Controls.Add(this.txtProfissao);
            this.gbxDadosPessoais.Controls.Add(this.label4);
            this.gbxDadosPessoais.Controls.Add(this.mskCpf);
            this.gbxDadosPessoais.Controls.Add(this.txtRg);
            this.gbxDadosPessoais.Controls.Add(this.label3);
            this.gbxDadosPessoais.Controls.Add(this.label2);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(8, 50);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(859, 164);
            this.gbxDadosPessoais.TabIndex = 4;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(397, 82);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.ReadOnly = true;
            this.txtEstadoCivil.Size = new System.Drawing.Size(230, 20);
            this.txtEstadoCivil.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(384, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(383, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 105);
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
            this.mskCelular.ReadOnly = true;
            this.mskCelular.Size = new System.Drawing.Size(115, 20);
            this.mskCelular.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 105);
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
            this.mskTelefone.ReadOnly = true;
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
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(636, 121);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.ReadOnly = true;
            this.mskDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.mskDataNascimento.TabIndex = 9;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de Nascimento";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(633, 82);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.ReadOnly = true;
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
            this.txtProfissao.ReadOnly = true;
            this.txtProfissao.Size = new System.Drawing.Size(384, 20);
            this.txtProfissao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 66);
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
            this.mskCpf.ReadOnly = true;
            this.mskCpf.Size = new System.Drawing.Size(230, 20);
            this.mskCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(633, 37);
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(219, 20);
            this.txtRg.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Digite um CPF";
            // 
            // mskCpfPesquisa
            // 
            this.mskCpfPesquisa.Location = new System.Drawing.Point(405, 23);
            this.mskCpfPesquisa.Mask = "000.000.000-00";
            this.mskCpfPesquisa.Name = "mskCpfPesquisa";
            this.mskCpfPesquisa.Size = new System.Drawing.Size(230, 20);
            this.mskCpfPesquisa.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(641, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(749, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(8, 343);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 62);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(133, 342);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 62);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmListagemIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(876, 414);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mskCpfPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.gbxEndereco);
            this.Controls.Add(this.gbxDadosPessoais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListagemIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Individual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListagemIndividual_FormClosed);
            this.Load += new System.EventHandler(this.FrmListagemIndividual_Load);
            this.gbxEndereco.ResumeLayout(false);
            this.gbxEndereco.PerformLayout();
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.TextBox txtQuemIndicou;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox dtpDataCadastro;
        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskCpfPesquisa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}