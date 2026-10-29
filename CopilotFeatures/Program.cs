Console.WriteLine("I'm Roashan ");
Console.WriteLine("I'm Ranjana");
Console.WriteLine("I'm Poornima");
Console.WriteLine("I'm Janani");
Console.WriteLine("I'm Madhusree");
Console.WriteLine("I'm MahaLakshmi");

=======
Console.WriteLine("I'm DharshiniGanesa");
>>>>>>> 169b856c19df4903ec0b51c4fa86f6ed608ef62a
int[] numbers = [12, 7, 25, 18, 9];

int[] ranked = numbers.Distinct().OrderDescending().ToArray();

if (ranked.Length >= 2)
    Console.WriteLine($"Second largest: {ranked[1]}");
else
    Console.WriteLine("Don't have enough unique numbers.");