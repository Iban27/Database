using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson.Inheritance
{
    public class Customer : Person
    {
        public readonly int age;

        private string _money;
        public string Money => _money;

        public Customer(int age)
        {
            this.age = age;
            _money = "500";
        }



        public override void SayMyAge()
        {
            throw new NotImplementedException();
        }

        public override void SayMyName()
        {
            //base.SayMyName();
            Console.WriteLine("Client");
        }

        public static void Display()
        {
            Console.WriteLine("I am customer");
        }
    }
}
