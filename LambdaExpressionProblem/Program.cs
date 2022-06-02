using System.Text.RegularExpressions;

namespace LambdaExpressionProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter firstname");
            string firstname = Console.ReadLine();
            User valid = new User();
            string output = valid.FirstnameCheckusingLambda(firstname);
            if(output == "FirstName is Valid")
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