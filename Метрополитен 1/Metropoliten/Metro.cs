using System;
using System.Collections.Generic;
using System.Text;

namespace Metropoliten
{
    // Класс метро
    public class Metro
    {
        // == ПОЛЯ КЛАССА ==
        // Список линий метро
        List<Line> lines;

        // Название города
        string city;

        // == МЕТОДЫ КЛАССА ==
        // Конструктор с параметрами
        // city - название города 
        public Metro(string city)
        {
            // Присваиваем переменной city значение, которое 
            // пришло на вход в функцию
            this.city = city;

            // Инициализируем переменную lines
            lines = new List<Line>();
        }

        // Метод получения города 
        public string GetCity()
        {
            // Возвращаем переменнуюю city
            return city;
        }

        // Метод добавления ветки метро 
        // line - название линии метро
        public void AddLine(string name, string color)
        {
            // Создаем объект класса Line и передаем
            // в конструктор переменную name (название ветки метро)
            Line line = new Line(name, color);

            // Добавляем в список lines объект line
            lines.Add(line);
        }

        // метод удаления ветки метро 
        // line - название линии метро
        public void RemoveLine(string name)
        {
            // Создаем объект класса Line и передаем
            // в конструктор переменную name и color (название и цвет ветки метро)
            foreach (var a in lines)
            {
                if (Convert.ToString(a) == name) {

                    // Удаляем из списка lines объект a (т.е. нашу линию метро)
                    lines.Remove(a);
                }
            }

        }

        // метод нахождения станции (без галочки)
        // (но если нужно, я попробую напись тело функции)
        // station - название станции метро
        public List<Station> FindStation(string name)
        {
            return null;
        }

        // метод нахождения станции (без галочки)
        public Station FindStation(string name, string lineName)
        {
            return null;
        }

        // метод получения списка станций метро (без галочки)
        public List<Station> GetStationList(string name)
        {
            return null;
        }

        // метод для загрузки станций из файла
        public void LoadStationFile(string filename)
        {
            // none
        }





        

    }
}
