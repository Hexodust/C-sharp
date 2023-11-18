using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatty
{
    public class TeachingClass
    {
        public string ClassName { get; set; }
        public Profesor Profesor { get; set; }
        public List<Assistant> Assistants { get; } = new List<Assistant>();

        public TeachingClass(string className)
        {
            AddSmartAssistants();
            ClassName = className;
        }

        public void AddSmartAssistants()
        {
            Assistants.Add(new Assistant());
            Assistants.Add(new Assistant());
            Assistants.Add(new Assistant());
        }
    }
}
