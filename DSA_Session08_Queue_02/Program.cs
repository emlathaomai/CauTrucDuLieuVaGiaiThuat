using System;

namespace DSA_Session08_Queue_02
{
    public class CircularQueue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;
        private int count;

        public CircularQueue(int size)
        {
            max = size;
            elements = new int[max];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(int item)
        {
            if (count == max)
            {
                Console.WriteLine($"LOI: Hang doi da day! Khong the them {item}.");
                return;
            }

            rear = (rear + 1) % max;
            elements[rear] = item;
            count++;
            Console.WriteLine($"[+] Da them: {item} (vao Index {rear})");
        }

        public int Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("LOI: Hang doi rong!");
                return -1;
            }

            int item = elements[front];
            front = (front + 1) % max;
            count--;
            Console.WriteLine($"[-] Da lay ra: {item}");
            return item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CircularQueue cq = new CircularQueue(3);

            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            cq.Dequeue();

            cq.Enqueue(40);
        }
    }
}