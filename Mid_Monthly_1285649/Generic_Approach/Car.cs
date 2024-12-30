using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class Car : FourWheeler
    {
        public Car()
        {

        }
        public Car(string modelno, int yearmake, int enginecapacityincc, int noofGear, VehicleType vehicleType, int noofSeats, int noofDoor) :
            base(modelno, yearmake, enginecapacityincc, noofGear, vehicleType, noofDoor)
        {
            this.NoOfDoor = noofDoor;
        }
        public int NoOfDoor { get; set; }
        public override string Details()
        {
            return $"{base.Details()}\n noof door{NoOfDoor}";
        }
    }
}
