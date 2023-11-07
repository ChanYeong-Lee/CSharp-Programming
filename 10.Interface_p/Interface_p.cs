using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_p
{
    internal class Interface_p
    {
        /********************************
         * 인터페이스 (Interface) 
         * 
         * 인터페이스는 멤버를 가질 수 있지만 직접 구현하지 않음, 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성요소들을 구현했다는 것을 보장함
         *********************************/
        
        // <인터페이스 정의>
        // 일반적으로 인터페이스 이름은 I로 시작하도록 네이밍

        public interface IDamagable
        {
            void TakeHit();     // 직접 구현하지 않고 정의만 진행
        }

        public interface IMovable
        {
            void TakeMove();
        }
        
        // <인터페이스 포함>
        // 상속처럼 정의한 인터페이스를 클래스 : 인터페이스이름 으로 선언 
        public class Monster : IDamagable
        {
            // 반드시 인터페이스에서 정의한 요소를 구현해야 함, 하지 않을 경우 오류
            public void TakeHit()
            {
                Console.WriteLine("몬스터가 공격을 받습니다.");
            }
        }

        public class Box : IDamagable, IMovable
        { 
            public void TakeHit()
            {
                Console.WriteLine("박스가 공격을 받아 부셔집니다.");
            }

            public void TakeMove()
            {
                Console.WriteLine("박스가 이동당합니다.");
            }
        }

        public class Key : IMovable
        {
            public void TakeMove()
            {
                Console.WriteLine("열쇠를 얻었습니다.");
            }
        }

        public class Player
        {
            public void Attack(IDamagable damagable)
            {
                Console.WriteLine("플레이어가 공격합니다.");
                damagable.TakeHit();
            }

            public void Grab(IMovable movable)
            {
                Console.WriteLine("플레이어가 물체를 잡습니다.");
                movable.TakeMove();
            }


        }

        public class InterfaceTest
        {
            public void Test1()
            {
                Player player = new Player();
                Monster monster = new Monster();
                Box box = new Box();
                Key key = new Key();

                player.Attack(monster);
                player.Attack(box);
                player.Grab(box);
                player.Grab(key);
            }
        }
    }
}
