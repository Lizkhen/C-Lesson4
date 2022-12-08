/*Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

Console.WriteLine ("Введите любое число");
string? a = Console.ReadLine();;
int A = CheckForNumbers (a);
Console.WriteLine ("Теперь введите науральное число");
string? b = Console.ReadLine();;
int B= CheckForNumbers (b);
{
if (B > 0)
    Console.WriteLine (Degree(A,B));
else
    Console.WriteLine("Необходимо ввести НАТУРАЛЬНОЕ число!");
}
int Degree( int number, int pow ) // Нахожу число в степени
{  int result = 1;
    for(int i = 1; i <= pow; i++)
    {
        result *= number;
    }
    return (result);
}

  int CheckForNumbers(string str)  // Число ввели или нет?
{
    if (int.TryParse(str, out int num))
    {
       num = Convert.ToInt32(str);
    }
    else 
        {
            Console.WriteLine ("Это не число!");
        Environment.Exit(0);
        }
    return num;
    
} 