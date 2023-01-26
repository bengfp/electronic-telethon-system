using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ETSClassLibrary
{
    class Donations : CollectionBase
    {
        public void add(Donation don)
        {
            List.Add(don);
        }

        public Donation this[int index]
        {
            get { return (Donation)List[index]; }
            set { List[index] = value; }
        }
    }
}
