using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    public interface IIterator
    {
        //Reset to first element
        void First();
        //Get next element
        string Next();
        //end of Collection check
        bool IsCollectionEnds();
        //Retrieve Current Item
        string CurrentItem();
    }
}
