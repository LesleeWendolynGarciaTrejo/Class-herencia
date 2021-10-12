using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Punto3D : Punto
    {
        private double a;

        public double A
        {
            get
            {
                return A;
            }
            set
            {
                a = value;
            }
        }
        public Punto3D() : base()
        {
            a = 0;
        }
        public Punto3D(double x, double A) : base(x)
        {
            this.a = A;
        }
        public override string ToString()
        {
            return base.ToString() + "A=" + a;
        }
    }
