using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.RSPGame
{
    public class Computer : Character
    {
        public Computer()
            {
            this.name = "컴퓨터";
            }
        public override void SelectRSP()
        {
            Random random = new Random();
            rspValue = random.Next(0, 3) + 1;
            switch(rspValue) 
            {
                case 1: 
                    Console.WriteLine("컴퓨터는 가위를 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터는 바위를 선택했습니다.");
                    break;
                case 3:
                    Console.WriteLine("컴퓨터는 보를 선택했습니다.");
                    break;
            }
        }
    }
}
