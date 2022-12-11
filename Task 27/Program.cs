//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (a > 0)
{
  int num = a % 10;
  a = a / 10;
  sum = sum + num;
}
Console.WriteLine("Сумма цифр в числе равна: " + sum);
