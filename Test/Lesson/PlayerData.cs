using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson
{
    public class PlayerData
    {
        private string id;
        private float speed = 100;

        public string GetId()
        {
            return id;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            if (speed < 0)
            {
                this.speed = 0;
            }
            else if (speed > 150)
            {
                this.speed = 150;
            }
            else
            {
                this.speed = speed;
            }
            
        }
    }
}
