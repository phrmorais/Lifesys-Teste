using System.Windows.Forms;

namespace Lifesys.Shared.Interface
{
    public interface IBase
    {
        void AlternaBotoes();
        void LimparCampos();
        void OnKeyDown(object sender, KeyEventArgs e);
    }
}
