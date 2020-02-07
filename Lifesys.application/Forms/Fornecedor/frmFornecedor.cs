using Lifesys.Domain.Listed;
using Lifesys.Domain.ObjectValues;
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

namespace Lifesys.application.Forms.Fornecedor
{
    public partial class frmFornecedor : Form, IBase
    {
        private LifesysContext _context;
        private long Id;
        public frmFornecedor()
        {
            InitializeComponent();
            _context = new LifesysContext();
            EditEmpresa.DisplayMember = "NomeFantasia";
            EditEmpresa.ValueMember = "Id";
            EditEmpresa.DataSource = _context.Empresas.ToList();

            EditTipoInscricao.DisplayMember = "_value";
            EditTipoInscricao.ValueMember = "_id";

            EditTipoInscricao.DataSource = Enum.GetNames(typeof(TipoInscricao)).Select(u => new
            {
                _id = (int)Enum.Parse(typeof(TipoInscricao), u),
                _value = u
            }).ToList();
            AtualizaFiltro();
            AlternaBotoes(GridFornecedor.Rows.Count == 0);
        }

        private void EditNumDoc_Leave(object sender, EventArgs e)
        {
            EditNumDoc.MaskCnpjCpf();
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
                var entity = _context.Fornecedores.Find(Id);
                if (entity != null)
                {
                    _context.Fornecedores.Remove(entity);
                    _context.SaveChanges();
                }
            }
            AtualizaFiltro();
            AlternaBotoes(GridFornecedor.Rows.Count == 0);
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var documento = new Documento(EditNumDoc.Text);
            var Fornecedor = new Domain.Entity.Fornecedor(Id,
                EditNome.Text,
                (long)EditEmpresa.SelectedValue,
                documento);

            try
            {
                Fornecedor.Validar();

                if (_context.Fornecedores
                    .Include(c => c.Documento)
                    .Where(c => c.Documento.Numero == Fornecedor.Documento.Numero && c.Id != Fornecedor.Id)
                    .Any())
                    throw new Exception($"O documento já está cadastrado!\n Altere e salve novamente");

                if (documento.Tipo == Domain.Listed.TipoInscricao.Física)
                {

                    var frm = new ValidaIdade.frmValidaIdade();
                    frm.ShowDialog();
                    if (!frm.IdadeValida)
                    {
                        throw new Exception("O Cadastro não pode ser realizado.\nA data de nascimento informada é menor de 18 anos!");
                    }
                }
                var entity = _context.Fornecedores.Find(Id);
                if (entity == null)
                {
                    Fornecedor.Id = 0;
                    _context.Fornecedores.Add(Fornecedor);
                }
                else
                {
                    _context.Entry(entity).CurrentValues.SetValues(Fornecedor);
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
            GridFornecedor.Enabled = !Edit;
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
            EditNome.Text = "";
            EditTipoInscricao.SelectedIndex = 0;
        }
        public void AtualizaFiltro()
        {
            //GridFornecedor.AutoGenerateColumns = false;
            GridFornecedor.DataSource = new SortableBindingList<Domain.Entity.Fornecedor>(_context
                    .Fornecedores

                    .Where(f => f.EmpresaId == (long)EditEmpresa.SelectedValue)
                    .ToList());
            if (GridFornecedor.Rows.Count > 0)
            {
                GridFornecedor.Rows[0].Selected = true;
            }
            LbPesquisa.Text = GridFornecedor.Ordena(1);
        }
        private void GridFornecedor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LbPesquisa.Text = GridFornecedor.Ordena(e.ColumnIndex);
            GridFornecedor.Pesquisa(EditPesquisa.Text, (CurrencyManager)BindingContext[GridFornecedor.DataSource]);
        }
        private void EditPesquisa_TextChanged(object sender, EventArgs e)
        {
            GridFornecedor.Pesquisa(EditPesquisa.Text, (CurrencyManager)BindingContext[GridFornecedor.DataSource]);
        }
        private void GridFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = GridFornecedor.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var SelectedFornecedor = (Domain.Entity.Fornecedor)row.DataBoundItem;
                Id = SelectedFornecedor.Id;
                EditNumDoc.Text = SelectedFornecedor.Documento.Numero;
                EditNome.Text = SelectedFornecedor.Nome;
                EditTipoInscricao.SelectedValue = (int)SelectedFornecedor.Documento.TipoInscricao;
            }
        }


    }
}
