using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8_2
{
    using System;
    using System.Collections.Generic;

    class Supermarket
    {
        static void Main()
        {
            var products = new Dictionary<string, double>
        {
            {"Молоко", 50.0},
            {"Хлеб", 30.0},
            {"Сыр", 200.0}
        };

            double totalSum = 0;
            foreach (var product in products)
            {
                totalSum += product.Value;
            }

            TimeSpan startTime = new TimeSpan(8, 0, 0);
            TimeSpan endTime = new TimeSpan(12, 0, 0);
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (currentTime > startTime && currentTime < endTime)
            {
                totalSum *= 0.95; // 5% скидка
            }

            Console.WriteLine($"Общая сумма: {totalSum}");
        }
    }

}
