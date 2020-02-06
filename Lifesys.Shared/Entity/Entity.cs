using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Shared.Entity
{
    public abstract class Entity
    {
        public long Id { get; set; }

        public abstract void Validar();
    }
}

