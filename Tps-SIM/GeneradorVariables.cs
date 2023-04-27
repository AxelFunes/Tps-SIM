using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tps_SIM
{
    internal class GeneradorVariables
    {
        private Random random;

        public GeneradorVariables()
        {
            random = new Random();
        }

        public double generarUniforme(int a, int b)
        {
            return Math.Round((a + random.NextDouble() * (b - a)), 4);
        }

        public double generarExponencialNegativa(double media)
        {
            return Math.Round((media * -1 * Math.Log(1 - random.NextDouble())), 4);
        }

        public double generarNormal(double media, double desviacionEst)
        {
            double acu = 0;
            for (var index = 1; index <= 12; index++)
                acu += random.NextDouble();
            acu -= 6;
            return Math.Round((acu * desviacionEst + media), 4);
        }
    }
}
