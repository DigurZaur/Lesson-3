//                               a x b
// Вычислите значение формулы   ------- , где
//                               c + d
// a, b, c, d - целые числа. Решение в виде функции.

using System.Runtime.InteropServices;

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    double denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

System.Console.WriteLine((CalculateFormula(1, 2, 2, 1)));