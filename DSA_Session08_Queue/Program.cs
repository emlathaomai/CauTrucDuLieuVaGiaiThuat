using System;

namespace DSA_Session08_Queue
{
    public class MyQueue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;

        public MyQueue(int size)
        {
            elements = new int[size];
            front = -1;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("LOI: Hang doi da day (Overflow)!");
                return;
            }

            if (front == -1)
            {
                front = 0;
            }

            rear++;
            elements[rear] = item;
            Console.WriteLine($"Da them {item} vao hang doi.");
        }

        public int Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("LOI: Hang doi trong (Underflow)!");
                return -1;
            }

            int item = elements[front];
            front++;

            if (front > rear)
            {
                front = -1;
                rear = -1;
            }

            return item;
        }

        public void Peek()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Hang doi trong.");
            }
            else
            {
                Console.WriteLine($"Phan tu dau hang hien tai la: {elements[front]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHUONG TRINH MO PHONG HANG DOI ===");

            MyQueue queue = new MyQueue(3);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Peek();

            Console.WriteLine($"Da lay ra: {queue.Dequeue()}");
            Console.WriteLine($"Da lay ra: {queue.Dequeue()}");

            queue.Peek();
        }
    }
}