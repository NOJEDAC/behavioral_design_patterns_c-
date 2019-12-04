using System.Collections.Generic;

namespace Iterator
{
    public class ConcreteIteratorList<T> : Iterator<T>
    {
        List<T> list = new List<T>();
        private int currentPosition;
        public ConcreteIteratorList(List<T> list)
        {
            this.list = list;
            currentPosition = list.ToArray().Length - 1;
        }

        public override bool HasNext()
        {
            return currentPosition >= 0 && list[currentPosition] != null;
        }

        public override T Next()
        {
            return list[currentPosition--];
        }
    }
}
