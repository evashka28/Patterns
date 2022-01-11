using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    class Adapter : ISensor
    {
        private ISensor sensor;

        public Adapter(ISensor sensor)
        {
            this.sensor = sensor;
        }

        public double getTemperature()
        {  
            double value = sensor.getTemperature();
            Console.WriteLine(value);
            return (double)(value - 32) / 2 * 1.1;
        }
    }
}
