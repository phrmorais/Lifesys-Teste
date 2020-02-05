using Lifesys.application.Forms.Empresa;
using Lifesys.application.Forms.Fornecedor;
using Lifesys.Infrastructure.Context;
using Lifesys.Services.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lifesys.application
{
    public partial class Principal : Form
    {
        private Form _frmmenu;
        private readonly LifesysContext _context;
        public Principal()
        {
            InitializeComponent();
            _context = new LifesysContext();
        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmmenu = Application
                .OpenForms
                .Validate<Empresa>() ?? new Empresa();
            _frmmenu.Open();
        }
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_context.Empresas.Any())
            {
                _frmmenu = Application
                    .OpenForms
                    .Validate<Fornecedor>() ?? new Fornecedor();
                _frmmenu.Open();
            }
            else
            {
                MessageBox.Show("Para cadastro de fornecedores, você deve primeiro cadastrar uma empresa.",
                    "Cadastre uma Empresa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

    }
}
