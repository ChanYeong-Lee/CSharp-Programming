using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _12.Event_t
{
    internal class HPBar
    {
        public void ShowHPBar(int currentHp,int maxHp)
        {
            Console.WriteLine("체력: {0}/{1}", currentHp, maxHp);
        }   
    }
}
