using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia1.CustomTypes
{
    public class MyClass : IMyInterface
    {
        private int _id = 1;

        public MyClass()
        {

        }

        public MyClass(int year)
        {

        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }

        protected int Year { get; } = 1901;
        public string Name { get; set; }

        public void PrintYear()
        {
            Console.WriteLine(Year);
            //Year = 2000;
            Console.WriteLine(Year);
        }

        public int GetId() { return _id; }

        public void SetId(int id) { _id = id; }
        
        public void GetAccountNo()
        {
            int age = 1;
            age++;
            Console.WriteLine(age);
        }

        public void IncrementId()
        {
            _id++;
            Console.WriteLine(_id);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            var other = (MyClass) obj;

            if (Id != other.Id || Year != other.Year || Name != other.Name)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Year.GetHashCode() ^ Name.GetHashCode();
        }

        public static bool operator ==(MyClass first, MyClass second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(MyClass first, MyClass second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[");
            sb.Append(Id);
            sb.Append("]");
            return sb.ToString();
        }
    }
}
