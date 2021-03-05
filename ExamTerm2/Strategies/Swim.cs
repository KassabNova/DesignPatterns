using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTerm2
{
    class Swim : IVehicleStrategy 
    {
        public void Move(Vehicle vehicle, double[] pos)
        {
            Console.WriteLine($"Im swiming from {vehicle.vehiclePos[0]},{vehicle.vehiclePos[1]} to {pos[0]},{pos[1]}", new Random().Next(1000,42069));
        }
    }
}
