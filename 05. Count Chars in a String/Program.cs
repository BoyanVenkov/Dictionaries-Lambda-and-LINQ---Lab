string text = Console.ReadLine();

Dictionary<char, int> symbols = new Dictionary<char, int>();

foreach (char symbol in text)
{
    if (symbol == ' ')
    {
        continue;
    }

    if (!symbols.ContainsKey(symbol))
    {
        symbols.Add(symbol, 1);
    }
    else
    {
        symbols[symbol]++;
    }
}
foreach (KeyValuePair<char, int> pair in symbols)
{
    Console.WriteLine(pair.Key + " -> " + pair.Value);

}