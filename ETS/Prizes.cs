using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ETSClassLibrary
{
    class Prizes: CollectionBase
    {
        public void add(Prize pr)
        {
            List.Add(pr);
        }

        public Prize this[int index]
        {
            get { return (Prize)List[index]; }
            set { List[index] = value; }
        }
    }
}
