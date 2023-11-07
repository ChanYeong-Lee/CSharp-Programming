using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Dungeon : IEnterable
    {
        public Door door;
        public Dungeon(bool lockable) 
        {
            door = new Door(lockable);
        }
        public void Enter()
        {
            door.Open();
            if (!door.locked)
            {
                Console.WriteLine("던전 맵에 진입합니다.");
            }
        }
        public void Exit()
        {
            Console.WriteLine("던전에서 나갑니다.");
        }
    }
}
