using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEFORTRPG
{
    internal class ItemUseCommand : Command
    {
        public ItemUseCommand()
        {
            priority = 4;
        }
        public override void Execute()
        {
            Console.WriteLine("아이템 사용!");
        }
    }
}
