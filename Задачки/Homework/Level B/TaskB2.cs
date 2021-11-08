using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            int[] length = new int[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                int ans = 0;
                string s = Convert.ToString(list[i]);
                for (int j = 0; j < s.Length; j++)
                {
                    char qwe = s[j];
                    int wee = qwe - '0';
                    ans += wee;

                }
                length[i] = ans;
            }
            for (int i = 0; i < length.Length - 1; i++)
            {
                for (int j = 0; j < length.Length - i - 1; j++)
                {
                    if (length[j] > length[j + 1])
                    {
                        int c = length[j];
                        length[j] = length[j + 1];
                        length[j + 1] = c;

                        int d = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = d;
                    }

                    else if (length[j] == length[j + 1])
                    {
                        if (string.Compare(Convert.ToString(list[j]), Convert.ToString(list[j + 1])) == 1)
                        {
                            int d = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = d;
                        }
                    }
                }
            }

            foreach (int a in list)
            {
                Console.WriteLine(a);
            }
            return list;
        }
    }
}
