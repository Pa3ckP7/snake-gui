﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_gui
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Circle(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public Circle() 
        {
            X = 0;
            Y = 0;
        }
    }
}