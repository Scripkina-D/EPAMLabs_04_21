using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Musician> x = new List<Musician>();

            x.Add(new Musician() { Name = "Филипп Киркоров", NumberSongs = 23 });
            x.Add(new Musician() { Name = "Клава Кока", NumberSongs = 14 });
            x.Add(new Musician() { Name = "Земфира", NumberSongs = 18 });
            x.Add(new Musician() { Name = "Дима Билан", NumberSongs = 72 });
            x.Add(new Musician() { Name = "Сергей Лазарев", NumberSongs = 34 });

            List<Musician> x1 = x.Where(t => t.NumberSongs > 20).ToList();


            Console.WriteLine("Исполнители выпустившие более 20 песен");
            foreach (Musician m in x1)
            {
                Console.WriteLine($"{m.Name} выпустил {m.NumberSongs} песен");
            }

        }


        class Musician
        {
            public int NumberSongs { get; set; }

            public string Name { get; set; }


        }
      
    }
}
