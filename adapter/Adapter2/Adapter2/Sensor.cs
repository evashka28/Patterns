using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    class Sensor : ISensor
    {
        Random temperature;
        public Sensor()
        {
            temperature = new Random();
        }

        public double getTemperature() 
        {
            return temperature.Next(200) - 100;
        }
    }
}
