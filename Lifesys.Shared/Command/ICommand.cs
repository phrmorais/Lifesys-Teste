using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Shared.Command
{
    public interface ICommand
    {
        void Validate();
    }
}
