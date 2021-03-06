using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FordFactory : CarFactory
    {
        private FordFactory() { }

        static Lazy<FordFactory> myFordFactory = new Lazy<FordFactory>(() => new FordFactory());

        public static FordFactory MyFordFactory
        {
            get
            {
                return myFordFactory.Value;
            }
        }
        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }

        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
}
