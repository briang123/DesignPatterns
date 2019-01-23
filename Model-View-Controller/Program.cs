using System;

namespace Model_View_Controller
{
    /// <summary>
    /// Step 4 - Use the StudentController methods to demonstrate MVC design pattern usage
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            //get student record from database
            var model = GetStudentFromDatabase();

            //create view to write student details to view
            var view = new StudentView();
            var controller = new StudentController(model, view);
            controller.UpdateView();

            //update student name, then write to view
            controller.SetStudentName("Susan");
            controller.UpdateView();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }

        private static Student GetStudentFromDatabase()
        {
            var student = new Student
            {
                Name = "John",
                Grade = 10
            };

            return student;
        }
    }
}
