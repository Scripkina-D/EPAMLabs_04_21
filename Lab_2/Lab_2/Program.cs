using System;

namespace Lab_2
{
    abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void Display();
       
    }

    class Writer : Person
    {
        public int NumberBooks { get; set; }   
        public Writer (string name, int numberBooks)
            : base(name)
        {
            NumberBooks = numberBooks;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} написал {NumberBooks}  книг");
        }
    }

    class Musician : Person
    {
        public int NumberSongs { get; set; } // должность

        public Musician (string name, int numberSongs)
            : base(name)
        {
            NumberSongs = numberSongs;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} выпустил {NumberSongs} песен");
        }
    }


 

    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer("Достоевский",150);
            Musician musician = new Musician("Дима Билан", 50);
            writer.Display();
            musician.Display();
        }
    }
}
