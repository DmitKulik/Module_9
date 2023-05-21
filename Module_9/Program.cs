
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.InteropServices;

class Program{

    public delegate void Notify();

    static void Main(string[] args){

        ProcessBusinessLogic bl = new ProcessBusinessLogic();// Создаем экземпляр класса Подписываемся на событие ProcessComplete этого экземпляра
        bl.ProcessComplete += bl_ProcessComplete;
        bl.StartProcess();// Запускаем процесс
    }
    // Класс, отвечающий за бизнес-логику процесса
    public class ProcessBusinessLogic
    {
        // Событие ProcessComplete типа Notify
        public event Notify ProcessComplete;

        // Метод, запускающий процесс
        public void StartProcess()
        {
            // Выводим в консоль сообщение о начале процесса
            Console.WriteLine("Process Start");
            // Вызываем метод OnProcessComplete для оповещения 
            // об окончании процесса
            OnProcessComplete();
        }

        // Виртуальный метод, вызывающий событие ProcessComplete
        protected virtual void OnProcessComplete()
        {
            // Если есть хотя бы один обработчик события ProcessComplete, 
            // то вызываем его
            ProcessComplete?.Invoke();
        }
    }

    // Метод, вызываемый, когда процесс завершен
    public static void bl_ProcessComplete()
    {
        // Выводим сообщение о завершении процесса в консоль
        Console.WriteLine("Process Complete");
    }
}

