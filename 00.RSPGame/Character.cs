using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.RSPGame
{
    public abstract class Character
    {
        public string name;
        public int score;
        public int rspValue;
        public Character()
        {
            this.name="name";
            this.score = 0;
            this.rspValue = 0;
        }

        public void Win()
        {
            Console.WriteLine("{0}이 이겼습니다.", name);
            Console.WriteLine("승점이 1점 올라갑니다.");
            score++;
        }
        public virtual void Reset()
        {
            this.score = 0;
            this.rspValue = 0;
        }
        public abstract void SelectRSP();
    }
}
