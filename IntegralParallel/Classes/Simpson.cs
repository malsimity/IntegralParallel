using System;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class Simpson : ICalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            if (n % 2 == 1) // проверка четности количества разбиений
            {
                Exception ex = new ArgumentException("Нечётное число разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double S;
            S = f(a) + f(b);
            for (int i = 1; i <= n / 2; i++)
            {
                S += 4 * f(a + (2 * i - 1) * h);
            }
            for (int i = 1; i < n / 2; i++)
            {
                S += 2 * f(a + 2 * i * h);
            }
            return h * S / 3;
        }

        public double CalculateParallel(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            if (n % 2 == 1) // проверка четности количества разбиений
            {
                Exception ex = new ArgumentException("Нечётное число разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double S = 0;
            double S1 = 0;
            S = f(a) + f(b);
            object locker = new object();
            Parallel.For(1, n / 2 + 1, () => 0.0,
                (i, state, localtotal) =>
                localtotal + f(a + (2 * i - 1) * h),
                localtotal => { lock (locker) S1 += localtotal; });
            S += 4 * S1;
            S1 = 0;
            Parallel.For(1, n / 2, () => 0.0,
                (i, state, localtotal) =>
                localtotal + f(a + 2 * i * h),
                localtotal => { lock (locker) S1 += localtotal; });
            S += 2 * S1;
            return h * S / 3;
        }
    }
}
