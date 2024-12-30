using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class TwoWheeler : Vehicle, iexteriordesign
    {
        private readonly List<string> exDesign = new List<string>();
        public TwoWheeler()
        {

        }
        public TwoWheeler(string modelno, int yearmake, int enginecapacityincc, int noofGear, VehicleType vehicleType, double mileage, string startingMethod) :
            base(modelno, yearmake, enginecapacityincc, noofGear, vehicleType)
        {
            this.Mileage = mileage;
            this.StartingMethod = startingMethod;
        }
        public double Mileage { get; set; }
        public string StartingMethod { get; set; }

        public void AddExteriorDesign(params string[] designs)
        {
            this.exDesign.AddRange(designs);
        }

        public void AddInteriorDesign(params string[] design)
        {
            throw new NotImplementedException();
        }

        public override string Details()
        {
            return $"{ModelNo},{YearMake},{EngineCapacityInCC},{NoOfGear}\n{Mileage},{StartingMethod}";
        }

        public string GetExteriorDesign()
        {
            return string.Join(", ", exDesign);
        }

        public string GetInteriorDesign()
        {
            throw new NotImplementedException();
        }
    }
}
