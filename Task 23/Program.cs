﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{
  Console.Write($"{i * i * i} ");
} */

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
  Console.Write($"{i * i * i} ");

