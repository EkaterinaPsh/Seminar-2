// Double Numbers

/*
Console.Write("введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
  // умножение это: (end - begin) + begin
  array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // [10, 50] 
}

Console.WriteLine($"[{string.Join(", ", array)}]"); */

//Functions
//Необходимо вывести наибольшее число из 2-х

/*
int test(int a, int b) // test - это наша функция 
{
  if (a > b)
    return a;
  return b;
}

Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine);

Console.WriteLine("Введите 2 число: ");
int a = Convert.ToInt32(Console.ReadLine);

Console.WriteLine(test(a, b));

// 1. return 
//    *возвращает  аргумент туда, где была вызвана функция
//    *завершает работу функции
//    *вовращаемое значение необходимо принимать в консоль(вывод) или в переменную нужного типа данных 
//    *Сколько аргументов мы принимаем - столько и передаем 
*/



//void 


/*
void test(int a)
{
  a += 5;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine);

test(n);

Console.WriteLine(n);
*/

//ЗАДАЧИ

//Task 24 

// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

/*
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n);
*/


//Task 26

//Напишите программу, которая принимает на вход число и выдает количество цифр в числе

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
  count++;
  n /= 10;
}

Console.WriteLine(count);

*/


//Task 28

//Напишите программу, оторая принимает на вход число N и выдает произведение чисел от 1 до N

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 2; i <= n; i++)
  result = result * i;
Console.WriteLine(result);
*/

// Task 30

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке 


Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(0, 2); // [0, 1]
Console.WriteLine($"[{string.Join(", ", array)}]");