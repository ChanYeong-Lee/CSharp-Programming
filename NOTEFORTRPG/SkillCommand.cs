using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class SkillCommand : Command
    {
        public Skill skill;
        public SkillCommand(Skill skill)
        {
            this.priority = skill.priority;
            this.skill = skill;
        }
        public override void Execute()
        {
            skill.Use();
        }
    }
}
