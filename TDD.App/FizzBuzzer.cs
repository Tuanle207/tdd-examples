
using System.Text;

namespace TDD.App
{
    public class FizzBuzzer
    {
        // TODO: Write code here
        public string FizzBuzz(int input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (input % 15 == 0)
            {
                stringBuilder.Append("FizzBuzz");
            }
            else if(input % 3 == 0)
            {
                stringBuilder.Append("Fizz");
            }
            else if (input % 5 == 0)
            {
                stringBuilder.Append("Buzz");
            }
            else  stringBuilder.Append(input);

            return stringBuilder.ToString();
        }
    }
}
