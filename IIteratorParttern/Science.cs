using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    public class Science : ISubjects
    {
        private LinkedList<string> Subject;
        public Science()
        {
            Subject = new LinkedList<string>();
            Subject.AddFirst("Math");
            Subject.AddFirst("Physical");
            Subject.AddFirst("Computer Science");
        }
        public IIterator CreateIterator()
        {
            return new ScienceIterator(Subject);
        }
    }
}
