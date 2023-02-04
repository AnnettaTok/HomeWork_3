/* Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}


int number = GetNumber("Введите пятизначное число ");
    
    if (number%10 == number/10000 && (number/10)%10 == (number/1000)%10)
    Console.WriteLine("Полидром");
    else
    Console.WriteLine("Не полидром");





