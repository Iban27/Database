using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu
{
    public class User
    {
        public string name;
        public int age;
        public float weight;

        public string GetName => name;
        public int GetAge => age;
        public float GetWeight => weight;


        public User(string name, int age, float weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }


    }
}
