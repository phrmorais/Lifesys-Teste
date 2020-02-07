namespace Lifesys.application.Forms.Fornecedor
{
    partial class frmFornecedor
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
            this.EditTipoInscricao = new System.Windows.Forms.ComboBox();
            this.EditNome = new System.Windows.Forms.TextBox();
            this.EditNumDoc = new System.Windows.Forms.TextBox();
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
            this.GridFornecedor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.EditEmpresa = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // EditTipoInscricao
            // 
            this.EditTipoInscricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditTipoInscricao.FormattingEnabled = true;
            this.EditTipoInscricao.Location = new System.Drawing.Point(501, 81);
            this.EditTipoInscricao.Name = "EditTipoInscricao";
            this.EditTipoInscricao.Size = new System.Drawing.Size(126, 24);
            this.EditTipoInscricao.TabIndex = 3;
            // 
            // EditNome
            // 
            this.EditNome.Location = new System.Drawing.Point(180, 81);
            this.EditNome.Name = "EditNome";
            this.EditNome.Size = new System.Drawing.Size(315, 22);
            this.EditNome.TabIndex = 2;
            // 
            // EditNumDoc
            // 
            this.EditNumDoc.Location = new System.Drawing.Point(15, 81);
            this.EditNumDoc.Name = "EditNumDoc";
            this.EditNumDoc.Size = new System.Drawing.Size(159, 22);
            this.EditNumDoc.TabIndex = 1;
            this.EditNumDoc.Leave += new System.EventHandler(this.EditNumDoc_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Fantasia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TipoInscricao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NumDoc:";
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
            this.panel2.Size = new System.Drawing.Size(709, 53);
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
            this.LbPesquisa.Size = new System.Drawing.Size(153, 17);
            this.LbPesquisa.TabIndex = 6;
            this.LbPesquisa.Text = "Pesquisa por NumDoc:";
            // 
            // EditPesquisa
            // 
            this.EditPesquisa.Location = new System.Drawing.Point(339, 23);
            this.EditPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.EditPesquisa.Name = "EditPesquisa";
            this.EditPesquisa.Size = new System.Drawing.Size(366, 22);
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
            this.panel1.Controls.Add(this.GridFornecedor);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 261);
            this.panel1.TabIndex = 38;
            // 
            // GridFornecedor
            // 
            this.GridFornecedor.AllowUserToAddRows = false;
            this.GridFornecedor.AllowUserToDeleteRows = false;
            this.GridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Numero,
            this.Nome});
            this.GridFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFornecedor.Location = new System.Drawing.Point(0, 0);
            this.GridFornecedor.Name = "GridFornecedor";
            this.GridFornecedor.ReadOnly = true;
            this.GridFornecedor.RowHeadersVisible = false;
            this.GridFornecedor.RowHeadersWidth = 51;
            this.GridFornecedor.RowTemplate.Height = 24;
            this.GridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFornecedor.Size = new System.Drawing.Size(711, 261);
            this.GridFornecedor.TabIndex = 0;
            this.GridFornecedor.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridFornecedor_ColumnHeaderMouseClick);
            this.GridFornecedor.SelectionChanged += new System.EventHandler(this.GridFornecedor_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Empresa:";
            // 
            // EditEmpresa
            // 
            this.EditEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditEmpresa.FormattingEnabled = true;
            this.EditEmpresa.Location = new System.Drawing.Point(15, 24);
            this.EditEmpresa.Name = "EditEmpresa";
            this.EditEmpresa.Size = new System.Drawing.Size(299, 24);
            this.EditEmpresa.TabIndex = 41;
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
            // Numero
            // 
            this.Numero.DataPropertyName = "Documento";
            this.Numero.HeaderText = "Doc. Número";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditNumDoc);
            this.Controls.Add(this.EditNome);
            this.Controls.Add(this.EditTipoInscricao);
            this.KeyPreview = true;
            this.Name = "frmFornecedor";
            this.Text = "Fornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditTipoInscricao;
        private System.Windows.Forms.TextBox EditNome;
        private System.Windows.Forms.TextBox EditNumDoc;
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
        private System.Windows.Forms.DataGridView GridFornecedor;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EditEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}