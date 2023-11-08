using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal abstract class Skill
    {
        public string name;
        public int cooldown;
        public int priority;

        public void Use()
        {
            Console.WriteLine(name + " " + cooldown);   
        }
    }
}
