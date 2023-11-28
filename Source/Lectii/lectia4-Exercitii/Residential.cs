using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia4_Exercitii
{
    internal class Residential : Building
    {
        public bool CanRent
        {
            get
            {
                return RoomsForRent > 0;
            }
        }
        public int RoomsForRent { get; set; }


        public int RentRoom() // TODO: Implement a way to free up a room for rent
        {
            RoomsForRent--;
            return RoomsForRent;
            
        }
    }
}
