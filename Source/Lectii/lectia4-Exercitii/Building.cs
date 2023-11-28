using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia4_Exercitii
{
    public abstract class Building
    {
        private int _parkingSpaces;
        public int Height { get; set; }
        public virtual int Population { get; set; }
        public int Surface { get; set; }
        public bool HasParking { get; set; }
        public int ParkingSpaces     // Custom seter for when a building has no parking spaces.
        {
            get
            {
                return _parkingSpaces;
            }
            set
            {
                if (HasParking)
                    _parkingSpaces = value;
            }
        }

    }
}
