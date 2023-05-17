

using System.Runtime.InteropServices;

namespace Module_9

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException();

            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                
                Console.WriteLine(ex);
            }
            

            Console.ReadKey();


        }
    }
}

