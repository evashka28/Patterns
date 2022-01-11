using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISensor s = new Sensor();
            Console.WriteLine(s.getTemperature());
            ISensor s2 = new Adapter(s);
            Console.WriteLine(s2.getTemperature());
        }
    }
}
