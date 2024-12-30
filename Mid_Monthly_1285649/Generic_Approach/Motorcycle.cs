using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class MotorCycle : TwoWheeler
    {
        public MotorCycle()
        {

        }
        public MotorCycle(string modelno, int yearmake, int enginecapacityincc, int noofGear, VehicleType vehicleType, double mileage, string startingMethod,
            int maxpower, int maxtorque, string coling, string frontbrake, string rearbrake) :
            base(modelno, yearmake, enginecapacityincc, noofGear, vehicleType, mileage, startingMethod)
        {
            this.MaxPower = maxpower;
            this.MaxTorque = maxtorque;
            this.Coling = coling;
            this.FrontBrake = frontbrake;
            this.RearBrake = rearbrake;
        }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public string Coling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }
        public override string Details()
        {
            return $"{base.Details()}\n max power{MaxPower}, max torque{MaxTorque}, coling{Coling}, front brake{FrontBrake}, rear brake{RearBrake}";
        }

    }
}
