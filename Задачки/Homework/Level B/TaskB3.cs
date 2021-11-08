using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B3.
    // Кол-во стингеров: ½🔹
    //
    // Написать функцию Decrypt(string key), которая подсчитывает количество вхождений символов с 'a' до 'z' и 
    // возвращает строку длиной 26 символов, где на каждой позиции - количетво вхождений этой буквы в строке. 
    // Буквы должны быть упорядочены, как в алфавите.
    //
    // Примеры:
    // decrypt('$aaaa#bbb*cc^fff!z') ==> '43200300000000000000000001'
    //           ^    ^   ^  ^  ^         ^^^  ^                   ^
    //          [4]  [3] [2][3][1]        abc  f                   z
    public static class TaskB3
    {
        public static string Decrypt(string key)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] chars = new char[alphabet.Length];
            for (int i = 0; i < alphabet.Length; i++)
            {
                dict.Add(Convert.ToString(alphabet[i]), 0);
            }

            for (int i = 0; i < key.Length; i++)
            {
                if (dict.ContainsKey(Convert.ToString(key[i])))
                {
                    dict[Convert.ToString(key[i])] += 1;
                }
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                chars[i] = Char.Parse(dict[Convert.ToString(alphabet[i])].ToString());
            }

            string res = new string(chars);
            Console.WriteLine(res);

            return res;
        }
    }
}
