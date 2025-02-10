using System;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is your numbers combination valid for a IPV4?");

       FormatChecking formatChecking = new FormatChecking();
        formatChecking.UserInputAdress();
    }

}
internal class FormatChecking
{
    public void UserInputAdress()
    {
        string inputIpvAdress = Console.ReadLine();

        // Need to split the user input 
        string[] adress = inputIpvAdress.Split(".");

        
        if (isFourNumbers(adress) && IsInRange(adress) && HasNoLeadingZeros(adress))
        {
            Console.WriteLine("Adress IS valid IPv4!.");
        }
        else
        {
            Console.WriteLine("Adress IS NOT valid IPv4!");
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

/*
 * 
Requirements:
- A valid IPv4 address consists of four numbers separated by dots - done
- Each number must range from 0 to 255 - done
- Each number must not contain leading zeroes - done
*
*/

