namespace Calc.Entities
{
    public class Answer
    {
        public Answer(decimal result)
        {
            Result = result.ToString();
        }

        public string Result { get; set; }
    }
}
