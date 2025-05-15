namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine in which quadrant the coordinate point lies.");

            Console.Write("Enter the quadrant-x: ");
            int quadrantX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quadrant-y: ");
            int quadrantY = Convert.ToInt32(Console.ReadLine());

            if (quadrantX >= 0 && quadrantY >= 0)
            {
                Console.WriteLine("The coordinate point lies 1st Quadrant!!");
            }
            else if (quadrantX >= 0 && quadrantY < 0)
            {
                Console.WriteLine("The coordinate point lies 2nd Quadrant!!");
            }
            else if (quadrantX < 0 && quadrantY < 0)
            {
                Console.WriteLine("The coordinate point lies 3rd Quadrant!!");
            }
            else if (quadrantX < 0 && quadrantY > 0)
            {
                Console.WriteLine("The coordinate point lies 4th Quadrant!!");
            }
            else
            {
                Console.WriteLine("Something is wrong!!!");
            }

        }
    }
}
