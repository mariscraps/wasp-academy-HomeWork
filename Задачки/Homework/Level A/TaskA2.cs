using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А2.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию VeryEven(number), которая определяет является ли число "очень четным".
    // Однозначное число "очень четное", если оно четное. Числа больше 10 "очень четные",
    // если сумма их цифр - "очень четное" число.
    //
    // Примеры:
    // VeryEven(88) => false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 - нечетное;
    // VeryEven(222) => true -> 2 + 2 + 2 = 8 => 8 - четное.
    public static class TaskA2
    {
        public static bool VeryEven(int number)
        {
            int count = 0;
            bool res = true;
            int ans = 100;
            string anss = "    ";
            if (number > -10 && number < 10)
            {
                if (number % 2 == 0)
                {
                    res = true;
                }

                else
                {
                    res = false;
                }
            }

            else if (number >= 10)
            {
                string s = Convert.ToString(number);
                var charArray = s.ToCharArray();
                while (ans >= 10)
                {
                    if (count == 0)
                    {
                        ans = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            ans += (charArray[i] - '0');
                        }
                        if (ans >= 10)
                        {
                            anss = Convert.ToString(number);
                            charArray = anss.ToCharArray();
                        }
                        count++;
                    }

                    else
                    {
                        ans = 0;
                        for (int i = 0; i < anss.Length; i++)
                        {
                            ans += (charArray[i] - '0');
                        }
                        if (ans >= 10)
                        {
                            anss = Convert.ToString(ans);
                            charArray = anss.ToCharArray();
                        }
                    }
                }

                if (ans % 2 == 0)
                {
                    res = true;
                }

                else
                {
                    res = false;
                }
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
