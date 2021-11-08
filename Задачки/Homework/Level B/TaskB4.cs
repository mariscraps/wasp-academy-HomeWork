using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            int count = 0;
            string[] arr = new string[s.Length];
            //Queue<string> q = new Queue<string>(arr);
            //Stack<string> r = new Stack<string>(arr);
            bool fine = true;
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(arr.Length);

                if (Convert.ToString(s[i]) == "[" || Convert.ToString(s[i]) == "{" || Convert.ToString(s[i]) == "(" || Convert.ToString(s[i]) == "<")
                {
                    arr[i] = Convert.ToString(s[i]);
                    count++;
                }

                else if (Convert.ToString(s[i]) == "[" || Convert.ToString(s[i]) == "{" || Convert.ToString(s[i]) == "(" || Convert.ToString(s[i]) == ">")
                {
                    if (count == 0)
                    {
                        fine = false;
                        break;
                    }

                    string open_bracket = arr[0];
                    Array.Clear(arr, 0, 2);

                    if (open_bracket == "(" && Convert.ToString(s[i]) == ")")
                    {
                        continue;
                    }

                    if (open_bracket == "[" && Convert.ToString(s[i]) == "]")
                    {
                        continue;
                    }

                    if (open_bracket == "{" && Convert.ToString(s[i]) == "}")
                    {
                        continue;
                    }

                    if (open_bracket == "<" && Convert.ToString(s[i]) == ">")
                    {
                        continue;
                    }

                    fine = false;

                    break;
                }
            }

            if (fine && arr.Length == 0)
            {
                fine = true;
            }

            else
            {
                fine = false;
            }

            Console.WriteLine(fine);
            return fine;
        }
    }
}
