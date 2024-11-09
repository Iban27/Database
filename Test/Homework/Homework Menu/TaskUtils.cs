using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu
{
    public static class TaskUtils
    {
        public static void ShowText(string text, bool upper = false, bool bottom = false)
        {
            if (upper) Console.WriteLine();
            Console.WriteLine(text);
            if (bottom) Console.WriteLine();
        }

        public static string GetInputString()
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) == false)
            {
                return input;
            }
            throw new Exception("Некорректный ввод данных");
        }

        public static int GetInputInt()
        {
            if (int.TryParse(Console.ReadLine(), out int inputInt))
            {
                return inputInt;
            }
            throw new Exception("Некорректный ввод данных");
        }

        public static float GetInputFloat()
        {
            if (float.TryParse(Console.ReadLine(), out float inputFloat))
            {
                return inputFloat;
            }
            throw new Exception("Некорректный ввод данных");
        }
    }
}
