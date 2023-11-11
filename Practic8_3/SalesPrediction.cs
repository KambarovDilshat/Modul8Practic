using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    //практика 8_3
    using System;
    using System.Linq;

    class SalesPrediction
    {
        static void Main()
        {
            int[] time = { 1, 2, 3, 4, 5 };
            double[] sales = { 200, 240, 230, 280, 270 }; // Пример данных продаж

            double meanTime = time.Average();
            double meanSales = sales.Average();

            double sumTimeSales = time.Zip(sales, (t, s) => t * s).Sum();
            double sumTimeSquared = time.Select(t => t * t).Sum();

            int N = time.Length;

            double a = (N * sumTimeSales - time.Sum() * sales.Sum()) / (N * sumTimeSquared - Math.Pow(time.Sum(), 2));
            double b = meanSales - a * meanTime;

            for (int i = 6; i <= 8; i++)
            {
                double forecast = a * i + b;
                Console.WriteLine($"Прогноз продаж для месяца {i}: {forecast}");
            }
        }
    }

}
