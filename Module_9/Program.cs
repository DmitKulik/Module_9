
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.InteropServices;







class Program
{
    // Определение двух делегатов TesCar и HandlerMethod
    // TesCar имеет возвращаемый тип Car, который может быть заменен производным классом (например, Lexus)
    public delegate Car TesCar();
    // HandlerMethod принимает параметр типа Parent, который может быть заменен базовым классом (например, Child)
    public delegate Parent HandlerMethod();

    // Определение делегата ChildInfo
    delegate void ChildInfo(Child child);

    // Методы, возвращающие различные типы объектов
    public static Car CarNew() { return null; }
    public static Lexus LexusNew() { return null; }
    public static Parent ParentHandler() { return null; }
    public static Child ChildHandler() { return null; }

    static void Main(string[] args)
    {
        // Пример использования ковариантности в делегатах
        TesCar testcar = CarNew;    // TesCar может ссылаться на метод CarNew
        TesCar testcar1 = LexusNew; // TesCar может ссылаться на метод LexusNew

        // Пример использования контравариантности в делегатах
        ChildInfo childInfo = GetParentInfo;   // ChildInfo может ссылаться на метод GetParentInfo,
                                               // который принимает объект типа Parent
        childInfo.Invoke(new Child());         // вызов делегата с объектом типа Child

        Console.Read();
    }

    // Метод, принимающий объект типа Parent
    // Пример использования контравариантности в делегатах
    public static void GetParentInfo(Parent p) { Console.WriteLine(p.GetType()); }
}

// Классы Car, Lexus, Parent и Child, используемые в коде как примеры наследования классов
class Car { }
class Lexus : Car { }
class Parent { }
class Child : Parent { }