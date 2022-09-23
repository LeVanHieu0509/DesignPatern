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
        }
    }
}
