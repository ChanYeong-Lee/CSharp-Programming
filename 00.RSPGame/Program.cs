using System;
namespace _00.RSPGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game= new Game();
            while(true)
            {
                game.ShowInfo();
                game.GameStart();
                Console.Clear();
                game.CheckWinner();
                game.CheckGame();
                if (game.check == false)
                    break;
            } 
        }
    }




}