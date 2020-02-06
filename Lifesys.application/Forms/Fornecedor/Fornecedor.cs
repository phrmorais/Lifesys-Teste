using Lifesys.Domain.Listed;
using Lifesys.Domain.ObjectValues;
using Lifesys.Services.Extensions;
using Lifesys.Shared.Interface;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lifesys.application.Forms.Fornecedor
{
    public partial class Fornecedor : Form, IBase
    {
        public Fornecedor()
        {
            InitializeComponent();
            EditTipoInscricao.DisplayMember = "_value";
            EditTipoInscricao.ValueMember = "_id";

            EditTipoInscricao.DataSource = Enum.GetNames(typeof(TipoInscricao)).Select(u => new
            {
                _id = (int)Enum.Parse(typeof(TipoInscricao), u),
                _value = u
            }).ToList();
        }

        private void EditNumDoc_Leave(object sender, EventArgs e)
        {
            EditNumDoc.MaskCnpjCpf();
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
            var documento = new Documento(EditNumDoc.Text);
            //Verificar se é inclusão ou alteração no numero do documento
            var frm = new ValidaIdade.ValidaIdade();
            frm.ShowDialog();
            if (!frm.IdadeValida)
            {
                MessageBox.Show("O Cadastro não pode ser realizado.\nA data de nascimento informada é menor de 18 anos!", "Menor de idade Informado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            EditNumDoc.Text = "";
            EditRazaoSocial.Text = "";
            EditTipoInscricao.SelectedIndex = 0;
        }


    }
}
