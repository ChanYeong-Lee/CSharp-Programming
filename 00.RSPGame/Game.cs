using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.RSPGame
{
    public class Game
    {
        public Player player = new Player();
        public Computer computer = new Computer();
        public bool check = true;
        public void GameStart()
        {
            player.SelectRSP();
            computer.SelectRSP();
        }

        public void ShowInfo()
        {
            Console.WriteLine("플레이어 승점 : {0}", player.score);
            Console.WriteLine("컴퓨터 승점 : {0}", computer.score);
            Console.WriteLine("플레이어 파울 : {0}", player.foul);
        }

        public void CheckWinner()
        { 
            //1.가위 2.바위 3.보
            switch(player.rspValue)
            {
                case 1: 
                    switch(computer.rspValue)
                    {
                        case 1:
                            Console.WriteLine("비겼습니다.");
                            break;
                        case 2: 
                            computer.score++;
                            Console.WriteLine("컴퓨터가 이겼습니다.");
                            break;
                        case 3:
                            Console.WriteLine("플레이어가 이겼습니다.");
                            player.score++;
                            break;
                    }
                    break;
                case 2:
                    switch (computer.rspValue)
                    {
                        case 1: 
                            Console.WriteLine("플레이어가 이겼습니다.");
                            player.score++;
                            break;
                        case 2:
                            break;
                        case 3:
                            Console.WriteLine("컴퓨터가 이겼습니다.");
                            computer.score++;
                            break;
                    }
                    break;
                case 3:
                    switch (computer.rspValue)
                    {
                        case 1:
                            Console.WriteLine("컴퓨터가 이겼습니다.");
                            computer.score++;
                            break;
                        case 2:
                            Console.WriteLine("플레이어가 이겼습니다.");
                            player.score++;
                            break;
                        case 3:
                            break;
                    }
                    break;
            }
        }
        public void CheckGame()
        {
            if (player.score == 3 || computer.score == 3)
            {
                if (player.score == 3)
                    Console.WriteLine("축하합니다! 플레이어가 이겼습니다.");
                else
                    Console.WriteLine("아쉽군요. 컴퓨터가 이겼습니다.");

                while (true)
                {
                    Console.WriteLine("게임을 다시 시작하시겠습니까? (Y/N)");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "Y":
                        case "y":
                        case "ㅛ":
                            Reset();
                            check = true;
                            return;
                        case "N":
                        case "n":
                        case "ㅜ":
                            check = false;
                            return;
                        default:
                            Console.Clear();
                            continue;
                    }
                }
            }
        }
        public void Reset()
        {
            player.Reset();
            computer.Reset();
        }
        public void GameOver() { }
    }
}
