namespace daprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, How are you");

            string response = Console.ReadLine();

            Console.WriteLine($"I am glad that you are {response}");

            for (int i = 0; i <= 999;i++)
            {
                Console.WriteLine("bing bong");
            }
        }
    }
}