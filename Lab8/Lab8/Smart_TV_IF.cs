﻿/**
 * Jason Cross and Dominick Carlucci
 * Smart_TV_IF.cs class
 * Due Date: 10/16/22
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public interface Smart_TV_IF : TV_IF
    {
        public object replenishTV(int budget);        
    }
}
