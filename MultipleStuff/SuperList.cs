
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        
        public struct MinMaxResult
        {
            public double Min { get; set; }
            public double Max { get; set; }

            public MinMaxResult(double min, double max)
            {
                Min = min;
                Max = max;
            }

            public override string ToString()
            {
                return $"Min: {Min}, Max: {Max}";
            }
        }
        
        public void GetMinMax1(out double min, out double max)
        {
            min = this[0];
            max = this[0];

            for (int i = 1; i < Count; i++)
            {
                if (this[i] < min) min = this[i];
                if (this[i] > max) max = this[i];
            }
        }
        
        public MinMaxResult GetMinMax2()
        {
            double min = this[0];
            double max = this[0];

            for (int i = 1; i < Count; i++)
            {
                if (this[i] < min)
                    min = this[i];
                if (this[i] > max)
                    max = this[i];
            }

            return new MinMaxResult(min, max);
        }

        public (double, double) GetMinMax3()
        {
            double min = this[0];
            double max = this[0];

            for (int i = 1; i < Count; i++)
            {
                if (this[i] < min)
                    min = this[i];
                if (this[i] > max)
                    max = this[i];
            }

            return (min, max);
        }
        
        public (double Minimo, double Maximo) GetMinMax4()
        {
            double min = this[0];
            double max = this[0];

            for (int i = 1; i < Count; i++)
            {
                if (this[i] < min)
                    min = this[i];
                if (this[i] > max)
                    max = this[i];
            }

            return (Minimo: min, Maximo: max);
        }
        

    }
}
