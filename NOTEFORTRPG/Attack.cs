using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class Attack
    {
        Character attacker;
        Character target;
        public Attack(Character attacker, Character target)
        {
            this.attacker = attacker;
            this.target = target;
        }

        public void DoAttack()
        {
            Console.WriteLine("{0}이 공격합니다.", attacker);
            Console.WriteLine("{0}이 공격받습니다.", target);
            target.hp -= attacker.damage;
        }
    }
}
