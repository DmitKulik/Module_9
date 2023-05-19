
using System.Net.Security;
using System.Runtime.InteropServices;

// Определяем делегат CalculateDelegate, который принимает два целочисленных аргумента и возвращает целочисленное значение.
delegate int CalculateDelegate(int a, int b);


class Program
{
    
    static void Main(string[] args)
    {
        // 1 способ вызова делигата. Создаем экземпляр делегата CalculateDelegate, связывая его с методом Calculate.
        CalculateDelegate calcDelegate = Calculate;
        int result = calcDelegate.Invoke(100, 30);
        Console.WriteLine(result);
        Console.Read();


        // 2 способ вызова делигата. Создаем экземпляр делегата CalculateDelegate, связывая его с методом Calculate.
        CalculateDelegate calcDelegate2 = Calculate;
        int result2 = calcDelegate(100, 30); // разница в методе .Invoke
        Console.WriteLine(result);
        Console.Read();


    }

    // Определяем статический метод Calculate, который принимает два целочисленных аргумента и возвращает разность первого и второго аргументов.
    static int Calculate(int a, int b)
    {
        return a - b;
    }
}