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
        
        string Email = "^[0-9a-zA-z]+([._+-]?[0-9a-zA-z]+)@[0-9a-zA-z]+.([c]{1}[o]{1}[m]{1})([n]{1}[e]{1}[t]{1})[,]([a]{1}[u]{1})([.][c]{1}[o]{1}[m]{1})$";
       
        public string FirstnameCheckusingLambda(string email) => Regex.IsMatch(email, Email) ? "Email is Valid" : "Email is not Valid";
    }
}
