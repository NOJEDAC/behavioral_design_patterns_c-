using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public abstract class Iterator<T>
    {
        public abstract bool HasNext();
        public abstract T Next();
    }
}
