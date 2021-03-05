using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTerm2
{
    class Fly : IVehicleStrategy 
    {
        public void Move(Vehicle metrics)
        {
            Console.WriteLine("Sorting using memory! Using: {0}K of disk swap memory", new Random().Next(1000, 42069));
        }
    }
}
