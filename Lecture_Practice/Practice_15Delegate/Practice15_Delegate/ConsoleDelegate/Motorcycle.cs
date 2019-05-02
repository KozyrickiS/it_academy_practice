using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    delegate void MotorcycleNotifyHandler(string message);

    class Motorcycle
    {
        private int _odometer;
        private MotorcycleNotifyHandler _handler;
        public int Odometer
        {
            get
            {
                return _odometer;
            }
            set
            {
                _odometer = value;
            }
        }

        public void RegisterHandler(MotorcycleNotifyHandler @delegate)
        {
            _handler = @delegate;
        }

        public void Move(int km)
        {
            Odometer += km;

            if (Odometer >= 10000)
            {
                if (_handler != null)
                {
                    _handler("Your bike needs a HealthCare");
                }
                //Console.WriteLine("Your bike needs a HealthCare");
            }
        }
    }
}
