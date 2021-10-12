using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Punto2D : Punto
    {
        private double y;

        public double Y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }
        public Punto2D() : base()
        {
            Y = 0;
        }
        public Punto2D(double x, double y) : base(x)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return base.ToString() + "Y=" + Y;
        }

        