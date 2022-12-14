using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    class OngdevSingleton
    {
        private int index;
        private static readonly object lockObject = new object();
        private static volatile OngdevSingleton uniqueInstance;

        private OngdevSingleton(int index)
        {
            this.index = index;
        }

        public static OngdevSingleton GetInstance()
        {
            //Phuc vu cho lazy loading
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();

                        uniqueInstance = new OngdevSingleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void SaysHi()
        {
            Console.WriteLine("Hello everyone, I am Ongdev number " + index);
        }
    }
}
