using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, (double price, double quantity)> products = new();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] parts = input.Split(' ');
            string name = parts[0];
            double price = double.Parse(parts[1]);
            double quantity = double.Parse(parts[2]);

            if (!products.ContainsKey(name))
            {
                products[name] = (price, quantity);
            }
            else
            {
                var current = products[name];
                double newQuantity = current.quantity + quantity;
                double newPrice = price;
                products[name] = (newPrice, newQuantity);
            }
        }

        foreach (var item in products)
        {
            string name = item.Key;
            double totalPrice = item.Value.price * item.Value.quantity;

            Console.WriteLine($"{name} -> {totalPrice:F2}");
        }
    }
}