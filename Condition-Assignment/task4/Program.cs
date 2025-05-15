namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Marks in Maths, Physics, and Chemistry
            Console.Write("Enter marks in Mathematics: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            // Check individual subject criteria
            bool isMathsEligible = maths >= 65;
            bool isPhysicsEligible = physics >= 55;
            bool isChemistryEligible = chemistry >= 50;

            // Calculate total marks
            int totalAll = maths + physics + chemistry;
            int totalMathsPhysics = maths + physics;

            // Check eligibility
            if (isMathsEligible && isPhysicsEligible && isChemistryEligible &&
                (totalAll >= 180 || totalMathsPhysics >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is NOT eligible for admission.");
            }
        }
    }
}
