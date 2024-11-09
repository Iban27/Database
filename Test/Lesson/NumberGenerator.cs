using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson
{
    public class NumberGenerator
    {
        public int[] numbers;

        public NumberGenerator()
        {
            numbers = new int[15]
            {
                1, 2, 6, 8, 12, 27, 37, 67, 90, 122, 144, 166, 10000, 2, 0
            };
        }
    }
}
