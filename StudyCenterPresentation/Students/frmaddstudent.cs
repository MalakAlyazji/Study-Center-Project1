using System;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class frmaddstudent : Form
    {
        int? _studentid = null;
        clsstudentbusiness _Student = null;
        int? _selectedPersonID = null;
        enum enmode { add, update }
        enmode _mode;
        public frmaddstudent()
        {
            _mode = enmode.add;
            InitializeComponent();
        }
        public frmaddstudent(int? studentid)
        {
            _mode = enmode.update;
            _studentid = studentid;
            InitializeComponent();
        }
        public Action<int?> StudentIDBack;
        private void _ResetFields()
        {
            ctrlpersoninfoFITER1.Reset();
            ctrlstudentinfo1.Reset();
        }
        void _ResetTitles()
        {
            if (_mode == enmode.add)
            {
                ctrlstudentinfo1.Enabled = false;
                lbltitle.Text = "Add New Student";
                Text = "Add New Student";
                _Student = new clsstudentbusiness();
                ctrlpersoninfoFITER1.Enabled = true;
                _ResetFields();
            }
            else if (_mode == enmode.update)
            {
                ctrlstudentinfo1.Enabled = true;
                lbltitle.Text = "Update Student Information";
                Text = "Update Student Information";
                ctrlpersoninfoFITER1.Enabled = false;
            }
        }
        private void frmaddstudent_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_mode == enmode.update)
            {
                _LoadStudentInfo();
            }
        }
        private void _FillStudentInfoToUpdate()
        {
            ctrlpersoninfoFITER1.LoadPersonInfo(_Student.PersonID);
            ctrlstudentinfo1.loadstudentinfobySTUDENTID(_studentid);
            ctrlpersoninfoFITER1.FilterEnable = false;
            btsave.Enabled = true;
        }
        void _LoadStudentInfo()
        {
            _Student = clsstudentbusiness.FindBy(_studentid, clsstudentbusiness.enfindby.studentid);
            if (_Student == null)
            {
                clsShowMessage.IdNotFound("Student", _studentid);
                Close();
                return;
            }
            _FillStudentInfoToUpdate();
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _FillToSave()
        {
            _Student.EmergencyContactPhone = ctrlstudentinfo1.txtphone.Text;
            _Student.EnrollmentDate = DateTime.Now;
            _Student.GradeLevelID = clsGradeLevelBusiness.GetGradeLevelIDbyName(ctrlstudentinfo1.cbgradelevel.Text);
            _Student.UserID = clsGlobal.LogInUser.UserID;
            _Student.PersonID = _selectedPersonID;
        }
        void _SaveStudent()
        {
            _FillToSave();
            if (_Student.SaveStudent())
            {
                lbltitle.Text = "Update Student";
                Text = "Update Student";
                ctrlstudentinfo1.lblStudentID.Text = _Student.StudentID.ToString();
                ctrlstudentinfo1.lblcreatedby.Text = "1";
                _mode = enmode.update;
                StudentIDBack?.Invoke(_Student?.StudentID);
                clsShowMessage.OperationDoneSuccessfully("Saved");

            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }

            _SaveStudent();
        }
        private void ctrlpersoninfoFITER1_OnPersonSelected(object sender, ctrlpersoninfoFITER.PersonSelectedEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {
                clsShowMessage.IdNotFound("Person", e.PersonID);
                return;
            }
            _selectedPersonID = e.PersonID;
            ctrlstudentinfo1.Enabled = true;
        }
    }
}
