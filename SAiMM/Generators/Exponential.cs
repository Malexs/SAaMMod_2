using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAiMM.Generators
{
    class Exponential
    {
        List<Double> values = null;
        Double λ = 0;

        public Exponential(List<Double> _values, Double _λ)
        {
            values = _values;
            λ = _λ;
        }

        public List<Double> GetNewList()
        {
            List<double> rsq = new List<double>();
            foreach (double tmp in values)
            {
                rsq.Add(Math.Abs(Math.Log(tmp) / λ));
            }
            return rsq;
        }
    }
}
