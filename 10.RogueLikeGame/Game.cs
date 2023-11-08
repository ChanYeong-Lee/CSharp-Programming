using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Game
    {
        Player player;
        Dungeon dungeon;
        BFSword bfsword;
        Box box;
        Horse horse;
        Car car;

        public void GameSetting()
        {
            player = new Player();
            dungeon = new Dungeon(true);
            bfsword = new BFSword();
            box = new Box(true, bfsword);
            horse = new Horse();
            car = new Car(true);
        }
        public void GameCommand()
        {
            while (true)
            {
                Console.Write("Command : ");
                string? command = Console.ReadLine();
                if (command == null)
                    continue;
                if (command == "Enter Dungeon")
                {
                    player.Enter(dungeon);
                }
                if (command == "Unlock Dungeon")
                {
                    player.Unlock(dungeon.door);
                }
                if (command == "Exit Dungeon")
                {
                    player.Exit(dungeon);
                }
                if (command == "Open Box")
                {
                    player.Open(box);
                }
                if (command == "Unlock Box")
                {
                    player.Unlock(box);
                }
                if (command == "Get On Horse")
                {
                    player.GetOn(horse);
                }
                if (command == "Get Off Horse")
                {
                    player.GetOff(horse);
                }
                if (command == "Get On Car")
                {
                    player.GetOn(car);
                }
                if (command == "Unlock Car")
                {
                    player.Unlock(car);
                }
                if (command == "Get Off Car")
                {
                    player.GetOff(car);
                }
                if (command == "Exit")
                {
                    break;
                }
            }
        }
    }
}
