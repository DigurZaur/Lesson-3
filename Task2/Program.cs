// Функция для вывода квадратов чисел от 1 до N

void square(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}
square(5);
System.Console.WriteLine();
square(10);
System.Console.WriteLine();
square(15);