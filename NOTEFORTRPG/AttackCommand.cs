using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class AttackCommand : Command
    {
        Character target;
        Attack attack;
        public AttackCommand() { priority = 3; }

        public void SetTarget(Character target)
        {
            this.target = target;
        }
        public override void Execute()
        {
            attack.DoAttack();
        }
    }
}
