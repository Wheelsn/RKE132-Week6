﻿//string[] fruit = { "apple", "banana", "orange"};
string[] fruit = new string[3];

fruit[0] = "apple";
fruit[1] = "banana";
fruit[2] = "orange";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}


foreach (string item in fruit)
{
    Console.WriteLine(item);

}
