using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class ctrlstudentcard : UserControl
    {
        int? _StudentID = null;
        public int? StudentID => _StudentID;
        clsstudentbusiness _Student = null;
        public clsstudentbusiness StudentInfo => _Student;
        int? _PersonID = null;
        public int? PersonID => _PersonID;
        clspeoplebusiness _Person = null;
        public clspeoplebusiness Person => _Person;
        public ctrlstudentcard()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            ctrlpersoninfo1.Reset();
            ctrlStudentInfoOUTINPUT1.Reset();
        }
        void _FillStudentInfo()
        {
            ctrlStudentInfoOUTINPUT1.LoadStudentInfoByStudentID(_Student.StudentID);
            ctrlpersoninfo1.loadpersoninfo(_Student.PersonID);
        }
        public void LoadStudentInfoByPersonID(int? PersonID)
        {
            _PersonID = PersonID;
            if (!_PersonID.HasValue)
            {
                MessageBox.Show("This Person is not a Student!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();
                return;
            }
            _Student = clsstudentbusiness.FindBy(_PersonID, clsstudentbusiness.enfindby.personid);
            if (_Student == null)
            {
                MessageBox.Show($"There is no  Student with Person ID = {PersonID} !",
                    "Missing student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();

                return;
            }
            _StudentID = _Student.StudentID;
            ctrlStudentInfoOUTINPUT1.LoadStudentInfoByPersonID(_PersonID);
            ctrlpersoninfo1.loadpersoninfo(_PersonID);
        }
        public void LoadStudentInfoByStudentID(int? StudentID)
        {


            if (!StudentID.HasValue)
            {
                clsShowMessage.IdNotFound("student", StudentID);
                Reset();
                return;
            }
            _StudentID = StudentID;
            _Student = clsstudentbusiness.FindBy(StudentID, clsstudentbusiness.enfindby.studentid);

            if (_Student == null)
            {
                clsShowMessage.IdNotFound("student", StudentID);
                Reset();
                return;
            }
            _FillStudentInfo();
        }
    }
}
