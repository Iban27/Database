using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson.Inheritance
{
    public class BaseClass
    {


        public BaseClass(int x)
        {
            Console.WriteLine("Базовый класс получил X: " + x);
        }

        public void Display()
        {
            Console.WriteLine("BaseDisplay");
        }
    }

    public class ChildClass : BaseClass
    {


        public ChildClass(int x, int y) : base(x)
        {
            Console.WriteLine("Производный класс получил X: " + x + " и Y: " + y);
        }

        public void Show()
        {
            base.Display();
        }
    }

    public class Calculator
    {
        public virtual void Calculation(int x, int y)
        {
            Console.WriteLine("Получил 2 числа: " + x + ", " + y);
        }
    }

    public class CalculatorPlus : Calculator
    {
        public override void Calculation(int x, int y)
        {
            base.Calculation(x, y);
            int result = x + y;
            Console.WriteLine("Результат сложения: " + result);
        }
    }

    public class CalculatorMinus : Calculator
    {
        public override void Calculation(int x, int y)
        {
            base.Calculation(x, y);
            int result = x - y;
            Console.WriteLine("Результат вычитания: " + result);
        }
    }
}
