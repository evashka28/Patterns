using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class TransportService
    {
        public string Name { get; set; }
        public TransportService(string name)
        {
            Name = name;
        }
        abstract public double CostTransportation(double distance);
    }
}
