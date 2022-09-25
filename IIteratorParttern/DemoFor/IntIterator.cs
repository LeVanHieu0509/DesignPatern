using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern.DemoFor
{
    public class IntIterator
    {
        private LinkedList<int> IntSubjects;
        private int position;

        public IntIterator(LinkedList<int> intSubjects)
        {
            this.IntSubjects = intSubjects;
            position = 0;
        }

        public int CurrentItem()
        {
            return IntSubjects.ElementAt<int>(position);
        }

        public void First()
        {
            position = 0;
        }

        public void ForEachItem(Action<int> foo)
        {
            int i = 0;
            while (i < IntSubjects.Count)
            {
                foo(IntSubjects.ElementAt<int>(i));
                i++;
            }
        }

        public bool IsCollectionEnds()
        {
            if (position >= IntSubjects.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Next()
        {
            position++;
            if (position < IntSubjects.Count)
                return IntSubjects.ElementAt<int>(position);
            return -1;
        }
    }
}
