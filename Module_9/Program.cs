
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.InteropServices;

class Program{

    public delegate void Notify();

    static void Main(string[] args){

        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessComplete += bl_ProcessComplete;
        bl.StartProcess();
    }
    public class ProcessBusinessLogic{

        public event Notify ProcessComplete;

        public void StartProcess(){
            Console.WriteLine("Process Start");
            OnProcessComplete();
        }
        protected virtual void OnProcessComplete(){
            ProcessComplete?.Invoke();
        }
    
    }

    public static void bl_ProcessComplete()
    {

        Console.WriteLine("Process Completee");
    }
}

