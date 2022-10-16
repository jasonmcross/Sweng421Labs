﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_TV
{
    public class Visio_TV : TV_IF
    {
        private int price = 250;

        internal void setPrice(int price)
        {
            this.price = price;
        }

        internal int getPrice()
        {
            return this.price;
        }

        public void getInfo()
        {
            Console.WriteLine("The price is " + this.getPrice() + " and the type is " + this.getType());
        }

        internal String getType()
        {
            return this.ToString();
        }

        public Object replenishTV(int budget)
        {
            if (budget >= price)
            {
                return new Visio_TV();
            }
            else
            {
                return new TV().replenishTV(budget);
            }
        }

        internal String getBrand()
        {
            return "Visio";
        }
    }
}
