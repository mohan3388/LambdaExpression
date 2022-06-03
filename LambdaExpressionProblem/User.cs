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
        
        string Mobile = "^[91]{2}[ ]{1}[0-9]{9,}$";
       
        public string FirstnameCheckusingLambda(string mobile) => Regex.IsMatch(mobile, Mobile) ? "Mobile is Valid" : "Mobile is not Valid";
    }
}
