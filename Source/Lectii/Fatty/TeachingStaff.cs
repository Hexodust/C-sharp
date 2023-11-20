using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatty
{
    public class TeachingStaff : Person
    {
        public string Specializare { get; set; }

        public TeachingStaff(string name, string address, int age, char sex, string eyeColor, string specializare) : base(name, address, age, sex, eyeColor)
        {
            Specializare = specializare;
        }
    }
}
