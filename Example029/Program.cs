/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] InitArray(int dimension)
{
  int[] array = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    array[i] = rnd.Next(0, 1000);
  }
  return array;
}

int [] array = InitArray(8);
Console.WriteLine(string.Join(", ", array));