namespace Lifesys.application.Forms.Empresa
{
    partial class frmEmpresa
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
            this.EditUf = new System.Windows.Forms.ComboBox();
            this.EditNomeFantasia = new System.Windows.Forms.TextBox();
            this.EditCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.LbPesquisa = new System.Windows.Forms.Label();
            this.EditPesquisa = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridEmpresa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUf
            // 
            this.EditUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditUf.FormattingEnabled = true;
            this.EditUf.Location = new System.Drawing.Point(501, 29);
            this.EditUf.Name = "EditUf";
            this.EditUf.Size = new System.Drawing.Size(55, 24);
            this.EditUf.TabIndex = 3;
            // 
            // EditNomeFantasia
            // 
            this.EditNomeFantasia.Location = new System.Drawing.Point(180, 29);
            this.EditNomeFantasia.Name = "EditNomeFantasia";
            this.EditNomeFantasia.Size = new System.Drawing.Size(315, 22);
            this.EditNomeFantasia.TabIndex = 2;
            // 
            // EditCnpj
            // 
            this.EditCnpj.Location = new System.Drawing.Point(15, 29);
            this.EditCnpj.Name = "EditCnpj";
            this.EditCnpj.Size = new System.Drawing.Size(159, 22);
            this.EditCnpj.TabIndex = 1;
            this.EditCnpj.Leave += new System.EventHandler(this.EditCnpj_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Fantasia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNPJ:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtnExcluir);
            this.panel2.Controls.Add(this.BtnLimpar);
            this.panel2.Controls.Add(this.BtnIncluir);
            this.panel2.Controls.Add(this.BtnAlterar);
            this.panel2.Controls.Add(this.LbPesquisa);
            this.panel2.Controls.Add(this.EditPesquisa);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Location = new System.Drawing.Point(13, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 53);
            this.panel2.TabIndex = 37;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(225, 12);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 28);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(225, 12);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 28);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(123, 11);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(100, 28);
            this.BtnIncluir.TabIndex = 8;
            this.BtnIncluir.Text = "I&ncluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(15, 11);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(100, 28);
            this.BtnAlterar.TabIndex = 7;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // LbPesquisa
            // 
            this.LbPesquisa.AutoSize = true;
            this.LbPesquisa.Location = new System.Drawing.Point(339, 4);
            this.LbPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPesquisa.Name = "LbPesquisa";
            this.LbPesquisa.Size = new System.Drawing.Size(134, 17);
            this.LbPesquisa.TabIndex = 6;
            this.LbPesquisa.Text = "Pesquisa por CNPJ:";
            // 
            // EditPesquisa
            // 
            this.EditPesquisa.Location = new System.Drawing.Point(339, 23);
            this.EditPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.EditPesquisa.Name = "EditPesquisa";
            this.EditPesquisa.Size = new System.Drawing.Size(204, 22);
            this.EditPesquisa.TabIndex = 5;
            this.EditPesquisa.TextChanged += new System.EventHandler(this.EditPesquisa_TextChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(123, 11);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancela&r";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(15, 11);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 28);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.GridEmpresa);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 318);
            this.panel1.TabIndex = 38;
            // 
            // GridEmpresa
            // 
            this.GridEmpresa.AllowUserToAddRows = false;
            this.GridEmpresa.AllowUserToDeleteRows = false;
            this.GridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CNPJ,
            this.NomeFantasia,
            this.Uf});
            this.GridEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmpresa.Location = new System.Drawing.Point(0, 0);
            this.GridEmpresa.Name = "GridEmpresa";
            this.GridEmpresa.ReadOnly = true;
            this.GridEmpresa.RowHeadersVisible = false;
            this.GridEmpresa.RowHeadersWidth = 51;
            this.GridEmpresa.RowTemplate.Height = 24;
            this.GridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmpresa.Size = new System.Drawing.Size(554, 318);
            this.GridEmpresa.TabIndex = 0;
            this.GridEmpresa.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpresa_ColumnHeaderMouseClick);
            this.GridEmpresa.SelectionChanged += new System.EventHandler(this.GridEmpresa_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Id";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 125;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.MinimumWidth = 6;
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 125;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.DataPropertyName = "NomeFantasia";
            this.NomeFantasia.HeaderText = "Nome Fantasia";
            this.NomeFantasia.MinimumWidth = 6;
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.ReadOnly = true;
            this.NomeFantasia.Width = 300;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Uf";
            this.Uf.HeaderText = "UF";
            this.Uf.MinimumWidth = 6;
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            this.Uf.Width = 125;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditCnpj);
            this.Controls.Add(this.EditNomeFantasia);
            this.Controls.Add(this.EditUf);
            this.KeyPreview = true;
            this.Name = "frmEmpresa";
            this.Text = "Empresa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditUf;
        private System.Windows.Forms.TextBox EditNomeFantasia;
        private System.Windows.Forms.TextBox EditCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label LbPesquisa;
        private System.Windows.Forms.TextBox EditPesquisa;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridEmpresa;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
    }
}