using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class FourWheeler : Vehicle, iinteriordesign
    {
        private readonly List<string> inDesign = new List<string>();
        public FourWheeler()
        {

        }
        public FourWheeler(string modelno, int yearmake, int enginecapacityincc, int noofGear, VehicleType vehicleType, int noofSeats) :
            base(modelno, yearmake, enginecapacityincc, noofGear, vehicleType)
        {
            this.NoOfSeats = noofSeats;
        }
        public int NoOfSeats { get; set; }
        public void AddInteriorDesign(params string[] design)
        {
            this.inDesign.AddRange(design);
        }

        public override string Details()
        {
            return $"{ModelNo},{YearMake},{EngineCapacityInCC},{NoOfGear}\n{NoOfSeats}";
        }

        public string GetInteriorDesign()
        {
            return string.Join(", ", inDesign);
        }
    }
}
