using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class StrategySort
    {
        public string Title { get; set; }
        public abstract void Sort(int[] array);
    }
}
