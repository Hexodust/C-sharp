using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia1.Inheritance
{
    public class ChildCLass : BaseClass, IInterface1, IInterface2
    {
        public ChildCLass()
        {
            Console.WriteLine($"Create new child class at {DateTime.Now}");
        }

        public string GetAge()
        {
            return "18";
        }

        public override string GetCurrentDate()
        {
            var date = DateTime.UtcNow;
            return date.ToString();
        }

        public string GetName()
        {
            return "Adrian";
        }

        public void GetName_ExpectedBehavior_ShouldNotThrowExceptions() // Name used usually in a test project
        { }
    }
}
