using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Horse : Vehicle
    {
        public Horse()
        {
            this.name = "Horse";
        }
        public override void GetOn()
        {
            Console.WriteLine("말에 올라탑니다");
        }

        public override void GetOff()
        {
            Console.WriteLine("말에서 내립니다.");
        }
    }
}
