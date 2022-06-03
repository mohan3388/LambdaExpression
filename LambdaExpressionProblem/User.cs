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
        
        string Password = "^[$#@%&^_.]{1}[0-9A-Za-z]{7,}$";
       
        public string FirstnameCheckusingLambda(string password) => Regex.IsMatch(password, Password) ? "Password is Valid" : "Password is not Valid";
    }
}
