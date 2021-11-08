using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А4.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ListOfSums(List<int> list), которая получает на вход
    // список чисел и возвращает только те, которые равны сумме всех
    // предшествующих элементов этого списка.
    //
    // Пример:
    // ListOfSums([2,3,5,6]) ==> [5] -> 5 = 2 + 3;
    // ListOfSums([10,20,30,60,-120,0]) ==> [30,60,0].
    public static class TaskA4
    {
        public static List<int> ListOfSums(List<int> list)
        {
            var res = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i >= 1)
                {
                    int ans = 0;
                    for (int j = 0; j < i; j++)
                    {
                        ans += list[j];
                    }

                    if (list[i] == ans)
                    {
                        res.Add(list[i]);
                    }
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
