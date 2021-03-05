using System;

namespace ExamTerm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vehicle v = new Vehicle(VehicleType.Speeder, "Versatile siege", 100);

            v.Move(v, new double[2] { 10, 10 });//Default strategy is "walk"
            v.MoveStrategy(new Swim()); //And we change strategies like this.
            v.Move(v, new double[2] { 22.22, 13.10 });
            v.MoveStrategy(new Fly());
            v.Move(v, new double[2] { 32.5, 5.69 });
            v.MoveStrategy(new Teleport());
            v.Move(v, new double[2] { 45.4, 20.1 });
        }
    }
}
