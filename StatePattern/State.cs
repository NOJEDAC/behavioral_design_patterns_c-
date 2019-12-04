using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public abstract class State
    {
        public void handleRequest()
        {
            Console.WriteLine("Shouldn't be able to get here.");
        }
    }
}
