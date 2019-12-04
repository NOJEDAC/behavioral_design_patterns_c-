using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class FanHightState : State
    {
        private Fan fan;

        public FanHightState(Fan fan)
        {
            this.fan = fan;
        }

       
    public  void handleRequest()
        {
            Console.WriteLine("Turning fan off...");
            fan.setState(fan.getFanOffState());
        }

        public String toString()
        {
            return "Fan is on high.";
        }

    }
}
