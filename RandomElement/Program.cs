string[] snacks = { "chips", "popcorn", "chocolate", "pizza", "nuts" };
Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"You will eat {snacks[randomIndex]}");