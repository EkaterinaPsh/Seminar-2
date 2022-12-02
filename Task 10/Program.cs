// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int n = new Random().Next(100, 1000);

Console.WriteLine(n);

int n1 = n % 100;
int n2 = n1 / 10;

Console.WriteLine(n2);