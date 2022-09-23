using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    public class SingleTonPartern
    {
        private static SingleTonPartern uniqueInstance ;
        private int index;
        private SingleTonPartern(int index)
        {
            this.index = index;

        }
        public static SingleTonPartern GetInstance()
        {
            if(uniqueInstance == null)
            {
                var random = new Random();
                uniqueInstance = new SingleTonPartern(random.Next(1,100));

            }
            return uniqueInstance;
        }
        public void SayHi()
        {
            Console.WriteLine("Hello everyone i have number: "+ index);
        }
    }
}
