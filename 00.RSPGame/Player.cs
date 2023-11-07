using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.RSPGame
{
    public class Player : Character
    {
        public int foul;
        public Player()
        {
            this.name = "플레이어";
        }
        public void Foul()
        {
            Console.Clear();
            Console.WriteLine("잘못 입력했습니다.");
            Console.WriteLine("파울이 1점 오릅니다.");
            foul++;
            //Console.ReadLine();
            if(foul==3)
            {
                Console.WriteLine("파울이 3점이 되어 승점 1점이 감소합니다.");
                if(score>0)
                {
                    score--;
                }
                foul = 0;
            }
        }
        public override void SelectRSP()
        {
            while (true)
            {
                string input = Input();
                if (input == "1" || input == "2")
                {
                    rspValue = int.Parse(input);
                    return;
                }
                else if (input == "3")
                {
                    rspValue = int.Parse(input);
                    return;
                }
                else
                {
                    Foul();
                    continue;
                }
            }
        }
        public string Input()
        {
            string input;
            Console.WriteLine("1. 가위 2. 바위 3. 보");
            Console.WriteLine("하나를 선택해주세요.");
            input = Console.ReadLine();
            return input;    
        }
        public override void Reset()
        {
            base.Reset();
            foul = 0;
        }
    }
}
