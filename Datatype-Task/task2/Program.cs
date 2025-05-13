namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace task3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //get the distamce from user
                Console.Write("Enter the distance:");
                //assign the variable for distance
                int distance = Convert.ToInt32(Console.ReadLine());
                //get the time and speed
                Console.Write("Enter the time:");
                int time = Convert.ToInt32(Console.ReadLine());
                int speed = distance / time;
                //display kmph and mph
                Console.WriteLine($"The speed in killometer per hour is: {speed}");
                Console.WriteLine($"The speed in miles per hour is: {speed}");
            }
        }
    }

}
    }
}
