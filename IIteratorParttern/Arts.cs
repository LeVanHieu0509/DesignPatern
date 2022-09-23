using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    public class Arts : ISubjects
    {
        private string[] Subjects;

        public Arts()
        {
            Subjects = new string[] { "English","Math","History"};
        }
        public IIterator CreateIterator()
        {
            return new ArtsIterator(Subjects);
        }
    }
}
