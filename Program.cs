
Console.WriteLine("+++ START +++\n\n");

int[] arrayOfInt = new int[100];
Random random = new Random();

for (int i = 0; i < arrayOfInt.Length; i++)
{
    arrayOfInt[i] = random.Next(20, 41);
}

Dictionary<int, int> occurrences = new Dictionary<int, int>();

foreach (int number in arrayOfInt)
{
    if (occurrences.ContainsKey(number))
    {
        occurrences[number]++;
    }
    else
    {
        occurrences[number] = 1;
    }
}

Console.WriteLine("Number occurrences of each unique number:\n\n");

foreach (var entry in occurrences)
{
    Console.WriteLine($"{entry.Key}: {entry.Value} occurences");
}

Console.WriteLine("\n\n+++ END +++");
