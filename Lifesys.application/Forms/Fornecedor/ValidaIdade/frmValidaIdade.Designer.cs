namespace Lifesys.application.Forms.Fornecedor.ValidaIdade
{
    partial class frmValidaIdade
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a data de nascimento:";
            // 
            // EditData
            // 
            this.EditData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditData.Location = new System.Drawing.Point(217, 25);
            this.EditData.Name = "EditData";
            this.EditData.Size = new System.Drawing.Size(118, 22);
            this.EditData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "*O cadastro de fornecedores somente aceita maiores de 18 anos.";
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.Location = new System.Drawing.Point(345, 24);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirma.TabIndex = 3;
            this.BtnConfirma.Text = "&Confirmar";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // ValidaIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 111);
            this.Controls.Add(this.BtnConfirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditData);
            this.Controls.Add(this.label1);
            this.Name = "ValidaIdade";
            this.Text = "Valida Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EditData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirma;
    }
}