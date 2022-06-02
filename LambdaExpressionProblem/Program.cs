using System.Text.RegularExpressions;

namespace LambdaExpressionProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter Lastname");
            string lastName = Console.ReadLine();
            User valid = new User();
            string output = valid.FirstnameCheckusingLambda(lastName);
            if(output == "LastName is Valid")
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}