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
            bool fine = true;
            Stack<char> all = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (Convert.ToString(s[i]) == "{" || Convert.ToString(s[i]) == "[" || Convert.ToString(s[i]) == "(" || Convert.ToString(s[i]) == "<")
                {
                    all.Push(s[i]);
                }

                else if (Convert.ToString(s[i]) == "}")
                {
                    if (all.Count != 0)
                    {
                        if (Convert.ToString(all.Pop()) != "{")
                        {
                            fine = false;
                            break;
                        }
                    }

                    else
                    {
                        fine = false;
                        break;
                    }
                }

                else if (Convert.ToString(s[i]) == "]")
                {
                    if (all.Count != 0)
                    {
                        if (Convert.ToString(all.Pop()) != "[")
                        {
                            fine = false;
                            break;
                        }
                    }

                    else
                    {
                        fine = false;
                        break;
                    }
                    
                }

                else if (Convert.ToString(s[i]) == ")")
                {
                    if (all.Count != 0)
                    {
                        if (Convert.ToString(all.Pop()) != "(")
                        {
                            fine = false;
                            break;
                        }
                    }

                    else
                    {
                        fine = false;
                        break;
                    }
                }

                else if (Convert.ToString(s[i]) == ">")
                {
                    if (all.Count != 0)
                    {
                        if (Convert.ToString(all.Pop()) != "<")
                        {
                            fine = false;
                            break;
                        }
                    }

                    else
                    {
                        fine = false;
                        break;
                    }
                }
            }
            
            if (all.Count != 0)
            {
                fine = false;
            }
            return fine;
        }
    }
}
