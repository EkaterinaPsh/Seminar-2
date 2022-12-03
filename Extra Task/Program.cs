// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.WriteLine("Введите последовательность чисел ");

int number = Convert.ToInt32(Console.ReadLine());

int max = 0;
int max1 = 0;


while (number != 0)
{
  number = Convert.ToInt32(Console.ReadLine());
  if (number > max)
  {
    max1 = max;
    max = number;
  }
  else if (number > max1)
  {
    max1 = number;
  }
}


System.Console.WriteLine("Второй по величине элемент в заданной вами последовательности = " + max1);
