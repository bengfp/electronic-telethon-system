﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ETSClassLibrary
{
    class Sponsors : CollectionBase
    {
        public void add(Sponsor ss)
        {
            List.Add(ss);
        }

        public Sponsor this[int index] {
            get { return (Sponsor) List[index]; }
            set { List[index] = value;  }
        }

    }
}
