using System.Windows.Forms;
using StudyCenterBusinesss;

namespace StudyCenterPresentation
{
    public partial class ctrlteacherinfo : UserControl
    {
        int? _TeacherID;
        int? _PersonID;
        public int? Teacherid => _TeacherID;
        clsteacherbusiness _Teacher;
        public clsteacherbusiness TeacherInfo => _Teacher;
        public ctrlteacherinfo()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            lblcreatedby.Text = "[????]";
            lblHireDate.Text = "[????]";
            lblqualification.Text = "[????]";
            lblsalary.Text = "[????]";
            lblteacherid.Text = "[????]";
            linkeditteacher.Enabled = false;
        }
        void _FillTeacherInfo()
        {
            lblcreatedby.Text = _Teacher.GetUserName.ToString();
            lblHireDate.Text = _Teacher.HireDate.ToString();
            lblqualification.Text = _Teacher.Qualification;
            lblsalary.Text = _Teacher.Salary.ToString();
            lblteacherid.Text = _Teacher.TeacherID.ToString();
            linkeditteacher.Enabled = true;
        }
        public void LoadTeacherInfoByTeacherID(int? teacherid)
        {
            if (!teacherid.HasValue)
            {
                clsShowMessage.IdNotFound("Teacher", teacherid);
                Reset();
                return;
            }
            _TeacherID = teacherid;
            _Teacher = clsteacherbusiness.FindBy(_TeacherID, clsteacherbusiness.enFindBy.teacherid);
            if (_Teacher == null)
            {
                clsShowMessage.IdNotFound("Teacher", teacherid);
                Reset();
                return;
            }
            _FillTeacherInfo();
        }
        public void LoadTeacherInfoByPersonID(int? PersonID)
        {
            if (!PersonID.HasValue)
            {
                clsShowMessage.IdNotFound("Person", PersonID);
                Reset();
                return;
            }
            _PersonID = PersonID;
            _Teacher = clsteacherbusiness.FindBy(_PersonID, clsteacherbusiness.enFindBy.personid);
            if (_Teacher == null)
            {
                clsShowMessage.GeneralErrorMessage("Teacher is not Found");
                Reset();
                return;
            }
            _FillTeacherInfo();
        }
        private void linkeditteacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddteacher teacher = new frmaddteacher(_TeacherID);
            teacher.ShowDialog();
            LoadTeacherInfoByTeacherID(_TeacherID);
        }

    }
}
