using System.Collections.Generic;

namespace Iterator
{
    public class ConcreteAggregateList<T> : Iterable<T>
    {
        List<T> list = new List<T>();
        public ConcreteAggregateList()
        {
        }
        public ConcreteAggregateList(List<T> list)
        {
            this.list = list;
        }
        public void Add(T item)
        {
            list.Add(item);
        }
        public override Iterator<T> Iterator()
        {
            return new ConcreteIteratorList<T>(list);
        }
    }
}
