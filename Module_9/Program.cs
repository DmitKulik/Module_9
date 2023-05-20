
using System.Net.Security;
using System.Runtime.InteropServices;


// определение двух делегатов с помощью ключевого слова delegate
// ShowMessageDelegate принимает одну строку в качестве аргумента и не возвращает значения
delegate void ShowMessageDelegate(string _message);
// RandomNumberDelegate не принимает аргументов и возвращает целое число
delegate int RandomNumberDelegate();

class Program
{
    static void Main(string[] args)
    {
        // создание экземпляра делегата ShowMessageDelegate
        ShowMessageDelegate showMessageDelegate = (string _message) =>
        {
            // создание лямбда-функции, которая выводит сообщение на консоль
            Console.WriteLine(_message);
        };
        // вызов функции showMessageDelegate с аргументом "Hello World!"
        showMessageDelegate.Invoke("Hello World!");

        // ожидание нажатия клавиши пользователем
        Console.Read();

        // создание экземпляра делегата RandomNumberDelegate
        RandomNumberDelegate randomNumberDelegate = () =>
        {
            // создание лямбда-функции, которая возвращает случайное целое число в диапазоне от 0 до 99
            return new Random().Next(0, 100);
        };
        // вызов функции randomNumberDelegate и сохранение результата в переменной result
        int result = randomNumberDelegate.Invoke();

        // вывод результата на консоль
        Console.WriteLine(result);

        // ожидание нажатия клавиши пользователем
        Console.Read();
    }
}

