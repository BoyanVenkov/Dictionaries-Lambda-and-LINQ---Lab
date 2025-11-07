string[] words = Console.ReadLine().Split();

Dictionary<string, int> oddWord = new();

foreach (string word in words)
{
    string wordWithLowerLetter = word.ToLower();
    if (!oddWord.ContainsKey(wordWithLowerLetter))
    {
        oddWord.Add(wordWithLowerLetter, 1);
    }
    else
    {
        oddWord[wordWithLowerLetter]++;
    }
}
foreach (KeyValuePair<string, int> pair in oddWord)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write(pair.Key + " ");
    }
}