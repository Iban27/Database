using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson.Inheritance
{
    public abstract class Person
    {
        public virtual void SayMyName()
        {
            Console.WriteLine("Человек");
        }

        public abstract void SayMyAge();
    }
}
