﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class FireBall : Skill
    {
        public FireBall()
        {
            name = "FireBall";
            cooldown = 4;
            priority = 1;
        }
        public void Use()
        {
            Console.WriteLine("파이어볼!");
        }
    }
}
