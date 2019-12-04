using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class Fan
    {

        State fanOffState;
        State fanLowState;
        State fanMedState;
        State fanHighState;

        State state;

        public Fan()
        {
            fanOffState = new FanOffState(this);
            fanLowState = new FanLowState(this);
            fanMedState = new FanMedState(this);
            fanHighState = new FanHightState(this);

            state = fanOffState;
        }

        public void pullChain()
        {
            state.handleRequest();
        }

        public String toString()
        {
            return state.ToString();
        }

        public State getFanOffState()
        {
            return fanOffState;
        }

        public State getFanLowState()
        {
            return fanLowState;
        }

        public State getFanMedState()
        {
            return fanMedState;
        }

        public State getFanHighState()
        {
            return fanHighState;
        }

        public void setState(State state)
        {
            this.state = state;
        }
    }
}
