using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    class DocSingleTonPartern
    {
        //Cách 1:
        private static readonly DocSingleTonPartern Instance;
        private static int TotalInstance;

        private DocSingleTonPartern()
        {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit now from private constructor");

        }
        /*
            A static constructor is used for the following purpose(cho muc dich sau):
            1. To initial any static data
            2. To perform a specific(cu the) action only once
         */
        //Here is the static constructor 
        static DocSingleTonPartern()
        {
            Console.WriteLine("-Static constructor is called.");
            Instance = new DocSingleTonPartern();
            TotalInstance++;

            Console.WriteLine($"-Singleton instance is created.Number of instance: {TotalInstance}");
            Console.WriteLine("-Exit from static constructor");
        }

        //public static DocSingleTonPartern GetInstance
        //{
        //    get
        //    {
        //        return Instance;
        //    }
        //}

        //Rut gọn mã thành
        public static DocSingleTonPartern GetInstance => Instance;

        public static int MyInt = 25;
    }
}
