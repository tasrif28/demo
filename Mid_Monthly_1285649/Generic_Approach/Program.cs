using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("*****************************************MotorCycle********************************************");
            Console.WriteLine();

            MotorCycle m = new MotorCycle("R15", 2002, 180, 6, VehicleType.Personal, 30.00, "Self+Kick", 100, 6, "Light", "Disc", "Drum");
            m.AddExteriorDesign("Vip-Horn", "Fog_Light");
            GenericDetailImpl<MotorCycle> gd = new GenericDetailImpl<MotorCycle>();
            Console.WriteLine(gd.GetDetails<MotorCycle>(m));
            Console.WriteLine(m.GetExteriorDesign());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
