using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage<Dog> garage = new Garage<Dog>();
            Garage<Mercedes> garage1 = new Garage<Mercedes>();
            Mercedes mercedes = new Mercedes("C class", 2022);
            garage1.Obj = mercedes;
            Console.WriteLine(garage1.Obj.Name);
        }
    }
    class Dog
    {
        public string Name { get; set; }
    }
    class DogCage
    {
        public Dog dog { get; set; }
    }
    class Cat
    {

    }
    class CatCage
    {
        public Cat cat { get; set; }
    }
    class Elephant
    {

    }
    class ElephantCage
    {
        public Elephant elephant { get; set; }
    }
    class Lion
    {

    }
    class LionCage
    {
        public Lion lion { get; set; }
    }

    class Mercedes 
    {
        public Mercedes(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public int Year { get; set; }
    }

    class Garage<T> 
    {
        public T Obj { get; set; }
    }
}

