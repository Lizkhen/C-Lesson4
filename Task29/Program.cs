/* Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.   */

Random random = new Random();
Console.WriteLine (ResultArray(random));

string ResultArray (Random random)
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length ; i++)
    {
        array [i] = random.Next (-50,50);
    }
    string result;
    return result = string.Join(" ",array);
}