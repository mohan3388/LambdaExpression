using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaExpressionProblem
{
    internal class User
    {
        
        string Lastname = "^[A-Z]{1}[a-z]{2,}";
       
        public string FirstnameCheckusingLambda(string lastName) => Regex.IsMatch(lastName, Lastname) ? "LastName is Valid" : "LastName is not Valid";
    }
}
