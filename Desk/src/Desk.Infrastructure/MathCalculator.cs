using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure
{
    public class MathCalculator
    {

        /// <summary>
        /// 等比数列求和
        /// </summary>
        /// <param name="a1">首项</param>
        /// <param name="q">公比</param>
        /// <param name="n">项数</param>
        /// <returns></returns>
        public static double SumOfGeometricProgression(double a1, double q, double n)
        {
            //if (q == 0)
            //    throw new ArgumentException($"公比{nameof(q)}≠0");
            if (q == 1)
                throw new ArgumentException($"公比{nameof(q)}≠1");
            return a1 * (1 - Math.Pow(q, n)) / (1 - q);
        }
    }
}
