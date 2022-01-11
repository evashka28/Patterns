using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression val = new ArithmeticProgression(2, 50, 2);
            val.TemplateMethod();
            Progression val1 = new GeometricProgression(2, 50, 2);
            val1.TemplateMethod();
        }
    }
}
