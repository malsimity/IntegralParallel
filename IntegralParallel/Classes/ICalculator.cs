using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public interface ICalculator
    {
        double Calculate(double a, double b, int n, Func<double, double> f);

        double CalculateParallel(double a, double b, int n, Func<double, double> f);

    }
}
