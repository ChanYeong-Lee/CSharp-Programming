using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Door : IOpenable,ILockable
    {
        public bool locked = false;
        public Door(bool locked)
        {
            this.locked = locked;   
        }
        public void Open()
        {
            if (!locked)
            {
                Console.WriteLine("문을 엽니다.");
            }
            else
                Console.WriteLine("문이 잠겨있습니다.");
        }
        public void Close()
        {
            Console.WriteLine("문을 닫습니다.");
        }
        public void Lock()
        {
            locked = true;
            Console.WriteLine("문을 잠굽니다.");
        }
        public void Unlock() 
        {
            locked = false;
            Console.WriteLine("문의 잠금을 해제합니다.");
        }
    }
}
