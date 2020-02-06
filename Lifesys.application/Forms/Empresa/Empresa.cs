using Lifesys.Domain.Listed;
using Lifesys.Services.Extensions;
using Lifesys.Shared.Interface;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lifesys.application.Forms.Empresa
{
    public partial class Empresa : Form, IBase
    {
        protected bool Edit;
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

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            AlternaBotoes(true);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlternaBotoes(true);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AlternaBotoes(false);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            AlternaBotoes(false);
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void AlternaBotoes(bool Edit)
        {
            BtnAlterar.Visible = !Edit;
            BtnIncluir.Visible = !Edit;
            BtnExcluir.Visible = !Edit;
        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
        public void LimparCampos()
        {
            EditCnpj.Text = "";
            EditRazaoSocial.Text = "";
            EditUf.SelectedIndex = 0;
        }

    }
}
