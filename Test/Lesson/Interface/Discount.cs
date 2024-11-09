using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson.Interface
{
    //д\з добавить скидку для пенсионеров в 50 процентов и для спортсменов в 10 процентов
    public interface IDiscount
    {
        float ApplyDiscount(float price);
    }

    public class StudentDiscount : IDiscount
    {
        public float ApplyDiscount(float price)
        {
            return price * 0.8f;
        }
    }

    public class SeniorDiscount : IDiscount
    {
        public float ApplyDiscount(float price)
        {
            return price * 0.5f;
        }
    }

    public class SportsmenDiscount : IDiscount
    {
        public float ApplyDiscount(float price)
        {
            return price * 0.9f;
        }
    }

    public class Discount
    {
        private IDiscount _discount;

        public Discount(IDiscount discount)
        {
            _discount = discount;
        }

        public float ApplyDiscount(float price)
        {
            return _discount.ApplyDiscount(price);
        }
    }
}
