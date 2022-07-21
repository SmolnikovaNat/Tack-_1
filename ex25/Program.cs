namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Напишите цикл который на вход принимает два числа А и В
            //и выыводит число А в натуральную степень В

            Console.WriteLine("Введите число A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < numberB; i++)
                   
            {
                result *= numberA;
            }
            Console.WriteLine(result);
                                
        }
    }
}
