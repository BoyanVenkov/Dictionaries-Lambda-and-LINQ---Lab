using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> students = new();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students[name] = new List<double>();
    }

    students[name].Add(grade);
}

Dictionary<string, double> filtered = students
    .Where(s => s.Value.Average() >= 4.50)
    .ToDictionary(s => s.Key, s => s.Value.Average());

foreach (var student in filtered)
{
    Console.WriteLine($"{student.Key} -> {student.Value:F2}");
}
