namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
            int x = int.Parse(Console.ReadLine());
            int i;
            for (i = x == 0 ? 0 : 1; x > 0; x /= 10)
            {
                i += x % 10;
            }
            Console.WriteLine(i-1);
        }
    }
}