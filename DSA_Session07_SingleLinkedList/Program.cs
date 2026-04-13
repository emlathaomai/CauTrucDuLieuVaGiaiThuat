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

        public int CountNodes()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public bool SearchNode(int target)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == target) return true;
                current = current.Next;
            }
            return false;
        }

        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }

        public void DeleteByValue(int value)
        {
            if (head == null) return;
            if (head.Data == value)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
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
                Console.WriteLine("\nVui long chon thao tac:");
                Console.WriteLine("1. Them mat xich vao cuoi danh sach");
                Console.WriteLine("2. In ra danh sach");
                Console.WriteLine("3. Xoa toan bo danh sach");
                Console.WriteLine("5. Dem so luong Node");
                Console.WriteLine("6. Tim kiem gia tri");
                Console.WriteLine("7. Xoa Node dau tien");
                Console.WriteLine("8. Xoa Node theo gia tri");
                Console.WriteLine("9. Thoat");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhap du lieu cho mat xich moi: ");
                        if (int.TryParse(Console.ReadLine(), out int data))
                        {
                            list.AddLast(data);
                        }
                        break;
                    case "2":
                        list.PrintList();
                        break;
                    case "3":
                        list = new SingleLinkedList();
                        Console.WriteLine("Danh sach da duoc xoa.");
                        break;
                    case "5":
                        Console.WriteLine($"So luong Node: {list.CountNodes()}");
                        break;
                    case "6":
                        Console.Write("Nhap gia tri can tim: ");
                        if (int.TryParse(Console.ReadLine(), out int searchTarget))
                        {
                            if (list.SearchNode(searchTarget))
                                Console.WriteLine("Tim thay.");
                            else
                                Console.WriteLine("Khong tim thay.");
                        }
                        break;
                    case "7":
                        list.DeleteFirst();
                        Console.WriteLine("Da xoa Node dau tien.");
                        break;
                    case "8":
                        Console.Write("Nhap gia tri can xoa: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteVal))
                        {
                            list.DeleteByValue(deleteVal);
                            Console.WriteLine("Da thuc hien xoa.");
                        }
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}