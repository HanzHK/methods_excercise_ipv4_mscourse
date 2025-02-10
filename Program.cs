using System;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
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

        // Placeholder test if it splits correctly
        foreach (string test in adress)
        {
            Console.WriteLine(test);
        }
    }

    // Method for checking if the number is in range
    //TODO: Number musí projít celé číslo po částech, rozdělené tečkami, number tedy musí být pole 4 čísel
    public void IsInRange(string[] adress)
    {
        foreach (string adressPart in adress)
        {
            if (!int.TryParse(adressPart, out int number) || number < 0 || number > 255)
            {
                Console.WriteLine($"Část '{adressPart}' nevyhovuje (není číslo nebo není v rozsahu 0-255).");
                return;
            }

        }

        Console.WriteLine("Adresa je v platném rozsahu.");

    }

    public bool isFourNumbers()
    {
        return false;
    }

}

/*
 * 
Requirements:
- A valid IPv4 address consists of four numbers separated by dots
- Each number must range from 0 to 255
- Each number must not contain leading zeroes
*
*/

