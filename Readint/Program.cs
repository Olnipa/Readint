namespace Readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber("Введите число: ");
            Console.WriteLine(number);
        }

        static int ReadNumber(string text)
        {
            bool isNumber = true;
            int number = 0;

            while (isNumber)
            {
                Console.Write(text);

                if (int.TryParse(Console.ReadLine(), out number) == true)
                {
                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то. Нужно вести число.");
                }
            }

            return number;
        }
    }
}