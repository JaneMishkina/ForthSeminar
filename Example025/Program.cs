/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());


int GetNumber()
{
    int result = 0;

    while(true)
    {
        Console.WriteLine("Введите натуральное число");

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не натуральное число. Повторите ввод");
        }
    }

    return result;
}

int b = GetNumber();

Console.WriteLine("Число " + a + " в степени " + b + " = " + Math.Pow(a,b));

