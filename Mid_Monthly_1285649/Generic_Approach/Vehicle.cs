using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {

        }
        protected Vehicle(string modelno, int yearmake, int enginecapacityincc, int noofGear, VehicleType vehicleType)
        {
            this.ModelNo = modelno;
            this.YearMake = yearmake;
            this.EngineCapacityInCC = enginecapacityincc;
            this.NoOfGear = noofGear;
            this.VehicleType = vehicleType;
        }
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int EngineCapacityInCC { get; set; }
        public int NoOfGear { get; set; }
        public VehicleType VehicleType { get; set; }

        public abstract string Details();

    }
}
