Console.WriteLine("Enter a string => ");
string inputString = Console.ReadLine();
if (!string.IsNullOrEmpty(inputString))
{
    string resultString = inputString.ToUpper();

    Console.WriteLine("Result:");
    Console.WriteLine(resultString);
}
else
{
    Console.WriteLine("Error: Input string is null.");
}