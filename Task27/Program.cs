/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine ("Введите число");
string text = Console.ReadLine ();
int x = CheckForNumbers (text);
//int num = Convert.ToInt32(number);
if (x < 0)
{
    x = -x;
}
int a = text.Length;
Console.WriteLine (SumOfNum(x,a));
int SumOfNum (int N, int len) //считаем сумму цифр
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {   
        sum = sum + N%10;
        N=N/10;
    }
    return sum;
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
