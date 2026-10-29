Console.WriteLine("I'm Roashan ");
Console.WriteLine("I'm Ranjana");
Console.WriteLine("I'm Janani");


int[] numbers = [12, 7, 25, 18, 9];

int[] ranked = numbers.Distinct().OrderDescending().ToArray();

if (ranked.Length >= 2)
    Console.WriteLine($"Second largest: {ranked[1]}");
else
    Console.WriteLine("Don't have enough unique numbers.");