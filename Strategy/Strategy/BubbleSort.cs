using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BubbleSort : StrategySort
    {
        public BubbleSort()
        {
            Title = "Сортировка пузырьком";
        }
        public override string ToString()
        {
            return Title;
        }
        public override void Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }    
        }
    }
}
