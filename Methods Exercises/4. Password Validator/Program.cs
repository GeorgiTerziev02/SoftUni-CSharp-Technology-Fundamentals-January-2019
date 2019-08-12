using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            IsPassValid(pass);
            bool isValid = IsPassValid(pass);
            bool letOrDig = LetterOrDigit(pass);
            bool atleastTwo = AtleastTwoDigits(pass);
            if (isValid == false) { Console.WriteLine("Password must be between 6 and 10 characters"); }
            if (letOrDig == false) { Console.WriteLine("Password must consist only of letters and digits"); }
            if (atleastTwo == false) { Console.WriteLine("Password must have at least 2 digits"); }
            if (isValid == true && letOrDig == true && atleastTwo == true)
            { Console.WriteLine("Password is valid"); }
        }

        static bool IsPassValid(string password)
        {
            if (password.Length > 10 || password.Length < 6) return false;
            else return true;
        }
        static bool LetterOrDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i])) return false;
            }
            return true;
        }
        static bool AtleastTwoDigits(string password)
        {
            int br = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i])) br++;
            }
            if (br >= 2) return true;
            else return false;
        }
    }
}
