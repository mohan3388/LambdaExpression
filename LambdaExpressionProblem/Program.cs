using System.Text.RegularExpressions;

namespace LambdaExpressionProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            User valid = new User();
            string output = valid.FirstnameCheckusingLambda(email);
            if(output == "Email is Valid")
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