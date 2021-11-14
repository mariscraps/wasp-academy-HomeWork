using System;
using System.Collections.Generic;

namespace Music_disc_store
{

    public interface Istoreitem
    {
        public double Price
        {
            get; set;
        }

        public void DiscountPrice(int percent)
        {
            Price = Price * (percent / 100);
        }
    }
    public class Disk : Istoreitem
    {
        public double Price
        {
            get; set;
        }

        protected string name;
        protected string genre;
        protected int burnCount;

        public void DiscountPrice()
        {
            // none
        }

        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }

        public virtual int DiskSize
        {
            get; set;
        }

        public virtual void Burn(params string[] values)
        {
            // none
        }

    }

    public class Audio : Disk
    {
        string artist;
        string recordStudio;
        int songNumber;

        public Audio(string artist, string recordStudio, int songNumber, string name, string genre)
            : base(name, genre)
        {
            this.artist = artist;
            this.recordStudio = recordStudio;
            this.songNumber = songNumber;
            this.name = name;
            this.genre = genre;

        }

        public override int DiskSize
        {
            get { return songNumber * 8; }
        }

        public override void Burn(params string[] values)
        {
            // в параметре передаются новые значения для полей
            // если я все так поняла
            this.artist = values[0];
            this.recordStudio = values[1];
            this.songNumber = Convert.ToInt32(values[2]);
            this.burnCount += 1;
        }

        public override string ToString()
        {
            string a = $"{name}, {genre}, {artist}, {recordStudio}, {songNumber}, {burnCount}";
            return a;
        }
    }

    public class DVD : Disk
    {
        string producer;
        string filmCompany;
        int minuteCount;

        public DVD(string producer, string filmCompany, int minuteCount, string name, string genre)
            : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minuteCount = minuteCount;
            this.name = name;
            this.genre = genre;
        }

        public override int DiskSize
        {
            get { return (minuteCount / 64) * 2; }
        }

        public override void Burn(params string[] values)
        {
            this.producer = values[0];
            this.filmCompany = values[1];
            this.minuteCount = Convert.ToInt32(values[2]);
            this.burnCount += 1;
        }

        public override string ToString()
        {
            string a = $"{name}, {genre}, {producer}, {filmCompany}, {minuteCount}, {burnCount}";
            return a;
        }

    }

    public class Store
    {
        public string StoreName;
        public string address;
        public List<Audio> audios;
        public List<DVD> dvds;



        public Store(string storeName, string address)
        {
            this.StoreName = storeName;
            this.address = address;
        }

        public override string ToString()
        {
            string s = "Аудиодиски: ";
            foreach (Audio a in audios)
            {
                s += Convert.ToString(a);
                s += ", ";

            }
            s += "Фильмы: ";
            foreach (DVD a in dvds)
            {
                s += Convert.ToString(a);
                s += ", ";

            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // если нужно с клавиатуры требовать значения - исправлю

            Store store = new Store("DisksStore", "Unknown");

            Audio audio1 = new Audio("artist1", "recordStudio1", 1, "name1", "genre1");
            Audio audio2 = new Audio("artist2", "recordStudio2", 2, "name2", "genre2");
            Audio audio3 = new Audio("artist3", "recordStudio3", 3, "name3", "genre3");
            store.audios.Add(audio1);
            store.audios.Add(audio2);
            store.audios.Add(audio3);

            DVD dvd1 = new DVD("producer1", "filmStudio1", 1, "name5", "genre5");
            DVD dvd2 = new DVD("producer2", "filmStudio2", 2, "name6", "genre6");
            DVD dvd3 = new DVD("producer3", "filmStudio3", 3, "name7", "genre7");
            store.dvds.Add(dvd1);
            store.dvds.Add(dvd2);
            store.dvds.Add(dvd3);

            store.ToString();

            audio1.Burn();

            // "name{1}" - название, которое я даю каждому из дисков

            Console.Write("name1 → ");
            Console.WriteLine(audio1.DiskSize);
            Console.Write("name2 → ");
            Console.WriteLine(audio2.DiskSize);
            Console.Write("name3 → ");
            Console.WriteLine(audio3.DiskSize);
            Console.Write("name5 → ");
            Console.WriteLine(dvd1.DiskSize);
            Console.Write("name6 → ");
            Console.WriteLine(dvd2.DiskSize);
            Console.Write("name7 → ");
            Console.WriteLine(dvd3.DiskSize);










        }
    }
}
