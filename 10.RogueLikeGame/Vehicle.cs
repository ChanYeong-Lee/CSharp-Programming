using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal abstract class Vehicle : IRidable
    {
        protected string name;
        public abstract void GetOn();
        public abstract void GetOff();
       

    }
}
