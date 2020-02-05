using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Shared.Entity
{
    public class Entity
    {
        protected Entity(long id)
        {
            Id = id;
        }
        public long Id { get; private set; }
    }
}

