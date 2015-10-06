using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAiMM.Generators
{
    class Gauss
    {
        List<Double> values = null;
        Double m = 0,
            σ = 0;

        public Gauss(List<Double> _values, Double _m, Double _σ)
        {
            values = _values;
            m = _m;
            σ = _σ;
        }

        public List<Double> GetNewList()
        {
            List<double> rsq = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i <= values.Count - 1; i++)
            {
                double R = 0;
                for (int j = 0; j <= 5; j++)
                {
                    R += values[rnd.Next(values.Count - 1)];
                }

                rsq.Add(m + σ * Math.Sqrt(2) * (R - 3));
            }
            return rsq;
        }
    }
}
