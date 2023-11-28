using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia4_Exercitii
{
    internal class Mall : Building
    {
        public int Floors { get; set; }
        public List<string> Shops { get; set; } //TODO: Make a Shop Class
    }
}
