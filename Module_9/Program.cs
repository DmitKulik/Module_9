
using System;

namespace Module_9

{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 9.1.3
            //Создайте класс исключения Exception и добавьте в свойство Data дату создания исключения
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);


            //Задание 9.1.4
            // Создайте класс исключения Exception и переопределите его свойство Message, а также свойство HelpLink, добавив в него ссылку на внешний ресурс.

            Exception exception2 = new Exception();
            exception2.HelpLink = "mail.ru";

            

        }
    }
}

