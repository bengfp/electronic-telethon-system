using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ETSClassLibrary
{
    class Donors : CollectionBase
    {
        public void add(Donor don)
        {
            List.Add(don);
        }

        public Donor this[int index] {
            get { return (Donor)List[index]; }
            set { List[index] = value; }
        }
    }
}
