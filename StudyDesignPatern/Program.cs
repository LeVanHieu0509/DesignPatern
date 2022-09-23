using StudyDesignPatern.LinkList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    class Program
    {
        static void Main(string[] args)          
        {
            //SingletonK2Team.Instance.Demo();

            //Sử dụng singleton với bất cứ nơi đâu có chung một instance
            //Viết ra một lần và sài một lần cho mãi mãi
            //KHông cho constructor public
            //Muốn sử dụng class này phải thông qua một thực thể. Instance

            //Console.WriteLine("-------------------------ONG DEV------------------------------------");
            //var thread1 = new Thread(() => SingleTonPartern.GetInstance().SayHi());
            //var thread2 = new Thread(() => SingleTonPartern.GetInstance().SayHi());
            //var thread3 = new Thread(() => SingleTonPartern.GetInstance().SayHi());


            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //var thread4 = new Thread(() => OngdevSingleton.GetInstance().SaysHi());
            //var thread5 = new Thread(() => OngdevSingleton.GetInstance().SaysHi());

            //thread4.Start();
            //thread5.Start();

            //Console.WriteLine("-------------------------END ONG DEV------------------------------------");
            ////doc
            ////DocSingleTonPartern docSingleton = new DocSingleTonPartern();//error as private constructor so you cant use the keyword new
            //DocSingleTonPartern firstDocSingleton = DocSingleTonPartern.GetInstance;

            //DocSingleTonPartern SecondDocSingleton = DocSingleTonPartern.GetInstance;

            //Console.WriteLine($"The value of MyInt is :{DocSingleTonPartern.MyInt}");

            //if (firstDocSingleton.Equals(SecondDocSingleton))
            //{
            //    Console.WriteLine("The First Instance and the Second Instance are the same");
            //}
            //else
            //{
            //    Console.WriteLine("Different instance exist");
            //}
            //Console.Read();
            //Console.WriteLine("-------------------------END DOC------------------------------------");

            //DocSingletonParternQandA singletonQendA = DocSingletonParternQandA.GetInstance;
            //DocSingletonParternQandA singletonQendAP2 = DocSingletonParternQandA.GetInstance;

            //singletonQendA.SayHi();
            //singletonQendAP2.SayHi();

            var linkedList = LinkedList.GetInstance();
            linkedList.push(12);
            linkedList.push(17);
            linkedList.insertAt(50, 1);
            linkedList.removeAt(2);

            var printList = linkedList.toString();
            var indexOf = linkedList.indexOf(17);

            Console.WriteLine("List: "+printList);
            Console.WriteLine("IndexOf: " + indexOf);
            Console.WriteLine(linkedList.getElementAt(1).getData());



        }
    }
}
