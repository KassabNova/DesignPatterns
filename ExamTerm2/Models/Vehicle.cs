using System;
using System.Linq;
using System.Text;
namespace ExamTerm2
{
    public enum VehicleType
    {
        Siege,
        Speeder,
        Cavalry
    }
    class Vehicle
    {
        public VehicleType vehicleType { get; set; }
        public string vehicleName { get; set; }
        public DateTime metricTime { get; set; }
        public int vehicleHealth { get; set;  }
        public double[] vehiclePos { get; set;  }

        private  IVehicleStrategy mStrategy = new  Walk();

        public Vehicle(VehicleType type, string name, int health)
        {
            vehicleType = type;
            vehicleName = name;
            vehicleHealth = health;
            vehiclePos = new double[2]{0,0};
        }

        public Vehicle()
        {
        }

        public void MoveStrategy(IVehicleStrategy strat)
        {
            mStrategy = strat;
        }

        public void Move(Vehicle vehicle, double[] newPos)
        {
            mStrategy.Move(vehicle,newPos);
            this.vehiclePos = newPos;
        }
    }

    
}
