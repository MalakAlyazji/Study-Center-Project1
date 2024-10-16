using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class ctrlstudentinfo : UserControl
    {
        private int? _studentid = null;
        private clsstudentbusiness _Student = null;
        public int? StudentID => _studentid;
        public clsstudentbusiness studentinfo => _Student;
        public ctrlstudentinfo()
        {
            InitializeComponent();
        }
        private void _fillstudentinfo()
        {
            lblcreatedby.Text = _Student.GetUserName.ToString();
            lblStudentID.Text = _Student.StudentID.ToString();
            cbgradelevel.SelectedItem = clsGradeLevelBusiness.findlevel(_Student.GradeLevelID).GradeLevelName;
            txtphone.Text = _Student.Phone.ToString();
        }
        private void _FillComboBoxWithGradeLevels()
        {
            DataTable gradeLevels = clsGradeLevelBusiness.GetLevelsName();

            foreach (DataRow drTitle in gradeLevels.Rows)
            {
                cbgradelevel.Items.Add(drTitle["GradeLevelName"].ToString());
            }

            if (cbgradelevel.Items.Count > 0)
                cbgradelevel.SelectedIndex = 0;
        }
        public void Reset()
        {
            _FillComboBoxWithGradeLevels();
            _Student = null;
            _studentid = null;
            lblcreatedby.Text = clsGlobal.LogInUser.FullName;
            lblStudentID.Text = "[????]";
            txtphone.Text = string.Empty;
        }
        public void loadstudentinfobySTUDENTID(int? studentid)
        {
            _studentid = studentid;
            if (_studentid == null)
            {
                clsShowMessage.IdNotFound("Student", studentid);
                Reset();
                return;
            }
            _Student = clsstudentbusiness.FindBy(_studentid, clsstudentbusiness.enfindby.studentid);
            if (_Student == null)
            {
                clsShowMessage.IdNotFound("Student", studentid);
                Reset();
                return;
            }
            _fillstudentinfo();
        }
        private void ctrlstudentinfo_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithGradeLevels();
        }
        private void txtphone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtphone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtphone, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtphone, null);
            }
        }
        private void cbgradelevel_Validating(object sender, CancelEventArgs e)
        {
            if (cbgradelevel.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbgradelevel, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(cbgradelevel, null);
            }
            if (clsStudentGroupBusiness.IsStudentGroupExistBy(_studentid, clsStudentGroupBusiness.enFindBy.StudentID))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbgradelevel, "This Student Is Alreay Assigned to Group ,you can not Change the Grade");
                return;
            }
            else
            {
                errorProvider1.SetError(cbgradelevel, null);
            }
        }
    }
}
