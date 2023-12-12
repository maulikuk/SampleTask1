using BinaryAnalysis;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

string confirm;
do
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Enter binary input to verify:");
    string input = Console.ReadLine();
    VerifyBinary verifyBinary = new VerifyBinary();
    verifyBinary.ValidateBinary(input);

    Console.WriteLine(""); 
    Console.WriteLine("Do you want to continue: Y/N"); 
    confirm = Console.ReadLine();
} while (!string.IsNullOrEmpty(confirm) && confirm.Equals("y", StringComparison.CurrentCultureIgnoreCase));
