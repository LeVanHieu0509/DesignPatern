using IIteratorParttern.DemoFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    internal class Program
    {
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
            //// For Science
            //ISubjects subjects = new Science();
            //IIterator iterator = subjects.CreateIterator();
            //Console.WriteLine("\nScience subjects :" + iterator);
            //Print(iterator);

            //// For Arts
            //subjects = new Arts();
            //iterator = subjects.CreateIterator();
            //Console.WriteLine("\nArts subjects :");
            //Print(iterator);
            //Console.ReadLine();
            //DemoForLVM();
            
            Random random = new Random();
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine("insert into KHACHHANG(MaCB, SBDi, SBDen, GioDi, GioDen)\r\n\r\n    values({0}, '{1}', '{2}', '{3}', '{4}')", i, randomTINHTHANH(), randomTINHTHANH2(), randomGIODI(),randomGIODEN());
                i++;
            }



        }
    


        public static void addData()
        {
            
                
        }

        public static string randomTINHTHANH()
        {
            Random res = new Random();
            String[] tinhThanh = new String[] { "CANTHO", "DANANG", "PHUQUOC","LONGTHANH", "THANHHOA" };
            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < tinhThanh.Length; i++)
            {

                // Selecting a index randomly
                int x = res.Next(4);

                // Appending the character at the 
                // index to the random string.
                ran = tinhThanh[x];
            }
            return ran;
        }

        public static string randomTINHTHANH2()
        {
            Random res1 = new Random();
            String[] tinhThanh1 = new String[] { "HCM", "HN", "VINH", "NHATRANG", "DALAT" };
            // Initializing the empty string
            String ran1 = "";

            for (int i = 0; i < tinhThanh1.Length; i++)
            {

                // Selecting a index randomly
                int x = res1.Next(4);

                // Appending the character at the 
                // index to the random string.
                ran1 = tinhThanh1[x];
            }
            return ran1;
        }

        public static string randomGIODI()
        {
            Random res1 = new Random();
            String[] tinhThanh1 = new String[] { "12:20", "13:30", "13:20", "14:15", "15:35" };
            // Initializing the empty string
            String ran1 = "";

            for (int i = 0; i < tinhThanh1.Length; i++)
            {

                // Selecting a index randomly
                int x = res1.Next(4);

                // Appending the character at the 
                // index to the random string.
                ran1 = tinhThanh1[x];
            }
            return ran1;
        }
        public static string randomGIODEN()
        {
            Random res1 = new Random();
            String[] tinhThanh1 = new String[] { "14:20", "15:30", "16:20", "15:15", "16:35" };
            // Initializing the empty string
            String ran1 = "";

            for (int i = 0; i < tinhThanh1.Length; i++)
            {

                // Selecting a index randomly
                int x = res1.Next(4);

                // Appending the character at the 
                // index to the random string.
                ran1 = tinhThanh1[x];
            }
            return ran1;
        }

    }

}
