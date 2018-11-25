using System;

namespace ConsoleApp1
{
    class Car
    {
        private int carspeed;
        private int deacceleration;
        private bool stop=true;

        public int CarSpeed
        {
            get { return carspeed; }
            set
            {
                if (CarSpeed>=0)
                {
                    carspeed = value;
                }
            }
        }

        public int Deacceleration
        {
            get { return deacceleration; }
            set
            {
                if (deacceleration >= 0)
                    deacceleration = value;
            }
        }




        public bool Stop
        {
            get { return stop; }
            set
            {
                if (stop)
                    stop = value;
            }
        }



        public string Getinfo()
        {
            return $"car speed:{CarSpeed}\ncar deaccelaration:{Deacceleration}\ncar stop:{Stop}";
        }

    }
}
