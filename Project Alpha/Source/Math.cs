using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Alpha.Source
{
    class Math
    {
        
        public Math()
        {
            
        }

        public static double Lerp(double a, double b, double t = 1) => a + (b - a) * t;
    }
}
