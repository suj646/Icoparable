using System;

namespace Icomparabledemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car[] cars = new Car[]
   {
        new Car()
        {
            Name = "Maruti"
        }, new Car()
        {
            Name = "Activa"
        }, new Car()
        {
            Name = "Tata"
        }
   };
            Array.Sort(cars);
            Array.ForEach(cars, x => Console.WriteLine(x.Name));
        }


        public class Car : IComparable
        {
            public string Name
            {
                get;
                set;
            }
            public int MaxSpeed
            {
                get;
                set;
            }
            public int CompareTo(object obj)
            {
                if (!(obj is Car))
                {
                    throw new ArgumentException("Compared Object is not of car");
                }
                Car car = obj as Car;
                return Name.CompareTo(car.Name);
            }
        }
    }
    
}
