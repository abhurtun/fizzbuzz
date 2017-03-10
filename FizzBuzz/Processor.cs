using System.Text;

namespace FizzBuzz
{
    public class Processor
    {
        public string GetValue(int input)
        {
            var builder = new StringBuilder();

            if (input % 3 == 0)
            {
                builder.Append("Fizz");
            }

            if (input % 5 == 0)
            {
                builder.Append("Buzz");
            }

            if (builder.Length == 0)
            {
                builder.Append(input.ToString());
            }

            return builder.ToString();
        }
    }
}
