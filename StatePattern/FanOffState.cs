using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class FanOffState : State
    {
        private Fan fan;

        public FanOffState(Fan fan)
        {
            this.fan = fan;
        }

       
    public  void handleRequest()
        {
            Console.WriteLine("Turning fan on to low.");
            fan.setState(fan.getFanLowState());
        }

        public String toString()
        {
            return "Fan is off.";
        }





    }
}
