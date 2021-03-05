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
        private  IVehicleStrategy mStrategy;

        public Vehicle(VehicleType type, string name, int health)
        {
            vehicleType = type;
            vehicleName = name;
            vehicleHealth = health;
        }

        public Vehicle()
        {
        }

        public void MoveStrategy(IVehicleStrategy strat)
        {
            mStrategy = strat;
        }

        public void Move(Vehicle vehicle)
        {
            mStrategy.Move(vehicle);
        }
    }

    
}
