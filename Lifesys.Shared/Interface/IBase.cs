using System.Windows.Forms;

namespace Lifesys.Shared.Interface
{
    public interface IBase
    {
        void AlternaBotoes(bool Edit);
        void LimparCampos();
        void OnKeyDown(object sender, KeyEventArgs e);
    }
}
