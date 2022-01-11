using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class TransportCompany
    {
        public string Name { get; set; }
        public TransportCompany(string n)
        {
            Name = n;
        }
        public override string ToString()
        {
            return Name;
        }
        // фабричный метод
        abstract public TransportService Create(string n, int k);
    }
}
