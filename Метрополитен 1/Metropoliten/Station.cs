using System;
using System.Collections.Generic;
using System.Text;

namespace Metropoliten
{
    public class Station
    {

        // == ПОЛЯ КЛАССА ==
        // Название станции
        string name;

        // цвет станции
        string color;

        // Название линии 
        Line line;

        // список пересадок
        public List<Station> transfers;

        // доп возможности
        bool isWheelchairAccessible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;


        // == МЕТОДЫ КЛАССА ==
        // Конструктор с параметрами
        public Station(string name, string color, params string[] extra_info)
        {
            // Присваиваем переменной name значение, которое 
            // пришло на вход в функцию
            this.name = name;

            // Присваиваем переменной name значение, которое 
            // пришло на вход в функцию
            this.color = color;

            // передаю доп. возможности
            this.isWheelchairAccessible = bool.Parse(extra_info[0]);
            this.hasParkAndRide = bool.Parse(extra_info[1]);
            this.hasNearbyCableCar = bool.Parse(extra_info[2]);

        }

        // конструктор с параметрами
        public Station(string name, string color, List<Station>transfers)
        {
            // Присваиваем переменной name значение, которое 
            // пришло на вход в функцию
            this.name = name;

            // Присваиваем переменной name значение, которое 
            // пришло на вход в функцию
            this.color = color;

            // Инициализируем переменную transfers
            transfers = new List<Station>();

        }

        // метод получения названия станции
        public string GetName()
        {
            return name;
        }

        // метод добавления станции
        public void SetName(string name)
        {
            this.name = name;
        }

        // проверка на наличие инвалидных колясок на станции
        public bool IsWheelchairAccessible()
        {
            if (isWheelchairAccessible)
            {
                return true;
            }
            return false;
        }

        // проверка на наличие парковки
        public bool HasParkAndRide()
        {
            if (hasParkAndRide) {
                return true;
            }
            return false;
        }

        // проверка на наличие канатной дороги поблизости
        public bool HasNearbyCableCar()
        {
            if (hasNearbyCableCar)
            {
                return true;
            }
            return false;
        }

        // метод получения названия линии
        public string GetLineName()
        {
            return " ";
        }

        // метод получения списка пересадок
        public List<Station> GetTransferList()
        {
            return transfers;
        }

    }
}
