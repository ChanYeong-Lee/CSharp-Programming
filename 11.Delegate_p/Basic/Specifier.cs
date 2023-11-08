namespace _11.Delegate_p.Basic
{
    internal class Specifier
    {

        public delegate int Compare(int left, int right);
        public static void Sort(int[] array, Compare comparer)
        {
            // 정렬 알고르짐 Bubble Sort
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    else if (comparer(array[i], array[j]) == 0)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
        }
        public static int AscendingOrder(int left, int right)
        {
            if (left > right)
                return 1;
            else if (left < right)
                return -1;
            else
                return 0;
        }

        public static int DecendingOrder(int left, int right)
        {
            if (left > right)
                return -1;
            else if (left < right)
                return 1;
            else
                return 0;
        }

        public static int AbsoluteOrder(int left, int right)
        {
            if (Math.Abs(left) > Math.Abs(right))
                return 1;
            else if (Math.Abs(left) < Math.Abs(right))
                return -1;
            else
                return 0;
        }

        public static void Test1()
        {
            int[] array = { 3, 1, -2, 2, -1, -5, 5, -5, 9, -8, -7, 4 };
            Sort(array, AbsoluteOrder);
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        public delegate int Equal<T>(Item a, T b);

        public static int SameName(Item a, string b)
        {
            if (a.name == b)
                return 1;
            else return 0;
        }

        public static int SameLevel(Item a, int b)
        {
            if (a.level == b)
                return 1;
            else return 0;
        }

        public static int SameWeight(Item a, int b)
        {
            if (a.weight == b)
                return 1;
            else return 0;
        }

        public static int Find<T>(Item[] items, T t, Equal<T> equal)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (equal(items[i], t) == 1)
                    return i;
            }
            return -1;
        }

        public class Item
        {
            public string name;
            public int level;
            public int weight;
            public Item(string name, int level, int weight)
            {
                this.name = name;
                this.level = level;
                this.weight = weight;
            }
        }

        public static void Test2()
        {
            Item[] items = new Item[3];
            items[0] = new Item("potion", 1, 20);
            items[1] = new Item("sword", 2, 30);
            items[2] = new Item("bicycle", 3, 50);

            int index = Find(items, "bicycle", SameName);
            Console.WriteLine(index);
        }
    }
}
