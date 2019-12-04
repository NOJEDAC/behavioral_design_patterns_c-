using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class FanLowState : State
    {
        private Fan fan;

        public FanLowState(Fan fan)
        {
            this.fan = fan;
        }

        
        public  void handleRequest()
        {
            Console.WriteLine("Turning fan on to med.");
            fan.setState(fan.getFanMedState());
        }

        public String toString()
        {
            return "Fan is low.";


        }
    }
}
