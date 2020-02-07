using Lifesys.Domain.Listed;
using Lifesys.Infrastructure.Context;
using Lifesys.Services.Extensions;
using Lifesys.Shared.Interface;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Lifesys.application.Forms.Empresa
{
    public partial class frmEmpresa : Form, IBase
    {
        private LifesysContext _context;
        private long Id;
        public frmEmpresa()
        {
            InitializeComponent();
            _context = new LifesysContext();
            EditUf.DisplayMember = "_value";
            EditUf.ValueMember = "_id";
            EditUf.DataSource = Enum.GetNames(typeof(Uf)).Select(u => new
            {
                _id = (int)Enum.Parse(typeof(Uf), u),
                _value = u
            }).ToList();
            AtualizaFiltro();
            AlternaBotoes(GridEmpresa.Rows.Count == 0);
        }

        private void EditCnpj_Leave(object sender, EventArgs e)
        {
            EditCnpj.MaskCnpjCpf();
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Id = 0;
            LimparCampos();
            AlternaBotoes(true);
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlternaBotoes(true);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente exluir?", "Confirma exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                var entity = _context.Empresas.Find(Id);
                if (entity != null)
                {
                    _context.Empresas.Remove(entity);
                    _context.SaveChanges();
                }
            }
            AtualizaFiltro();
            LimparCampos();
            AlternaBotoes(GridEmpresa.Rows.Count == 0);
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var empresa = new Domain.Entity.Empresa(Id,
            (Uf)Enum.ToObject(typeof(Uf),
            (int)EditUf.SelectedValue),
            EditNomeFantasia.Text, EditCnpj.Text);
            try
            {
                empresa.Validar();

                if (_context.Empresas.Where(c => c.Cnpj == empresa.Cnpj && c.Id != empresa.Id).Any())
                    throw new Exception("O CNPJ já está cadastrado!\n Altere e salve novamente");

                var entity = _context.Empresas.Find(Id);
                if (entity == null)
                {
                    empresa.Id = 0;
                    _context.Empresas.Add(empresa);
                }
                else
                {
                    _context.Entry(entity).CurrentValues.SetValues(empresa);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            AlternaBotoes(false);
            AtualizaFiltro();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            AtualizaFiltro();
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
            GridEmpresa.Enabled = !Edit;
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
            EditNomeFantasia.Text = "";
            EditUf.SelectedIndex = 0;
        }
        public void AtualizaFiltro()
        {
            GridEmpresa.AutoGenerateColumns = false;
            GridEmpresa.DataSource = new SortableBindingList<Domain.Entity.Empresa>(_context.Empresas.ToList());
            if (GridEmpresa.Rows.Count > 0)
            {
                GridEmpresa.Rows[0].Selected = true;
            }
            LbPesquisa.Text = GridEmpresa.Ordena(1);
        }
        private void GridEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LbPesquisa.Text = GridEmpresa.Ordena(e.ColumnIndex);
            GridEmpresa.Pesquisa(EditPesquisa.Text, (CurrencyManager)BindingContext[GridEmpresa.DataSource]);
        }
        private void EditPesquisa_TextChanged(object sender, EventArgs e)
        {
            GridEmpresa.Pesquisa(EditPesquisa.Text, (CurrencyManager)BindingContext[GridEmpresa.DataSource]);
        }
        private void GridEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = GridEmpresa.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var SelectedEmpresa = (Domain.Entity.Empresa)row.DataBoundItem;
                Id = SelectedEmpresa.Id;
                EditCnpj.Text = SelectedEmpresa.Cnpj;
                EditNomeFantasia.Text = SelectedEmpresa.NomeFantasia;
                EditUf.SelectedValue = (int)SelectedEmpresa.Uf;
            }
        }
    }
}
