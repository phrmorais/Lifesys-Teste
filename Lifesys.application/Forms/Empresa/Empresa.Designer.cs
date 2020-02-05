namespace Lifesys.application.Forms.Empresa
{
    partial class Empresa
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
            this.EditUf = new System.Windows.Forms.ComboBox();
            this.EditRazaoSocial = new System.Windows.Forms.TextBox();
            this.EditCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUf
            // 
            this.EditUf.FormattingEnabled = true;
            this.EditUf.Location = new System.Drawing.Point(501, 29);
            this.EditUf.Name = "EditUf";
            this.EditUf.Size = new System.Drawing.Size(55, 24);
            this.EditUf.TabIndex = 3;
            // 
            // EditRazaoSocial
            // 
            this.EditRazaoSocial.Location = new System.Drawing.Point(180, 29);
            this.EditRazaoSocial.Name = "EditRazaoSocial";
            this.EditRazaoSocial.Size = new System.Drawing.Size(315, 22);
            this.EditRazaoSocial.TabIndex = 2;
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
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razão Social:";
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
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Lifesys.Domain.Entity.Empresa);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditCnpj);
            this.Controls.Add(this.EditRazaoSocial);
            this.Controls.Add(this.EditUf);
            this.KeyPreview = true;
            this.Name = "Empresa";
            this.Text = "]";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Empresa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditUf;
        private System.Windows.Forms.TextBox EditRazaoSocial;
        private System.Windows.Forms.TextBox EditCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource empresaBindingSource;
    }
}