int commands = int.Parse(Console.ReadLine());

Dictionary<string, string> guestList = new();

for (int i = 1; i<= commands; i++)
{
    string[] guest = Console.ReadLine().Split().ToArray();
    string name = guest[1];
    string plateNum = guest[guest.Length - 1];

    if (guest[0] == "register")
    {
        if (!guestList.ContainsKey(name))
        {
            guestList.Add(name, plateNum);
            Console.WriteLine($"{name} registered {plateNum} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {plateNum}");
        }
    }
    else if (guest[0] == "unregister")
    {
        if (guestList.ContainsKey(name))
        {
            guestList.Remove(name);
            Console.WriteLine($"{name} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}
foreach (KeyValuePair<string, string> pair in guestList)
{
    Console.WriteLine(pair.Key + " => " + pair.Value);
}
