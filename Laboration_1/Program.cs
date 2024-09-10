// Laboration_1: Algoritmer

Console.Write("Please write some text: ");
string userInput = Console.ReadLine();     
Console.WriteLine();

ulong sum = 0;
for (int i = 0; i < userInput.Length; i++)
{
    string substring = string.Empty;
    char firstSubstringNumber = userInput[i];

    if (!Char.IsDigit(firstSubstringNumber)) 
    {
        continue;
    }

    substring += firstSubstringNumber;

    for (int j = i + 1; j < userInput.Length; j++)
    {
        char nextSubstringNumber = userInput[j];

        if (!Char.IsDigit(nextSubstringNumber))
        {
            break;
        }

        substring += nextSubstringNumber;

        if (firstSubstringNumber == nextSubstringNumber)
        {
            PrintUserInput(i, j, userInput, substring);

            ulong number = ulong.Parse(substring);
            sum += number;
            break;   
        }
    }
}
Console.WriteLine();
Console.WriteLine($"The sum of all colored numbers is: {sum}");

static void PrintUserInput (int firstSubstringNumberIndex, int lastSubstringNumberIndex, string input, string substring)
{
    Console.Write(input[0..firstSubstringNumberIndex]);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(substring);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine(input[(lastSubstringNumberIndex + 1)..]);                                                   
}