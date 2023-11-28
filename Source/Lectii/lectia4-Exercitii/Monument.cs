using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia4_Exercitii
{
    internal class Monument : Building
    {
        public override int Population
        {
            get { return 0; }

        }
        public override string ToString()
        {
            var disp = new StringBuilder();
            disp.Append("Population: ");
            disp.Append(Population);
            return disp.ToString();
        }
    }
}
