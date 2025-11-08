int countWords = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> wordSynonims = new();

for (int i = 1; i <= countWords; i++)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();

    if (!wordSynonims.ContainsKey(word))
    {
        wordSynonims.Add(word, new List<string> { synonim });
    }
    else
    {
        wordSynonims[word].Add(synonim);
    }
}
foreach (KeyValuePair<string, List<string>> pair in wordSynonims)
{
    Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));

}