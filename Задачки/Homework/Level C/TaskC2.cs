using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C2.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию ChangeCent(int money), которая принимает количество американской валюты в центах и
    // возвращает список из четырех значений, который показывает наименьшее количество монет, используемых для составления этой суммы. 
    // Рассматриваются только монетные номиналы: Pennie (1 цент), Nickel (5 центов), Dime (10 центов) and Quarter (25 центов).
    // Возвращаемый список должен быть формата [кол-во Pennie, кол-во Nickel, кол-во Dime, кол-во Quarter].
    // Если в функцию передается вещественное число, его значение сперва должно быть округлено в меньшую сторону.
    // 
    // Пример:
    // ChangeCent(56) ==> [1,1,0,2] --> 1 * 1 + 1 * 5 + 0 * 10 + 2 * 25.
    public static class TaskC2
    {
        public static List<int> ChangeCent(double money)
        {
            int[] arr = { 0, 0, 0, 0 };
            List<int> all = new List<int>(arr);
            int neww = (int)money;
            while (neww != 0)
            {
                if (neww >= 25)
                {
                    neww -= 25;
                    all[3] += 1;
                }

                else if (neww >= 10)
                {
                    neww -= 10;
                    all[2] += 1;

                }

                else if (neww >= 5)
                {
                    neww -= 5;
                    all[1] += 1;

                }

                else if (neww >= 1)
                {
                    neww -= 1;
                    all[0] += 1;

                }


            }
            return all;
        }
    }
}
