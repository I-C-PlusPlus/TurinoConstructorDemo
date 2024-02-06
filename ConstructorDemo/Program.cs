namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;  i < 3; i++)
            {

                Student myStudent = new Student(); //("1234", "Day", "TUR",90,80,70,"Programming");

                Console.WriteLine("Student Number: {0}", myStudent.StudentNumber);
                Console.WriteLine("First Name: {0}", myStudent.FirstName);
                Console.WriteLine("Last Name: {0}", myStudent.LastName);
                Console.WriteLine("Student Major: {0}", myStudent.Major);

                Console.WriteLine("Score 1:{0}. ", myStudent.Score1);
                Console.WriteLine("Score 2:{0}. ", myStudent.Score2);
                Console.WriteLine("Score 3:{0}. ", myStudent.Score3);
                Console.WriteLine("Average {0}. ", myStudent.Average);

                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
