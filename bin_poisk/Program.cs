//вычислить корень любой степени из любого числа до 5 степени(целую часть)
using System;
using System.Runtime.InteropServices;

int bad_stepen (int x, int n)
{
    int itog = 1;
    for (int i = 0; i < n; i++) itog = itog * x;
    return itog;
}
float stepen(float x, float n)
{
    if (n == 0) return 1;
    float k;
    if (n % 2 == 0)
    {
        k = stepen(x, n / 2);
        return k * k;
    }
    else
    {
        k = stepen(x, (n - 1) / 2);
        return x * k * k;
    }
}


int a; //меньше 5
int n;
a = Convert.ToInt32(Console.ReadLine());
if (a > 5)
{
    return;
}
n = Convert.ToInt32(Console.ReadLine());

float epsilon = 0.000001F;
double _epsilon = 10000;
float begin = 1, end = n;
float midle = (begin + end) / 2;
while (stepen(midle,a)!=n && end-begin>epsilon)
{
    float  t = stepen (midle,a);
    if (t == n) 
    {
        break;
    }
    if (t > n)
    {
        end = midle;
    }
    if (t < n)
    {
        begin = midle;
    }
    midle = (begin + end) / 2;
}
//double result = Convert.ToInt32(midle * _epsilon) / _epsilon;
double result = Math.Round(midle, 6);
Console.Write(result);
