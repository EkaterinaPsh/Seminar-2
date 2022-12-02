// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели цифрой: ");
int day = Convert.ToInt32(Console.ReadLine());

while (day < 1 || day > 7)
{
  System.Console.Write("Вы ошиблись!\nВведите день недели цифрой: ");
  day = Convert.ToInt32(Console.ReadLine());
}

if (day >= 1 && day <= 5)
{
  Console.WriteLine("Нет, этот день является рабочим");
}
else
{
  Console.WriteLine("Да, этот день являтся выходным");
}
