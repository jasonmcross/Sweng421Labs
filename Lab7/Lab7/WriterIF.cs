﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface WriterIF
    {
        Novel View(string name);

        void Edit(string name);
    }
}
