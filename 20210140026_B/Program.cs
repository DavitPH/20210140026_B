using System;

namespace Bubble_Sort
{
    class program
    {
        private int[] a = new int[20];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukan Elemen Array");
            Console.WriteLine("--------------------");

            for (int i = 0; i <n; i++)
            {
                Console.Write("<" + (i+1)+ "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
