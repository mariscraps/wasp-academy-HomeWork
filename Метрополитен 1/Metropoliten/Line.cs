using System;
using System.Collections.Generic;
using System.Text;

namespace Metropoliten
{
    public class Line
    {
        // == ПОЛЯ КЛАССА ==
        // список станций метро 
        public List<Station> stations;

        // название станции
        public string name;

        // цвет линии станции
        string color;

        // == МЕТОДЫ КЛАССА ==
        // Конструктор с параметрами
        public Line(string name, string color)
        {
            // Присваиваем переменной name значение, которое 
            // пришло на вход в функцию
            this.name = name;

            // Присваиваем переменной color значение, которое 
            // пришло на вход в функцию
            this.color = color;

            // Инициализируем переменную stations
            stations = new List<Station>();

        }

        // получить название линии
        public string GetName()
        {
            return name;
        }

        // добавить название станции
        public void SetName(string name)
        {
            this.name = name;
        }

        // получить цвет линии
        public string GetColor()
        {
            return color;
        }

        // присвоить новый цвет линии 
        public void SetColor(string color)
        {
            this.color = color;
        }

        // добавить станцию (имя + цвет линии станции)
        public void AddStation(string name, string color)
        {
            Station station = new Station(name, this.color);
            stations.Add(station);
        }

        // добавить станцию (имя + цвет линии станции + пересадки)
        public void AddStation(string name, string color, List<Station> transfers)
        {
            Station station = new Station(name, this.color, transfers);
            stations.Add(station);
        }

        // удалить станцию
        public void RemoveStation(string name)
        {
            // проходимся по списку с названиями станций
            foreach (var a in stations)
            {
                if (Convert.ToString(a) == name)
                {
                    // Удаляем из списка stationd объект a (т.е. нашу станцию)
                    stations.Remove(a);
                }
            }
        }

        // метод находит нужную станцию по названию 
        public Station FindStationByName(string name)
        {
            foreach (Station a in stations)
            {
                if (Convert.ToString(a) == name)
                {
                    return a;
                }
            }
            return null;
        }

        // получить список станций по названию линии
        public List<Station> GetStationList(string name)
        {
            return stations;
        }




    }
}
