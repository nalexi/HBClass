using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPFRegEx.Controller
{
    public class Validates
    {
        public static bool ValidEmail(string email)
        {
            var regExStringEmail = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                 + "@"
                                 + @"((([\w]+([-\w]*[\w]+)*\.)+[a-zA-Z]{2,4})|"
                                 + @"((([01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]).){3}[01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]))\z";

            Regex regexMail = new Regex(regExStringEmail);


            return regexMail.IsMatch(email);
        }

        public static bool ValidPhone(string telefone)
        {
            var regExTelefone = @"^(?:(55\d{2})|\d{2})[6-9]\d{8}$";

            Regex regexPhone = new Regex(regExTelefone);


            return Regex.IsMatch(telefone, regExTelefone);

        }
    }
}
