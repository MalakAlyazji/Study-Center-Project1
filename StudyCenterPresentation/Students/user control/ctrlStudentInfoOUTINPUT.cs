using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlStudentInfoOUTINPUT : UserControl
    {
        clsstudentbusiness _Student;
        public clsstudentbusiness Student => _Student;
        int? _StudentID;
        public int? StudentID => _StudentID;
        int? _PersonID = null;
        public ctrlStudentInfoOUTINPUT()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            _Student = null;
            _StudentID = null;
            lblcreatedby.Text = "[????]";
            lblStudentID.Text = "[????]";
            lblphone.Text = "[????]";
            lblgradelevels.Text = "[????]";
            linkeditStudent.Enabled = false;
        }
        void _FillStudentInfo()
        {
            lblcreatedby.Text = _Student.UserID.ToString();
            lblenrollmentdate.Text = _Student.EnrollmentDate.ToString();
            lblStudentID.Text = _Student.StudentID.ToString();
            lblphone.Text = _Student.Phone.ToString();
            lblgradelevels.Text = clsGradeLevelBusiness.findlevel(_Student.GradeLevelID).GradeLevelName;
            linkeditStudent.Enabled = true;
        }
        public void LoadStudentInfoByPersonID(int? PersonID)
        {
            if (!PersonID.HasValue)
            {
                clsShowMessage.IdNotFound("Person", PersonID);
                Reset();
                return;
            }
            _Student = clsstudentbusiness.FindBy(PersonID, clsstudentbusiness.enfindby.personid);
            if (_Student == null)
            {
                clsShowMessage.GeneralErrorMessage("This Person is not assigned as a student");
                Reset();
                return;
            }
            _FillStudentInfo();
        }
        public void LoadStudentInfoByStudentID(int? studentid)
        {
            _StudentID = studentid;
            if (_StudentID == null)
            {
                clsShowMessage.IdNotFound("Student", studentid);
                Reset();
                return;
            }
            _Student = clsstudentbusiness.FindBy(studentid, clsstudentbusiness.enfindby.studentid);
            if (_Student == null)
            {
                clsShowMessage.IdNotFound("Student", studentid);
                Reset();
                return;
            }
            _FillStudentInfo();
        }
        private void linkeditStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddstudent s = new frmaddstudent(_Student.StudentID);
            s.ShowDialog();
            LoadStudentInfoByStudentID(_Student.StudentID);
        }

    }
}
