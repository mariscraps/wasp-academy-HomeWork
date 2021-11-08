using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А1.
    // Кол-во стингеров: ⅓🔹
    //
    // Напишите функцию NumberOfSquares(int limit), которая будет возвращать,
    // сколько целых (начиная с 1, 2 ...) чисел, возведенных в степень 2,
    // а затем суммированных, меньше некоторого заданного числа в качестве
    // параметра limit.
    //
    // Примеры:
    // NumberOfSquares(6) => 2 -> 1 ^ 2 + 2 ^ 2 = 1 + 4 = 5 и 5 < 6;
    // NumberOfSquares(15) => 3 -> 1 ^ 2 + 2 ^ 2 + 3 ^ 2 = 1 + 4 + 9 = 14 и 14 < 15.
    public static class TaskA1
    {
        public static int NumberOfSquares(int limit)
        {
            double count = 0;
            double current_summa = 0;
            while (current_summa < limit)
            {
                count += 1;
                current_summa += (Math.Pow(count, 2));
                if (current_summa >= limit)
                {
                    count -= 1;

                }
            }
            int res = Convert.ToInt32(count);
            Console.WriteLine(res);
            return res;
        }
    }
}
