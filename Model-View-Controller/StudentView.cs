using System;

namespace Model_View_Controller
{
    /// <summary>
    /// Step 2 - Create View
    /// </summary>
    public class StudentView
    {
        public void PrintStudentDetails(string name, byte grade)
        {
            Console.WriteLine(@"Name: {0}, Grade: {1}", name, grade);
        }
    }
}