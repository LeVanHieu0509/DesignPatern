using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern
{
    sealed class DocSingletonParternP2
    {
        #region

        private static readonly DocSingletonParternP2 Instance = new DocSingletonParternP2();
        private static int TotalInstances;

        private DocSingletonParternP2()
        {

        }
        public static DocSingletonParternP2 getInstance
        {
            get { return Instance; }
        }
        #endregion
    }
}
