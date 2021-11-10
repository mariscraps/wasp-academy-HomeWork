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

            // заношу элементы со входа в список пересадок
            foreach (Station a in transfers)
            {
                this.transfers.Add(a);
            }

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
            return isWheelchairAccessible;
        }

        // проверка на наличие парковки
        public bool HasParkAndRide()
        {
            return hasParkAndRide;
        }

        // проверка на наличие канатной дороги поблизости
        public bool HasNearbyCableCar()
        {
            return hasNearbyCableCar;
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
