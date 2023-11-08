using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal abstract class Command
    {
        public int priority;
        public abstract void Execute();
    }
}
