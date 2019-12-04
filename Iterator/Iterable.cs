using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public abstract  class Iterable<T>
    {
        public abstract Iterator<T> Iterator();
    }
}
