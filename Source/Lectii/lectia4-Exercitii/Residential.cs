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

        public int Rooms { get; }
        public int RoomsForRent { get; set; }


        public int RentRoom()
        {
            if (CanRent)
            {
                RoomsForRent--;
            }
            return RoomsForRent;
            
        }

        public int FreeRoom()
        {
            if (RoomsForRent < Rooms)
            {
                RoomsForRent++;
            }
            return RoomsForRent;
        }
    }
}
