using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    public class Client
    {
        static void Main(String[] args)
        {
            Fan fan = new Fan();
            Console.WriteLine(fan);
            fan.pullChain();
            Console.WriteLine(fan);
            fan.pullChain();
            Console.WriteLine(fan);
            fan.pullChain();
            Console.WriteLine(fan);
            fan.pullChain();
            Console.WriteLine(fan);
            Console.Read();
        }
    }
}
