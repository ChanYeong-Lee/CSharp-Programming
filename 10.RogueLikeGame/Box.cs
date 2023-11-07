using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_t
{
    internal class Box :IOpenable, ILockable
    {
        bool locked = false;
        Item item=null;
        public Box(bool locked)
        {
            this.locked = locked;
        }
        public Box(bool locked, Item item)
        {
            this.locked = locked;
            this.item = item;
        }
        public void Open()
        {
            if (!locked)
            {
                Console.WriteLine("상자를 엽니다.");
                Console.WriteLine(item.GetName() + "을 얻었습니다.");
            }
            else
                Console.WriteLine("상자가 잠겨있습니다.");
        }
        public void Close()
        {
            Console.WriteLine("상자를 닫습니다.");
        }
        public void Lock()
        {
            locked = true;
            Console.WriteLine("상자를 잠굽니다.");
        }
        public void Unlock()
        {
            locked = false;
            Console.WriteLine("상자의 잠금을 해제합니다.");
        }
    }
}
