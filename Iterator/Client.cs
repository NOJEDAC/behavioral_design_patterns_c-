using System;

namespace Iterator
{
    class Client
    {
        static void Main(string[] args)
        {
            ConcreteAggregateList<Question> myCustomList = new ConcreteAggregateList<Question>();
            myCustomList.Add(new Question("Q1", 1));
            myCustomList.Add(new Question("Q2", 2));
            myCustomList.Add(new Question("Q3", 3));
            Iterator<Question> iterator = myCustomList.Iterator();
            while (iterator.HasNext())
            {
                Question question = iterator.Next();
                Console.WriteLine(question.Number + " => " + question.Description);
            }
            Console.ReadLine();
        }
    }
}
