

namespace Module_9

{
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            try
            {
                int result = Division(7, 0);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException) 
                Console.WriteLine("Делитьц на нoль нельзя");
            }
            

            Console.ReadKey();


        }
    }
}

