namespace infoQmaisEstoq
{
    partial class FrmListagemTodos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemTodos));
            this.gbxNivel = new System.Windows.Forms.GroupBox();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.rbtFuncionario = new System.Windows.Forms.RadioButton();
            this.rbtSupervisor = new System.Windows.Forms.RadioButton();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxListagem = new System.Windows.Forms.GroupBox();
            this.dgvListagem = new System.Windows.Forms.DataGridView();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxNivel.SuspendLayout();
            this.gbxListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxNivel
            // 
            this.gbxNivel.Controls.Add(this.rbtTodos);
            this.gbxNivel.Controls.Add(this.rbtFuncionario);
            this.gbxNivel.Controls.Add(this.rbtSupervisor);
            this.gbxNivel.Controls.Add(this.rbtCliente);
            this.gbxNivel.Location = new System.Drawing.Point(12, 12);
            this.gbxNivel.Name = "gbxNivel";
            this.gbxNivel.Size = new System.Drawing.Size(297, 44);
            this.gbxNivel.TabIndex = 0;
            this.gbxNivel.TabStop = false;
            this.gbxNivel.Text = "Nível do Usuário";
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Location = new System.Drawing.Point(6, 21);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtTodos.TabIndex = 3;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // rbtFuncionario
            // 
            this.rbtFuncionario.AutoSize = true;
            this.rbtFuncionario.Location = new System.Drawing.Point(129, 21);
            this.rbtFuncionario.Name = "rbtFuncionario";
            this.rbtFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rbtFuncionario.TabIndex = 2;
            this.rbtFuncionario.Text = "Funcionário";
            this.rbtFuncionario.UseVisualStyleBackColor = true;
            this.rbtFuncionario.CheckedChanged += new System.EventHandler(this.rbtFuncionario_CheckedChanged);
            // 
            // rbtSupervisor
            // 
            this.rbtSupervisor.AutoSize = true;
            this.rbtSupervisor.Location = new System.Drawing.Point(215, 21);
            this.rbtSupervisor.Name = "rbtSupervisor";
            this.rbtSupervisor.Size = new System.Drawing.Size(75, 17);
            this.rbtSupervisor.TabIndex = 1;
            this.rbtSupervisor.Text = "Supervisor";
            this.rbtSupervisor.UseVisualStyleBackColor = true;
            this.rbtSupervisor.CheckedChanged += new System.EventHandler(this.rbtMedico_CheckedChanged);
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Location = new System.Drawing.Point(67, 21);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtCliente.TabIndex = 0;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            this.rbtCliente.CheckedChanged += new System.EventHandler(this.rbtCliente_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(745, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbxListagem
            // 
            this.gbxListagem.Controls.Add(this.dgvListagem);
            this.gbxListagem.Location = new System.Drawing.Point(12, 63);
            this.gbxListagem.Name = "gbxListagem";
            this.gbxListagem.Size = new System.Drawing.Size(727, 389);
            this.gbxListagem.TabIndex = 3;
            this.gbxListagem.TabStop = false;
            this.gbxListagem.Text = "Listagem";
            // 
            // dgvListagem
            // 
            this.dgvListagem.AllowUserToAddRows = false;
            this.dgvListagem.AllowUserToDeleteRows = false;
            this.dgvListagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nivel,
            this.nome,
            this.logon});
            this.dgvListagem.Location = new System.Drawing.Point(6, 17);
            this.dgvListagem.Name = "dgvListagem";
            this.dgvListagem.ReadOnly = true;
            this.dgvListagem.RowHeadersWidth = 5;
            this.dgvListagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListagem.Size = new System.Drawing.Size(709, 363);
            this.dgvListagem.TabIndex = 0;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Width = 58;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 60;
            // 
            // logon
            // 
            this.logon.HeaderText = "Logon";
            this.logon.Name = "logon";
            this.logon.ReadOnly = true;
            this.logon.Width = 62;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(746, 80);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 62);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmListagemTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(876, 461);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbxListagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbxNivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListagemTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Todas Pessoas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListagemTodos_FormClosed);
            this.Load += new System.EventHandler(this.FrmListagemTodos_Load);
            this.gbxNivel.ResumeLayout(false);
            this.gbxNivel.PerformLayout();
            this.gbxListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNivel;
        private System.Windows.Forms.RadioButton rbtTodos;
        private System.Windows.Forms.RadioButton rbtFuncionario;
        private System.Windows.Forms.RadioButton rbtSupervisor;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbxListagem;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvListagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn logon;
        private System.Windows.Forms.Button btnImprimir;
    }
}