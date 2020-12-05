using System;
using System.Threading.Tasks;

namespace Integral.Classes
{
    class RectangleCalculator : ICalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            double h = (b - a) / n;
            double s = 0;
            for(int i = 0; i<n; i++)
            {
                s += f(a + h * i);
            }
            return h*s;
        }

        public double CalculateParallel(double a, double b, int n, Func<double, double> f)
        {
            double h = (b - a) / n;
            double s = 0;
            object locker = new object();
            Parallel.For(0, n, () => 0.0,
               (i, state, localtotal) =>
               localtotal + f(a + h * i),
               localtotal => { lock (locker) s += localtotal; });
            return s * h;
        }
    }
}
