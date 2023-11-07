using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Car : Vehicle, ILockable
    {
        bool locked = false;
        public Car(bool locked)
        {
            name = "Car";
            this.locked = locked;
        }

        public void Lock()
        {
            locked = true;
        }

        public void Unlock()
        { 
            locked = false; 
        } 
        public override void GetOn()
        {
            if (!locked)
            {
                Console.WriteLine("차에 탑승합니다.");
            }
            else 
            { 
                Console.WriteLine("차가 잠겨있습니다.");
            }
        }
        public override void GetOff()
        {
            Console.WriteLine("차에서 내립니다.");
        }
    }
}
