using System;

namespace AljabarLibraries
{
    public class Perhitungan
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double d = b*b - (4 * a * c);

            if(d < 0)
            {
                return new double[0];
            }
            else if(d > 0)
            {
                double e = Math.Sqrt(d);
                return new double[] { (-b + e) / (2 * a), (-b - e) / (2 * a) };
            }
            else
            {
                return new double[] {-b / (2 * a)};
            }
        }
        public double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            
            double aKuadrat = Math.Pow(a,2);
            double ab = 2 * a * b;
            double bKuadrat = Math.Pow(b,2);

            return new double[] { aKuadrat, ab, bKuadrat };
        }
    }
}
