namespace Reversenumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for Reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int result = 0;

            while (num != 0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is "  +  result);
            Console.ReadLine();
        }
    }
}


/* Console.WriteLine("Enter number for Reverse");
            int num = Convert.ToInt32(Console.ReadLine());*/