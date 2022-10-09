﻿/**
 * Jason Cross and Dominick Carlucci
 * Character.cs class
 * Due Date: 10/9/22 11:59 p.m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Character : NovelIttyBitsIF
    {
        public char ch;              
        
        public Character(char c)
        {
            ch = c;
        }

        public Character()
        {

        }
        
        public void Save()
        {
            Console.WriteLine("Saving!");
        }

        public void Retrieve()
        {
            Console.WriteLine("Retrieving!");
        }

        public void View()
        {
            Console.Write(ch);
        }

        public void Edit()
        {
            Console.WriteLine("Editing!");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting!");
        }
    }
}