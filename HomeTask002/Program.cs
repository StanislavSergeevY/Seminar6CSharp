// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1 и y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5,
// b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] InputValues()
{
  double[] ValuesArray = new double[4];
  string[] VariablesArray = { "b1", "k1", "b2", "k2" };
  for (int i = 0; i < ValuesArray.Length; i++)
  {
    Console.Write($"Пожалуйста, введите значение '{VariablesArray[i]}': ");
    ValuesArray[i] = Convert.ToDouble(Console.ReadLine());
  }
  Console.WriteLine($"{string.Join(", ", ValuesArray)}");
  return ValuesArray;
}

void Procedure(double[] array)
{
  if (array[1] != array[3])
  {
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    double y = array[1] * (array[2] - array[0]) / (array[1] - array[3]) + array[0];
    Console.WriteLine($"Прямые пересекутся в кооридинатах: (x = {x} ; y = {y})");
  }
  else
    Console.WriteLine($"Прямые не пересекаются!");
}

Console.Clear();
Procedure(InputValues());