Console.WriteLine("I'm Roashan ");
Console.WriteLine("I'm Ranjana");


int[] numbers = [12, 7, 25, 18, 9];

int[] ranked = numbers.Distinct().OrderDescending().ToArray();
Console.WriteLine("Hi sir  Im Ameer!!!");

if (ranked.Length >= 2)
    Console.WriteLine($"Second largest: {ranked[1]}");
else
    Console.WriteLine("There is no second-largest distinct number.");