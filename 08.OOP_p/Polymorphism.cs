using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._OOP
{
    /****************************************************************
	 * 다형성 (Polymorphism)
	 * 
	 * 부모클래스의 함수를 자식클래스에서 재정의하여 자식클래스의 서로 다른 반응을 구현
	 ****************************************************************/

    // <다형성>
    // 하이딩(hiding)			: 부모클래스의 함수를 자식클래스에서 같은 이름, 매개변수로 재정의하여 자식클래스가 우선되도록 함
    // 오버라이딩(overriding)	: 부모클래스의 가상함수를 자식클래스에서 override를 통해 재정의, 부모함수 대신 자식함수을 사용

    public class Monster
    {
        public string name;

        public Monster()
        {
            name = "몬스터";
        }

        public void Move()
        {
            Console.WriteLine("{0}이 움직입니다.", name);
        }

        public void Encounter()
        {
            Console.WriteLine("{0}가 영웅을 마주칩니다.", name);
        }

        public virtual void Hit()    // 가상함수(virtual) : 자식에서 재정의할 경우 부모의 함수가 대체됨
        {
            Console.WriteLine("{0}가 데미지를 받습니다.", name);
        }
    }

    public class Dragon : Monster
    {
        public Dragon()
        {
            name = "드래곤";
        }

        // 하이딩
        public void Move()              // 부모클래스의 함수와 동일한 함수를 정의
        {
            Console.WriteLine("{0}이 날아서 움직입니다.", name);
        }

        public new void Encounter()     // 하이딩의 경우 new 키워드 사용 권장(없어도 동작하나 의도했다는 것을 명확하게 함)
        {
            Console.WriteLine("{0}이 울부짖습니다.", name);
        }

        // 오버라이딩
        public override void Hit()
        {
            base.Hit();                 // base : 부모클래스의 this를 자식클래스에서 가져옴
            Console.WriteLine("{0}이 분노합니다", name);
        }
    }

    public class Hero
    {
        public void Battle(Monster monster)
        {
            Console.WriteLine("영웅이 {0}와 전투를 시작합니다.");
            monster.Encounter();
        }

        public void Attack(Monster monster)
        {
            Console.WriteLine("영웅이 {0}을 공격합니다.", monster.name);
            monster.Hit();
        }
    }

    public static class Polymorphism
    {
        public static void Test()
        {
            Monster monster = new Monster();
            Dragon dragon = new Dragon();

            // 다형성 : 같은 이름의 함수를 호출하여도 각각의 다른 반응을 진행함
            monster.Move();                 // Monster의 Move 호출
            dragon.Move();					// Dragon의 Move 호출

            Hero hero = new Hero();
            // 자식클래스에 동일한 이름의 함수가 있다하더라도 부모클래스에 담은 경우 부모클래스의 함수가 호출
            hero.Battle(monster);           // Monster의 Encounter 호출

            // virtual 함수를 재정의하여 구현한 경우 부모클래스에 담은 경우에도 자식클래스에서 재정의한 함수가 호출
            hero.Attack(dragon);            // Dragon의 Hit 호출
        }
    }
}