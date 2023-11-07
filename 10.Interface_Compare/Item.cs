using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interface_Compare
{
    public class Item : IComparable<Item>
    {
        public string name;

        public Item(string name)
        {
            this.name = name;
        }

        int IComparable<Item>.CompareTo(Item? other)
        {
            return name.CompareTo(other.name);

            return 0;
        }
    }

   

}
