using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            int count = 0;
            string s = "";
            foreach (string a in text)
            {
                if (a.Length > count)
                {
                    count = a.Length;
                }
            }
            string w = string.Concat(Enumerable.Repeat(Convert.ToString(symbol), (count + 4)));
            s += w;
            s += "\n";
            for (int i = 0; i < text.Count; i++)
            {
                s = s + symbol + " " + text[i];
                string d = string.Concat(Enumerable.Repeat(" ", (count + 3 - (symbol + " " + text[i]).Length)));
                s += d;
                s = s + symbol + "\n";
            }
            s += w;
            return s;
        }
    }
}
