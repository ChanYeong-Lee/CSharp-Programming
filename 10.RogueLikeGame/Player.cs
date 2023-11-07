using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Player
    {
        public string name;
        public Player()
        {
            this.name = "Player";
        }

        public void Enter(Dungeon dungeon)
        {
            dungeon.Enter();
        }
        public void Exit(Dungeon dungeon) 
        {
            dungeon.Exit();
        }

        public void Open(IOpenable openable)
        {
            openable.Open();
        }

        public void Lock(ILockable lockable) 
        { 
            lockable.Lock();
        }
        public void Unlock(ILockable lockable)
        {
            lockable.Unlock();
        }
        public void GetOn(IRidable ridable)
        {
            ridable.GetOn();
        }
        public void GetOff(IRidable ridable)
        {
            ridable.GetOff();
        }

    }
}
