namespace Iterator
{
    public class Question
    {
        public string Description { get; set; }
        public int Number { get; set; }

        public Question(string description, int number)
        {
            this.Description = description;
            this.Number = number;
        }

       
    }
}
