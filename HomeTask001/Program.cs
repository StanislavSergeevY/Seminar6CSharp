// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Count(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] > 0) count++;
  return count;
}

Console.Clear(); Console.WriteLine("Enter numbers separated by spaces: ");
int[] ArrayNumer = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(Count(ArrayNumer));