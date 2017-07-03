using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Speedometer
    {
        private int currentSpeed;

        public int GetCurrentSpeed()
        {
            return currentSpeed;
        }

        public void SetCurrentSpeed(int speed)
        {
            if (speed < 0) return;
            if (speed > 120) return;

            currentSpeed = speed;
        }
    }

    class Speedometer2
    {
        private int currentSpeed;

        public int CurrentSpeed
        {
            get
            {
                return currentSpeed;
            }
            set
            {
                if (value < 0) return;
                if (value > 120) return;

                currentSpeed = value;
            }
        }
    }
}
