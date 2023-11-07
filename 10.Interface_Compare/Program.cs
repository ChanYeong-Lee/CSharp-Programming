using System;

namespace _10.Interface_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[8];
            items[0] = new Item("포션");
            items[1] = new Item("망토");
            items[2] = new Item("갑옷");
            items[3] = new Item("방패");
            items[4] = new Item("검");
            items[5] = new Item("그림자 검");
            items[6] = new Item("유령무희");
            items[7] = new Item("도란의 검");

            Array.Sort(items);      // 아이템의 정렬 기준으로 정렬
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].name);
            }
        }
    }
}