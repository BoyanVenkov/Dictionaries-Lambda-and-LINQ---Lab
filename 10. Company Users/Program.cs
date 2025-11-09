Dictionary<string, List<string>> employees = new();

string[] input = Console.ReadLine().Split(" -> ").ToArray();

while (input[0] != "End")
{
    string company = input[0];
    string id = input[1];

    if (!employees.ContainsKey(company))
    {
        employees.Add(company, new List<string>());
    }
    if (!employees[company].Contains(id))
    {
        employees[company].Add(id);
    }

    input = Console.ReadLine().Split(" -> ").ToArray();
}

foreach (KeyValuePair<string, List<string>> pair in employees)
{
    Console.WriteLine(pair.Key);
    foreach (string id in pair.Value)
    {
        Console.WriteLine("-- " + id);
    }
}