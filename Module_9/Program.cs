
using System.Net.Security;
using System.Runtime.InteropServices;

// Определяем делегат CalculateDelegate, который принимает два целочисленных аргумента и возвращает целочисленное значение.
 

class Program
{
    public delegate void TestDelegate(int a, int b);

    static void Main(string[] args)
    {
       /* TestDelegate testDelegate = CalculateSubtraction;
        testDelegate += CalculateAddition;
        testDelegate.Invoke(100, 200);

        Console.Read();*/
    }

    static void CalculateSubtraction(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    static void CalculateAddition(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}