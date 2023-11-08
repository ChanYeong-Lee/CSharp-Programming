using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Event_t
{
    internal class Monster
    {
        public event Action<int,int> OnHpChanged;
        public int hp { get; private set; } = 300;
        public int maxhp { get; private set; } = 300;

        public int damage { get; private set; } = 10;
        public void TakeHit(int damage)
        {
            this.hp -= damage;
            Console.WriteLine("몬스터가 공격받습니다.");
            OnHpChanged(hp,maxhp);
        }
        public void Attack(Player target)
        {
            Console.WriteLine("몬스터가 공격합니다.");
            target.TakeHit(damage);
        }
    }
}
