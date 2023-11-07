using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.VietMul
{
    internal class Game
    {
        public Player player;
        int betting;

        public void GameStart()
        {
            Console.Write("Your name?");
            string? playerName;
            do
            {
                playerName = Console.ReadLine();
            } while (playerName == null);
            player = new Player(playerName, 10000);
        }
        public void GetCard(int num)
        {
            Random rndSuitValue = new Random();
            int suitValue = rndSuitValue.Next(1, 5);
            Random rndValue = new Random();
            int value = rndValue.Next(1,  14);
            switch (suitValue)
            {
                case 1:
                    player.DrawCard("spade", value,num );
                    break;
                case 2:   
                    player.DrawCard("heart", value, num);
                    break; 
                case 3:    
                    player.DrawCard("diamond", value, num);
                    break; 
                case 4:    
                    player.DrawCard("clover", value, num);
                    break;
                default:
                    break;
            }
        }

        public void Betting() 
        {
            while (true)
            {
                int bettingV = IntInput();
                if (bettingV < 1000)
                {
                    Console.WriteLine("You must bet at least 1000 Won");
                    continue;
                }
                else if (bettingV > player.GetMoney())
                {
                    Console.WriteLine("Not Enough Money");
                    continue;
                }
                else
                {
                    this.betting = bettingV;
                    return;
                }
            }
        }
        public int IntInput()
        {
            int number = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("정수를 입력하세요: ");
                string input = Console.ReadLine();

                try
                {
                    // 사용자 입력을 정수로 변환
                    number = int.Parse(input);
                    isValidInput = true; // 올바른 입력이면 루프 종료
                }
                catch (FormatException)
                {
                    Console.WriteLine("올바른 정수 형식이 아닙니다. 다시 시도하세요.");
                }
            }
            return number;
        }
        public void CheckWinner()
        {
            int bigger = player.GetCardValue(0) > player.GetCardValue(2) ? player.GetCardValue(0) : player.GetCardValue(2);
            int smaller;
            if (bigger== player.GetCardValue(0))
            {
                smaller = player.GetCardValue(2);
            }
            else
            {
                smaller = player.GetCardValue(0);
            }

            if (smaller <player.GetCardValue(1)&&player.GetCardValue(1)<bigger)
            {
                Console.WriteLine("You win! You earn " + betting * 2);
                player.EarnMoney(betting* 2);
            }
            else
            {
                Console.WriteLine("You Lose... You loss " + betting );
                player.LossMoney(betting);
            }
        }
        public void ShowCard(int num)
        {
            player.ShowCard(num);
        }

        public bool CheckGame()
        {
            if (player.GetMoney() >= 30000)
            {
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (player.GetMoney() <=1000)
            {
                Console.WriteLine("Dealer Win!");
                return true;
            }
            else 
                return false;

        }
    }
}
