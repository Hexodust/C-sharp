using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia1.Inheritance
{
    public class BaseClass
    {
        public virtual string GetCurrentDate()
        {
            var date = DateTime.Now;
            return date.ToString();
        }
    }
}
