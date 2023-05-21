using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailSample
{
    public class MyPattern
    {

        public  string email = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";


        public string ValidateEmailName(string data)
        {
            string result = Regex.IsMatch(data, email) ? "Valid" : "Invalid";
            return result;

        }
    }
}