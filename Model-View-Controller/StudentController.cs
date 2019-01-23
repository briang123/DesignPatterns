namespace Model_View_Controller
{
    /// <summary>
    /// Step 3 - Create Controller
    /// </summary>
    public class StudentController
    {
        private readonly Student _model;
        private readonly StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            _model = model;
            _view = view;
        }

        public void SetStudentName(string name)
        {
            _model.Name = name;
        }

        public string GetStudentName()
        {
            return _model.Name;
        }

        public void SetGrade(byte grade)
        {
            _model.Grade = grade;
        }

        public byte GetGrade()
        {
            return _model.Grade;
        }

        public void UpdateView()
        {
            _view.PrintStudentDetails(_model.Name, _model.Grade);
        }

    }
}