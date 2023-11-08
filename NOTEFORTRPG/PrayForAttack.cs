using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class PrayForAttack : Skill
    {

        public PrayForAttack()
        {
            name = "PrayForAttack";
            cooldown = 4;
            priority = 2;
        }
        public void Use()
        {
            Console.WriteLine("공증!");
        }

    }
}
