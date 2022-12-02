//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
long number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
  Console.WriteLine("Это двузначное число, третьей цифры нет/nВведите число");
  number = Convert.ToInt32(Console.ReadLine());
}
else
{
  while (number >= 1000)
  {
    number = number / 10;
  }
  Console.WriteLine($"Третья цифра числа = {number % 10}");
}