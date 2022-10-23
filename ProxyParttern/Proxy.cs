using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyParttern
{
    public class Proxy : Subject
    {
        Subject subject;
        public Proxy()
        {
            subject = null;
        }
        public Proxy(Subject subject)
        {
            this.subject = subject;
        }

        public override void DoSomeWork()
        {
            Console.WriteLine("Hello Some Do");

            if(subject == null)
            {
                subject = new ConcreteSubject();
            }
            subject.DoSomeWork();
        }
    }
}
