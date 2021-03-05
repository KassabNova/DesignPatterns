using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTerm2
{
    interface IVehicleStrategy
    {
        void Move(Vehicle v, double[] pos);
    }
}
