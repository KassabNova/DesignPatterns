using System;
using System.Threading.Tasks;
using System.Threading;

namespace ExamTerm2
{
    class Program
    {
        static volatile bool exit = false;
        enum Strategy
        {
            WALK,
            SWIM,
            FLY,
            TELEPORT
        }
        static void Main(string[] args)
        {
            Strategy strat = Strategy.WALK;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Q)
                        exit = true;
                    if (Console.ReadKey().Key == ConsoleKey.A)
                        strat = Strategy.WALK;
                    if (Console.ReadKey().Key == ConsoleKey.S)
                        strat = Strategy.SWIM;
                    if (Console.ReadKey().Key == ConsoleKey.D)
                        strat = Strategy.FLY;
                    if (Console.ReadKey().Key == ConsoleKey.F)
                        strat = Strategy.TELEPORT;
                }
            });

            Vehicle v = new Vehicle(VehicleType.Speeder, "Versatile speeder", 100);
            while (!exit)
            {
                Thread.Sleep(200);
                switch (strat)
                {
                    case Strategy.WALK:
                        {
                            v.MoveStrategy(new Walk()); //And we change strategies like this.
                            v.Move(v, new double[2] { 22.22, 13.10 });
                            break;
                        }
                    case Strategy.SWIM:
                        {
                            v.MoveStrategy(new Swim());
                            v.Move(v, new double[2] { 22.22, 13.10 });
                            break;
                        }
                    case Strategy.FLY:
                        {
                            v.MoveStrategy(new Fly());
                            v.Move(v, new double[2] { 32.5, 5.69 });
                            break;
                        }
                    case Strategy.TELEPORT:
                        {
                            v.MoveStrategy(new Teleport());
                            v.Move(v, new double[2] { 45.4, 20.1 });
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
