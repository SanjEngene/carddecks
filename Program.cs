
string[] content;
ReadFromFile(out content, @"C:\Users\User\source\repos\ConsoleApp3\ConsoleApp3\input.txt");
int[] eachDeck = new int[(int.Parse(content[1]) - int.Parse(content[0])) + 1];
int firstNumber = int.Parse(content[0]);
for (int i = 0; i < eachDeck.Length; i++)
{
    eachDeck[i] = firstNumber + i;
    Console.WriteLine(eachDeck[i]);
}
int countOfProcess = 0;
for (int i = 0; i < eachDeck.Length; i++)
{
    while (eachDeck[i] > 2)
    {
        Console.WriteLine(eachDeck[i]);
        if (eachDeck[i] % 2 == 0)
        {
            eachDeck[i] = eachDeck[i] / 2;
        }
        else
        {
            eachDeck[i] = eachDeck[i] * 3 + 1;
        }
        countOfProcess++;
    }
}
WriteToFile(countOfProcess.ToString(), @"C:\Users\User\source\repos\ConsoleApp3\ConsoleApp3\output.txt");

static string[] ReadFromFile(out string[] args, string filePath)
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        args = sr.ReadToEnd().Split(" ");
    }
    return args;
}
static void WriteToFile(string output, string filePath)
{
    using (StreamWriter sw = new StreamWriter(filePath, false))
    {
        sw.Write(output);
    }
}

