using Lifesys.Domain.Listed;
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

namespace Lifesys.application.Forms.Empresa
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
            EditUf.DisplayMember = "_value";
            EditUf.ValueMember = "_id";

            EditUf.DataSource = Enum.GetNames(typeof(Uf)).Select(u => new
            {
                _id = (int)Enum.Parse(typeof(Uf), u),
                _value = u
            }).ToList();
        }

        private void EditCnpj_Leave(object sender, EventArgs e)
        {
            EditCnpj.MaskCnpjCpf();
        }

        private void Empresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
