Console.WriteLine("I'm Roashan ");
Console.WriteLine("I'm Ranjana");

Console.WriteLine("I'm Moulika");
Console.WriteLine("I'm Poornima");
Console.WriteLine("I'm Janani");
Console.WriteLine("I'm Madhusree");
Console.WriteLine("I'm MahaLakshmi");
Console.WriteLine("I'm DharshiniGanesa");
int[] numbers = [12, 7, 25, 18, 9];

int[] ranked = numbers.Distinct().OrderDescending().ToArray();
Console.WriteLine("Hi sir  Im Ameer!!!");
Console.WriteLine("Hi sir  Im Aruna!!!");

if (ranked.Length >= 2)
    Console.WriteLine($"Second largest: {ranked[1]}");
else
    Console.WriteLine("There is no second-largest distinct number.");