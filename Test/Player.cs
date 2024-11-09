using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Player
    {
        public readonly string name;
        public readonly float speed;
        private string id = "";

        public Player(string name, float speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public void CallYourName()
        {
            Console.WriteLine("My name is " + name);
        }

        public string GetYourId()
        {
            if (id.Length == 0)
            {
                return "Error, id not found";
            }
            return id;
        }

        public void SetId(string newId)
        {
            if (newId.Length == 0 || newId.Length > 20)
            {
                Console.WriteLine("Error");
                return;
            }
            id = newId;
        }
    }
}
