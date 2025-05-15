namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Check Candidate is eligible to Vote__");

            Console.Write("Enter candidate age to check: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Candidate is eligible to Vote!");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible to Vote!");
            }

            //pause
            Console.ReadKey();

        }
    }
}
