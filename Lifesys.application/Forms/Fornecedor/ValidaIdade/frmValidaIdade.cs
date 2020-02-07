using Lifesys.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifesys.application.Forms.Fornecedor.ValidaIdade
{
    public partial class frmValidaIdade : Form
    {
        public bool IdadeValida { get; private set; } = false;

        public frmValidaIdade()
        {
            InitializeComponent();
            EditData.Value = DateTime.Now;
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (EditData.Checked)
            {
                IdadeValida = EditData.Value.MaiorIdade();
            }
            this.Close();
        }
    }
}
