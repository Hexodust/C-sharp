using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatty
{
    public class Assistant : TeachingStaff
    {

        public Assistant(string name, string address, int age, char sex, string eyeColor, string specializare) : base(name, address, age, sex, eyeColor, specializare) 
        { 
        
        }

        public Assistant() : base(null, null, 0, '0', null, null) // bad practice!
        {

        }
    }
}
