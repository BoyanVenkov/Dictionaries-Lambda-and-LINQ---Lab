List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

SortedDictionary<int, int> countOccurances = new();

foreach (int num in numbers)
{
    if (countOccurances.ContainsKey(num))
    {
        countOccurances[num]++;
    }
    else
    {
        countOccurances.Add(num, 1);
    }
}
foreach (KeyValuePair<int, int> pair in countOccurances)
{
    Console.WriteLine(pair.Key + " -> " + pair.Value);
}
