using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAiMM.Generators
{
    class Triangle
    {
        List<Double> values = null;
        Double a = 0,
            b = 0;

        public Triangle(List<Double> _values, Double _a, Double _b)
        {
            values = _values;
            a = _a;
            b = _b;
        }

        public List<Double> GetNewList()
        {
            List<double> rsq = new List<double>(); 
            Random rnd = new Random();
            for (int i = 0; i <= values.Count - 1; i++)
            {
                double R1 = values[rnd.Next(values.Count - 1)];
                double R2 = values[rnd.Next(values.Count - 1)];
                rsq.Add(a + (b - a) * Math.Max(R1, R2));
            }
            return rsq;
        }
    }
}
