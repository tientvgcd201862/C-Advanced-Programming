﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2
{
    internal class Rectangle : Object
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public override string ToString()
        {
            return $"({TopLeft},{BottomRight})";
        }
        public bool IsContainsPoint(Point point)
        {
            bool IsCheckX = TopLeft.X <= point.X && point.X <= BottomRight.X;
            bool IsCheckY = TopLeft.Y >= point.Y && point.Y >= BottomRight.Y;
            return IsCheckX && IsCheckY;
        }
    }
}
