using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlGroupCard : UserControl
    {
        int? _GroupID = null;
        public int? GroupID => _GroupID;
        clsGroupBusiness _Group = null;
        public clsGroupBusiness Group => _Group;
        public void Reset()
        {
            _Group = null;
            _GroupID = null;
            lblGroupID.Text = "[????]";
            lblCountStudent.Text = "[????]";
            lblGradeSubject.Text = "[????]";
            lblTeacherSubjectID.Text = "[????]";
            lblMeetingTime.Text = "[????]";
            lblClassID.Text = "[????]";
            lblGroupName.Text = "[????]";
            lblUserName.Text = "[????]";
            lnkSubjectGradeLevel.Enabled = false;
            lnkClassInfo.Enabled = false;
            lnkTeacherInfo.Enabled = false;
        }
        public ctrlGroupCard()
        {
            InitializeComponent();
        }
        private void _FillGroupInfo()
        {
            lblGroupID.Text = _GroupID.ToString();
            lblGradeSubject.Text = _Group.GradeSubjectID.ToString();
            lblCountStudent.Text = _Group.StudentCount.ToString() + " / " + _Group.ClassInfo?.Capacity.ToString();
            lblTeacherSubjectID.Text = _Group.TeacherSubjectID.ToString();
            lblClassID.Text = _Group.ClassID.ToString();
            lblMeetingTime.Text = clsFormat.FormatTime(_Group.MeetingInfo.StartTime, _Group.MeetingInfo.EndTime);
            lblGroupName.Text = _Group.GroupName;
            rbYes.Checked = (bool)_Group.IsActive;
            rbNo.Checked = !(bool)_Group.IsActive;
            lnkSubjectGradeLevel.Enabled = true;
            lnkClassInfo.Enabled = true;
            lnkTeacherInfo.Enabled = true;
            lblUserName.Text = clsGlobal.LogInUser.UserName;
        }
        public void LoadGroupInfoByGroupID(int? GroupID)
        {
            if (!GroupID.HasValue)
            {
                clsShowMessage.GeneralErrorMessage($"Cannot Find Group with ID {_GroupID}");
                Reset();
                return;
            }

            _GroupID = GroupID;

            _Group = clsGroupBusiness.FindGroup(_GroupID);
            if (_Group == null)
            {
                clsShowMessage.GeneralErrorMessage($"Cannot Find Group with ID {_GroupID}");
                Reset();
                return;
            }

            _FillGroupInfo();
        }
        private void lnkSubjectGradeLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? GradeSubjectID = int.Parse(lblGradeSubject.Text);
            frmShowGradeSubject frmShowGradeSubject = new frmShowGradeSubject(GradeSubjectID.Value);
            frmShowGradeSubject.ShowDialog();
        }
        private void lnkClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? ClassID = int.Parse(lblClassID.Text);
            frmShowClassCard frmShowClassCard = new frmShowClassCard(ClassID.Value);
            frmShowClassCard.ShowDialog();
        }
        private void lnkTeacherInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? TeacherSubjectID = int.Parse(lblTeacherSubjectID.Text);
            int? TecherID = clsTeacherSubjectsBusiness.FindTeacherSubjectsBy(TeacherSubjectID, clsTeacherSubjectsBusiness.enFindBy.TeacherSubjectID).TeacherID;
            frmShowTeacherInfo frmShowTeacherInfo = new frmShowTeacherInfo(TecherID);
            frmShowTeacherInfo.ShowDialog();
        }
    }
}
