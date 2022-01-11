using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrunkDriver : TransportService
    {
        public double DegreeOfIntoxication { get; set; }

        public DrunkDriver(string name, double doi) :
        base(name)
        {
            DegreeOfIntoxication = doi;
        }

        public override double CostTransportation(double distance)
        {
            return distance * DegreeOfIntoxication;
        }
        public override string ToString()
        {
            string s = String.Format("Пьяница {0}, незабываемая экстремальная доставка с степенью опьянения {1}",
            Name, DegreeOfIntoxication);
            return s;
        }
    }
}
