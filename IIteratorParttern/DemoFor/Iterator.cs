using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern.DemoFor
{
    public interface Iterator
    {
        // Reset to first element
        void First();
        // Get next element
        int Next();
        // End of collection check
        bool IsCollectionEnds();
        // Retrieve Current Item
        int CurrentItem();

        void ForEachItem(Action<int> foo);
    }
}
