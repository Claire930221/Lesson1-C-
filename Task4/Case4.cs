/*Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


Console.WriteLine("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1>n2) 
{
    if (n1>n3)
    {
        Console.WriteLine("max: " + n1 );
    }
}

if (n2>n1) 
{
    if (n2>n3)
    {
        Console.WriteLine("max: " + n2 );
    }
}

if (n3>n2) 
{
    if (n3>n1)
    {
        Console.WriteLine("max: " + n3 );
    }
}
