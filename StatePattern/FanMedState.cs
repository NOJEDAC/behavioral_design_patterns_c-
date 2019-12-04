using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class FanMedState : State
    {

        private Fan fan;

        public FanMedState(Fan fan)
        {
            this.fan = fan;
        }


        public  void handleRequest()
        {
            Console.WriteLine("Turning fan on to high...");
            fan.setState(fan.getFanHighState());
        }

        public String toString()
        {
            return "Fan is on med.";
        }

    }
}
