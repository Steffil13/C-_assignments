namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__calculate the total, percentage and division__");
            // get the values from user
            Console.Write("Enter the Name:");
            string name = Console.ReadLine();
            Console.Write("Enter the rollno:");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark for Tamil:");
            double tamil = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the mark for English:");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the mark for the Science:");
            double science = Convert.ToDouble(Console.ReadLine());

            //calculate the total subject marks

            double total = tamil + english + science;

            //calculate the percentage

            double percentage = total / 300 * 100;

            //calculate the division using percentage 

            string grade;
            if (percentage >= 90)
            {
                grade = "A - Grade";
            }
            else if (percentage >= 75)
            {
                grade = "B-Grade";
            }
            else if (percentage >= 45)
            {
                grade = "C-Grade";
            }
            else
            {
                grade = "Oopss Failed!!";
            }

            // Display outputs
            Console.WriteLine("\n----- Student Report -----");
            Console.WriteLine("Roll Number: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage.ToString("f2") + "%");
            Console.WriteLine("Grade: " + grade);
        }
    }
}
