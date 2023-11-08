using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 우선순위 큐 생성
        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
        AA a = new AA("a", 3);
        AA b = new AA("b", 4);
        AA c = new AA("c", 1);  
        AA d = new AA("d", 2);      

        // 요소 추가
        priorityQueue.Enqueue(a.value);
        priorityQueue.Enqueue(b.value);
        priorityQueue.Enqueue(c.value);
        priorityQueue.Enqueue(d.value);

        // 우선순위 큐에서 요소 꺼내기
        while (priorityQueue.Count > 0)
        {
            int item = priorityQueue.Dequeue();
            switch(item)
            {
                case 1:
                    Console.WriteLine(); break;
                case 2:
                    Console.WriteLine("d"); break;
                case 3:
                    Console.WriteLine("a"); break;
                case 4:
                    Console.WriteLine("b"); break;
            }
        }
    }
}

public class AA
{
    public int value;
    public string name;
    public AA(string name, int value) 
    { 
        this.name = name;   
        this.value = value; 
    }
}

// PriorityQueue 클래스 정의
public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> list = new List<T>();

    public int Count => list.Count;

    public void Enqueue(T value)
    {
        list.Add(value);
        int currentIndex = list.Count - 1;

        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;
            if (list[currentIndex].CompareTo(list[parentIndex]) >= 0)
            {
                break;
            }

            // 부모와 자식 노드의 값을 교환
            T temp = list[currentIndex];
            list[currentIndex] = list[parentIndex];
            list[parentIndex] = temp;

            currentIndex = parentIndex;
        }
    }

    public T Dequeue()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T frontItem = list[0];
        int lastIndex = list.Count - 1;
        list[0] = list[lastIndex];
        list.RemoveAt(lastIndex);

        int currentIndex = 0;
        while (true)
        {
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;
            int smallestChildIndex = currentIndex;

            if (leftChildIndex < list.Count && list[leftChildIndex].CompareTo(list[smallestChildIndex]) < 0)
            {
                smallestChildIndex = leftChildIndex;
            }

            if (rightChildIndex < list.Count && list[rightChildIndex].CompareTo(list[smallestChildIndex]) < 0)
            {
                smallestChildIndex = rightChildIndex;
            }

            if (smallestChildIndex == currentIndex)
            {
                break;
            }

            // 부모와 자식 노드의 값을 교환
            T temp = list[currentIndex];
            list[currentIndex] = list[smallestChildIndex];
            list[smallestChildIndex] = temp;

            currentIndex = smallestChildIndex;
        }

        return frontItem;
    }
}