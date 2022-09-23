using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    class SingletonK2Team
    {
        public bool isShow = false;

        public string whoAmI = "Hieu";
        
        static object obj = new Object();

        public static volatile SingletonK2Team instance;    //volatile: tránh đụng độ thread, thêm vào thì chương trình không bị lỗi

        public static SingletonK2Team Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        instance = new SingletonK2Team();
                    }
                }
               
                return instance;
            }
        }
        private SingletonK2Team()
        {

        }
        public void Demo()
        {
            Console.WriteLine("anh-hieu");
        }
        public void DemoPrint()
        {
            Console.WriteLine("anh-hieu-DemoPrint");
        }

        //Khi mà gọi tới một instance thì chỉ có một instance được tạo ra thôi
        public void Print(string s)
        {
            if (isShow)
            {
                Console.WriteLine("anh-hieu-Print");
            }

        }

    }
}
