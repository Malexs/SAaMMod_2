using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAiMM.Generators
{
    class Gamma
    {
        List<Double> values = null;
        Double λ = 0,
            η = 0;

        public Gamma(List<Double> _values, Double _λ, Double _η)
        {
            values = _values;
            λ = _λ;
            η = _η;
        }

        public List<Double> GetNewList()
        {
            List<double> rsq = new List<double>(); 
            Random rnd = new Random();
            for (int i = 0; i <= values.Count - 1; i++)
            {
                double R = 1;
                for (int j = 0; j <= Math.Floor(η); j++)
                {
                    R *= values[rnd.Next(values.Count - 1)];
                }
                double tmp = Math.Abs(Math.Log(R) / λ);
                rsq.Add(tmp);
            }
            return rsq;
        }
    }
}
