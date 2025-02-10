using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace IPv4Check
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ResourceManager rm = new ResourceManager("IPv4Check.Resources.Language", typeof(Program).Assembly);
            Console.WriteLine(rm.GetString("WelcomeMessage"));

            FormatChecking formatChecking = new FormatChecking();
            formatChecking.UserInputAdress();
        }

    }
    internal class FormatChecking
    {
        ResourceManager rm = new ResourceManager("IPv4Check.Resources.Language", typeof(Program).Assembly);

        public void UserInputAdress()
        {
            string inputIpvAdress = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputIpvAdress))
            {
                Console.WriteLine(rm.GetString("msg_invalidEmpty"));
                return;
            }

            // Need to split the user input to parts which can be further validated 
            string[] adress = inputIpvAdress.Split(".");


            if (isFourNumbers(adress) && IsInRange(adress) && HasNoLeadingZeros(adress))
            {
                Console.WriteLine(rm.GetString("msg_isValid"));
            }
            else
            {
                Console.WriteLine(rm.GetString("msg_isNotValid"));
            }

        }

        // Method for checking if the number is in range

        public bool IsInRange(string[] adress)
        {
            foreach (string adressPart in adress)
            {
                if (!int.TryParse(adressPart, out int number) || number < 0 || number > 255)
                {
                    return false;
                }

            }
            return true;


        }

        // Method for checking if array length is four, thus can be accepted as IPv4
        public bool isFourNumbers(string[] adress)
        {
            if (adress.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        // Method for checking if parts of the adress starts with zeroes while allowing single zero to be used
        public bool HasNoLeadingZeros(string[] adress)
        {
            foreach (string adressPart in adress)
            {
                if (adressPart.Length > 1 && adressPart.StartsWith("0"))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
/*
 * 
Requirements:
- A valid IPv4 address consists of four numbers separated by dots - done
- Each number must range from 0 to 255 - done
- Each number must not contain leading zeroes - done
*
*/

