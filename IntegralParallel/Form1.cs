using Integral.Classes;
using System;
using System.Diagnostics;
using System.Windows.Forms;
//Привет Максим, я видел ты заходил.
//Короче, здесь был Коля.
namespace IntegralParallel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cbmMetod.SelectedIndex = 0;
            _cbParal.SelectedIndex = 0;
        }
        private ICalculator GetCalculator()
        {
            switch (_cbmMetod.SelectedItem)
            {
                case "Метод трапеции":
                    return new TrapezoidCalc();
                case "Метод прямоугольника":
                    return new RectangleCalculator();
                case "Метод Симпсона":
                    return new Simpson();
            }
            return null;
        }
        private void CalculateParallel()
        {
            _chGraph.Series["Parallel"].Points.Clear();
            double a = Convert.ToDouble(_tbMIN.Text);
            double b = Convert.ToDouble(_tbMAX.Text);
            int n = Convert.ToInt32(_nudN.Value);
            ICalculator calcul = GetCalculator();
            double result = 0;
            Stopwatch time = new Stopwatch();
            TimeSpan resulttime;
            if ((calcul is Simpson) && (n % 2 == 1))
            {
                Exception ex = new ArgumentException("Число шагов нечётное, выберите другой метод или чётное число шагов");
                throw ex;
            }
            for (int i = 2; i <= n; i += n / 5)
            {
                time.Restart();
                calcul.CalculateParallel(a, b, i, x => 2 * x - Math.Log(11 * x) - 1);
                time.Stop();
                resulttime = time.Elapsed;
                _chGraph.Series["Parallel"].Points.AddXY(i, resulttime.TotalMilliseconds);
            }
            result = calcul.CalculateParallel(a, b, n, x => 2 * x - Math.Log(11 * x) - 1);
            _rtbResult.Text = $"Ответ: {result}";
        }
        private void Calculate()
        {
            _chGraph.Series["Follower"].Points.Clear();
            double a = Convert.ToDouble(_tbMIN.Text);
            double b = Convert.ToDouble(_tbMAX.Text);
            int n = Convert.ToInt32(_nudN.Value);
            ICalculator calcul = GetCalculator();
            double result = 0;
            Stopwatch time = new Stopwatch();
            TimeSpan resulttime;
            if ((calcul is Simpson) && (n % 2 == 1))
            {
                Exception ex = new ArgumentException("Число шагов нечётное, выберите другой метод или чётное число шагов");
                throw ex;
            }
            for (int i = 2; i <= n; i += n / 5)
            {
                time.Restart();
                calcul.Calculate(a, b, i, x => 2 * x - Math.Log(11 * x) - 1);
                time.Stop();
                resulttime = time.Elapsed;
                _chGraph.Series["Follower"].Points.AddXY(i, resulttime.TotalMilliseconds);
            }
            result = calcul.Calculate(a, b, n, x => 2 * x - Math.Log(11 * x) - 1);
            _rtbResult.Text = $"Ответ: {result}";
        }
        private void _btCalculate_Click_1(object sender, EventArgs e)
        {
            if (_cbParal.SelectedIndex == 0)
                Calculate();
            else
                CalculateParallel();
        }
    }
}
