using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C3.
    // Кол-во стингеров: 🔷
    //
    // Существует 2 системы покупки билетов в кино.
    // Система А: ticket долларов за билет каждый раз
    // Система B: card долларов за карту, каждый следующий билет будет в perc меньше цены предыдущего
    // Написать функцию Movie(card, ticket, perc), которая опредляет с какого посещения кинотеатра
    // покупка билетов по системе B будет выгоднее системы A
    //
    // Пример:
    // ticket = 15, card = 500, perc = 0.9
    // Цена трех походов в кино:
    // Система А: 15 * 3 = 45
    // Система B: 500 + 15 * 0.9 + 15 * 0.9 * 0.9 + 15 * 0.9 * 0.9 * 0.9 = 536.58....
    public static class TaskC3
    {
        public static int Movie(int card, int ticket, double perc)
        {
            // Здесь необходимо написать код.

            return 0;
        }
    }
}
