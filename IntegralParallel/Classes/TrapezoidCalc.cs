using System;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class TrapezoidCalc : ICalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double s = (f(a) + f(b)) / 2;
            for (int i = 1; i<n; i++)
            {
                s += f(a + h * i);
            }
            return s * h;
        }

        public double CalculateParallel(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double s = (f(a) + f(b)) / 2;
            object locker = new object();
            Parallel.For(1, n,() =>0.0,
                (i, state, localtotal) =>
                localtotal + f(a + h * i),
                localtotal => { lock (locker) s += localtotal;}) ;
            return s * h;
        }
    }
}
