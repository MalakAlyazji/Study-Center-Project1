using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using StudyCenterBuisness;
using StudyCenterbusiness;
using StudyCenterBusinesss;
using StudyCenterPresentation.Groups;
using StudyCenterPresentation.NewFolder3;
using StudyCenterPresentation.Payments;
using StudyCenterPresentation.Students;
namespace StudyCenterPresentation
{
    public partial class MainForm : Form
    {
        Login _login;
        private Guna2CustomGradientPanel mainPanel;
        public MainForm(Login l)
        {
            _login = l;
            InitializeComponent();
            timer1.Start();
        }
        public void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(form);
            form.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnstudents_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmliststudents());
        }
        private void btnteachers_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmlistteacher());
        }
        private void btnsubjects_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmListSubjects());
        }
        private void btnclasses_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmlistclasses());
        }
        private void btngroups_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmlistgroups());
        }
        private void btnpayments_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmlistpayments());
        }
        private void btnsettings_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmSettings());
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            clsGlobal.LogInUser = null;
            Close();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmaddstudent());
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmaddteacher());
        }
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddEditUser());
        }
        private void btnAddGradeLevel_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddGradeLevel());
        }
        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddNewMeeting());
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddGroup());
        }
        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddSubject());
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddClass());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblcountGroups.Text = clsGroupBusiness.CountGroups().ToString();
            lblCountGradeLevels.Text = clsGradeLevelBusiness.CountGradeLevels().ToString();
            lblCountClasses.Text = clsClassBusiness.CountClasses().ToString();
            lblCountMeetings.Text = clsMeetingBusiness.CountMeetings().ToString();
            lblCountPayments.Text = clsPaymentBusiness.CountPayments().ToString();
            lblCountStudents.Text = clsstudentbusiness.StudentCount().ToString();
            lblCountSubjects.Text = clsSubjectBusiness.CountSubjects().ToString();
            lblCountTeachers.Text = clsteacherbusiness.CountTeachers().ToString();
            lblcountUsers.Text = clsuserbusiness.CountUsers().ToString();
            lblUserName.Text = clsGlobal.LogInUser.FullName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
