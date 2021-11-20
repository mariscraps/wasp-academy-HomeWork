using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            string w = "";
            int spaces = s.Count(Char.IsWhiteSpace); 
            string[] ab = new string[spaces + 1];
            ab = s.Split(' ').ToArray();
            foreach (string a in ab)
            {
                Console.WriteLine(a);
                string neww = new string(a.ToCharArray().Reverse().ToArray());
                w += neww;
                w += " ";

            }

            int c = 0;
            foreach (char a in s)
            {
                if (Convert.ToString(a) == " ")
                {
                    c++;
                }
            }

            if (c != s.Length)
            {
                return w.Trim();
            }
            return s;
        }
    }
}
