using System.Linq.Expressions;
using System.Text.RegularExpressions;

string confirm;
do
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Enter binary input to verify:");
    string input = Console.ReadLine();
    ValidateBinary(input);

    Console.WriteLine(""); 
    Console.WriteLine("Do you want to continue: Y/N"); 
    confirm = Console.ReadLine();
} while (!string.IsNullOrEmpty(confirm) && confirm.Equals("y", StringComparison.CurrentCultureIgnoreCase));


void ValidateBinary(string value)
{
    if (string.IsNullOrEmpty(value))
    { Console.WriteLine("Input is empty");
        return;
    }

    bool isBianry = Regex.IsMatch(value, "^[01]+$");
    if (!isBianry)
    {
        Console.WriteLine("Input is not binary");
        return;
    }

    int zeroCount = 0, oneCount = 0;
    for (int i = 0; i < value.Length; i++)
    { 
        if (value[i] == '0')
            zeroCount++;
        else if (value[i] == '1')
            oneCount++;
    }

    if (zeroCount != oneCount)
    {
        Console.WriteLine("Input is not binary");
        return;
    }

    Console.WriteLine("Input is binary string");
}