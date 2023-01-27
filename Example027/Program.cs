/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber()
{
    int result = 0;

    while(true)
    {
        Console.WriteLine("Введите любое целое положительное число");

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не подходящее число. Повторите ввод");
        }
    }

    return result;
}

int number = GetNumber();

int GetSum()
{
int sum = 0;

while (number != 0)
{
    sum += number % 10;
    number /= 10;
}
return sum;
}

int sum = GetSum();

Console.WriteLine("Сумма цифр в числе: " + sum);


