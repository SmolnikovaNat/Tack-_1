namespace HelloWorld
{
    class Program
    {
        //public static void Main(string[] array)
        //{
             //Напишите программу, которая выдает случайный массив
            //случайного размера (от 5 до 10) элементов (значение элементов от1 до 40) 
            //и выводит на экран массив квадратов этих чисел
            //1,2,5,7,19 -> [2.4.25.49.361]
            //6.1.33 -> [36.1.1089]
        public static void Main()
        {
            int[] number = new int[new Random().Next(5, 10)];
            
            FillAray(number);
            Console.WriteLine();
            Getsquare(number);
           //Console.WriteLine();
        }
       
        public static void FillAray(int[] array)
        {
            Console.Write("");
            int Length = array.Length;
            for(int i = 0; i < Length; i++)
            {
                array[i] = new Random().Next(1, 41);
                //Console.Write('');
                Console.Write($"{array[i]} ");
            }
        }
        public static void Getsquare(int[] array_N)
        {
            int Length = array_N.Length;
            for(int i = 0; i < Length; i++) 
            {
                array_N[i] = Convert.ToInt32(Math.Pow(array_N[i], 2));
                Console.Write($"{array_N[i]} ");
            }
        }
               
    }
}