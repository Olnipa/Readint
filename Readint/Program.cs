namespace Readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadNumber();
        }
        static void ReadNumber()
        {
            bool isNumber = true;
            
            while (isNumber)
            {
                int number;
                Console.Write("Введите число: ");

                if (int.TryParse(Console.ReadLine(), out number) == true)
                {
                    Console.WriteLine(number);
                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то. Нужно вести число.");
                }
            }
        }
    }
}