using System;

namespace DSA_Session07_SingleLinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SingleLinkedList
    {
        private Node head;
        public SingleLinkedList()
        {
            head = null;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Chao mung den voi danh sach lien ket don!");
            
            while (true)
            {
                Console.WriteLine("Vui long chon thao tac:");
                Console.WriteLine("1. Them mat xich vao cuoi danh sach");
                Console.WriteLine("2. In ra danh sach");
                Console.WriteLine("3. Xoa danh sach");
                Console.WriteLine("4. Thoat");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhap du lieu cho mat xich moi: ");
                        int data = int.Parse(Console.ReadLine());
                        list.AddLast(data);
                        break;
                    case "2":
                        list.PrintList();
                        break;
                    case "3":
                        list = new SingleLinkedList();
                        Console.WriteLine("Danh sach da duoc xoa.");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}