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

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elemental Array yang Telah Tersusun");
            Console.WriteLine("-----------------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            for(int i = 1; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            program myList = new program();
            myList.read();
            myList.BubbleSortArray();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
