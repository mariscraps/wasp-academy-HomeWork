using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            var res = new List<int>();
            string s = Convert.ToString(number);

            for (int i = 0; i < s.Length + 1; i++)
            {
                if (i >= 1)
                {
                    res.Add(Convert.ToInt32(s.Substring(0, i)));
                }
            }
            foreach (int a in res)
            {
                Console.WriteLine(a);
            }
            return res;
        }
    }
}
