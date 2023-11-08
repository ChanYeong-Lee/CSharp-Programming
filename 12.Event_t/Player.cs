using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Event_t
{
    internal class Player
    {
        public int hp { get; private set; } = 200;
        public int maxhp { get; private set; } = 200;
        public int damage { get; private set; } = 20;
        public event Action<int,int> OnHpChanged;
        public void TakeHit(int damage)
        {
            this.hp -= damage;
            Console.WriteLine("플레이어가 공격받습니다.");
            OnHpChanged(hp,maxhp);
        }

        public void Attack(Monster target)
        {
            Console.Write("플레이어가 공격합니다.");
            target.TakeHit(damage);
        }
    }
}
