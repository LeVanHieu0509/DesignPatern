using IIteratorParttern.DemoFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    internal class Program
    {
        public static void Print(IIterator iterator)
        {
            while (!iterator.IsCollectionEnds())
            {
                Console.WriteLine(iterator.Next());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator Pattern Demonstration.***");
            // For Science
            ISubjects subjects = new Science();
            IIterator iterator = subjects.CreateIterator();
            Console.WriteLine("\nScience subjects :" + iterator);
            Print(iterator);

            // For Arts
            subjects = new Arts();
            iterator = subjects.CreateIterator();
            Console.WriteLine("\nArts subjects :");
            Print(iterator);
            Console.ReadLine();
            DemoForLVM();
        }
        public static void DemoForLVM()
        {
            Console.WriteLine("Vui long nhap vao n:");
            int n = Convert.ToInt32(Console.ReadLine());

            LinkedList<int> listN = new LinkedList<int>();
            for (int j = 1; j <= n; j++)
            {
                listN.AddLast(j);
            }

            //int i = 1;
            //while (i <= n)
            //{
            //    if (i % 2 == 1)
            //        Console.Write($"{i} ");
            //    i++;
            //}

            IntIterator intIterator = new IntIterator(listN);

            while (!intIterator.IsCollectionEnds())
            {
                int mIterator = intIterator.CurrentItem();
                if (mIterator % 2 == 1)
                    Console.Write($"{mIterator} ");
                intIterator.Next();
            }

            intIterator.ForEachItem(Console.WriteLine);
        }
    }

}
