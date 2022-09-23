using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    class DocSingletonParternQandA
    {
        //private static DocSingletonParternQandA instance;
        //private DocSingletonParternQandA()
        //{
        //}
        //public static DocSingletonParternQandA Instance
        //{
        //    get 
        //    {
        //        if (instance==null)
        //        {
        //            instance = new DocSingletonParternQandA();              
        //        }
        //        return instance;
        //    }
        //}

        //use double check locking
        private static volatile DocSingletonParternQandA Instance;
        private static object lockObject = new Object();
        public int index;

        public DocSingletonParternQandA(int index)
        {
            this.index = index;
        }
        public static DocSingletonParternQandA GetInstance
        {
            get 
            {
                if (Instance==null)
                {
                    lock (lockObject)
                        if(Instance == null)
                        {
                            var random = new Random();
                            Instance = new DocSingletonParternQandA(random.Next(1,4));
                        }
                }
                return Instance; 
            }

        }
        public void SayHi()
        {
            Console.WriteLine("Hieu dep trai qua di ma " + index);
        }
    }
}
