
using System.Net.Security;
using System.Runtime.InteropServices;


public class Program
{
    // Определяем делегат, который не принимает аргументы и не возвращает значения
    delegate void ShowMessageDelegate();
    // Определяем делегат, который принимает три аргумента типа int и возвращает значение типа int
    delegate int SumDelegate(int a, int b, int c);
    // Определяем делегат, который принимает один аргумент типа string и возвращает значение типа bool
    delegate bool CheckLengthDelegate(string row);

    static void Main(string[] args)
    {
        // Создаем экземпляр делегата ShowMessageDelegate и присваиваем ему метод ShowMessage
        Action showMessageDelegate = ShowMessage;
        // Вызываем метод Invoke у делегата для выполнения метода ShowMessage
        showMessageDelegate.Invoke();

        // Создаем экземпляр делегата SumDelegate и присваиваем ему метод Sum
        Func<int, int, int, int> sumDelegate = Sum;
        // Вызываем метод Invoke у делегата для выполнения метода Sum с аргументами 1, 30, 120
        int result = sumDelegate.Invoke(1, 30, 120);
        Console.WriteLine(result);

        // Создаем экземпляр делегата CheckLengthDelegate и присваиваем ему метод CheckLength
        Predicate<string> checkLengthDelegate = CheckLength;
        // Вызываем метод Invoke у делегата для выполнения метода CheckLength с аргументом "skill_factory"
        bool status = checkLengthDelegate.Invoke("skill_factory");
        Console.WriteLine(status);

        Console.ReadLine();
    }

    // Определяем статический метод ShowMessage, который выводит на консоль строку "Hello World!"
    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    // Определяем статический метод Sum, который принимает три аргумента типа int и возвращает их сумму
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    // Определяем статический метод CheckLength, который принимает один аргумент типа string и возвращает значение типа bool в зависимости от длины аргумента
    static bool CheckLength(string _row)
    {
        if (_row.Length > 3)
            return true;
        return false;
    }
}