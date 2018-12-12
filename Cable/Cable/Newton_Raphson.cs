using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cable
{
    class Newton_Raphson
    {
        static double EPSILON = 0.001;

        #region S-X Formulation
        // An example function whose solution 
        // is determined using Bisection Method. 
        static double SX(double s, double x, double c)
        {
            return s / c - Math.Sinh(x / c);
        }

        // Derivative of the above function  
        static double derivSX(double s, double x, double c)
        {
            return (x * Math.Cosh(x / c) - s) / Math.Pow(c, 2);
        }

        // Function to find the root 
        public static double NewtonRaphsonSX(double s, double x, double c)
        {
            double r = SX(s, x, c) / derivSX(s, x, c);
            while (Math.Abs(r) >= EPSILON)
            {
                r = SX(s, x, c) / derivSX(s, x, c);
                // x(i+1) = x(i) - f(x) / f'(x)  
                c = c - r;
            }
            return c;
        }
        #endregion

        #region Y-X Formulation
        static double YX(double y, double x, double c)
        {
            return y / c - Math.Cosh(x / c);
        }

        // Derivative of the above function  
        static double derivYX(double y, double x, double c)
        {
            return (x * Math.Sinh(x / c) - y) / Math.Pow(c, 2);
        }

        // Function to find the root 
        public static double NewtonRaphsonYX(double y, double x, double c)
        {
            double r = YX(y, x, c) / derivYX(y, x, c);
            int count = 0;
            while (Math.Abs(r) >= EPSILON)
            {
                r = YX(y, x, c) / derivYX(y, x, c);
                // x(i+1) = x(i) - f(x) / f'(x)  
                c = c - r;
                if (++count > 5000)
                {
                    MessageBox.Show("(X;Y) point is not on the catenary.");
                    return 0;
                }
            }
            return c;
        }
        #endregion

        #region H-X Formulation
        static double HX(double h, double x, double c)
        {
            double ret = h / c + 1 - Math.Cosh(x / c);
            return ret;
        }

        // Derivative of the above function  
        static double derivHX(double h, double x, double c)
        {
            double ret = (x * Math.Sinh(x / c) - h) / Math.Pow(c, 2);
            return ret;
        }

        // Function to find the root 
        public static double NewtonRaphsonHX(double h, double x, double c)
        {
            double r = HX(h, x, c) / derivHX(h, x, c);
            int count = 0;
            while (Math.Abs(r) >= EPSILON)
            {
                r = HX(h, x, c) / derivHX(h, x, c);
                // x(i+1) = x(i) - f(x) / f'(x)  
                c = c - r;
                count++;
            }
            return c;
        }
        #endregion

        #region X-T Formulation
        static double TX(double y, double x, double c)
        {
            return y / c - Math.Cosh(x / c);
        }

        // Derivative of the above function  
        static double derivTX(double y, double x, double c)
        {
            return (x * Math.Sinh(x / c) - y) / Math.Pow(c, 2);
        }

        // Function to find the root 
        public static double NewtonRaphsonTX(double y, double x, double c)
        {
            double r = TX(y, x, c) / derivTX(y, x, c);
            int count = 0;
            while (Math.Abs(r) >= EPSILON)
            {
                r = TX(y, x, c) / derivTX(y, x, c);
                // x(i+1) = x(i) - f(x) / f'(x)  
                c = c - r;
                if (++count > 5000)
                {
                    MessageBox.Show("(X;Y) point is not on the catenary.");
                    return 0;
                }
            }
            return c;
        }
        #endregion
    }
}
