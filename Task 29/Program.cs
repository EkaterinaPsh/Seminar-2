//Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. После записи элементов в массив, необходимо его вывести на экран.


Console.Write("Введите кол-во элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите элемент массива под индексом {i}: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Вывод массива: ");

Console.WriteLine($"[{string.Join(", ", array)}]");



