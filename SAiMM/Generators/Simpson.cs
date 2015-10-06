using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAiMM.Generators
{
    class Simpson
    {
        List<Double> values = null,
            values2;
        Double a = 0,
            b = 0;

        public Simpson(List<Double> _values, Double _a, Double _b)
        {
            values = _values;
            a = _a;
            b = _b;
            values2 = new List<double>();
            foreach (double tmp in values)
            {
                values2.Add(a / 2 + (b / 2 - a / 2) * tmp);
            }
        }

        public List<Double> GetNewList()
        {
            List<double> rsq = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i <= values.Count - 1; i++)
            {
                double R1 = values2[rnd.Next(values2.Count - 1)];
                double R2 = values2[rnd.Next(values2.Count - 1)];
                rsq.Add(R1 + R2);
            }
            return rsq;
        }
    }
}
