using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program  
    {
       private int[] a = new int[48];
       private int n;

       public void Read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan banyak elemen pada Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 48)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 48 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------------------------------------------");

            for (int ms = 0; ms < n; ms++)
            {
                Console.Write("<" + (ms + 1) + ">");
                string s = Console.ReadLine();
                a[ms] = Int32.Parse(s);
            }
        }
        class node
        {
            public int info;
            public node next;
            public node(int i, node n)
            {
                info = i;
                next = n;
            }
        }
        class Stack
        {
            node top;
            public Stack()
            {
                top = null;
            }
            bool empty()
            {
                if (top == null)
                    return (true);
                else
                    return (false);
            }
            public void push(int element)
            {
                node fresh;
                fresh = new node(element, null);

                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + "pushend");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
