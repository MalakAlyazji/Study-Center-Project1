using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlGradeSubjectCard : UserControl
    {
        int? _subjectGradeLevelID = null;
        clsGradeSubjectBusiness _SubjectGradeLevel = null;
        public ctrlGradeSubjectCard()
        {
            InitializeComponent();
        }
        private void _FillSubjectData()
        {
            lblGradeLevelName.Text = _SubjectGradeLevel.GradeLevelInfo.GradeLevelName;
            lblGradeLevelID.Text = _SubjectGradeLevel.GradeID.ToString();
            lblFees.Text = _SubjectGradeLevel.Fees.ToString();
            lblSubjectID.Text = _SubjectGradeLevel.SubjectID.ToString();
            lblSubjectName.Text = _SubjectGradeLevel.SubjectInfo.SubjectName;
            lblTitle.Text = _SubjectGradeLevel.Titles;
            lblSubjectGradeLevelID.Text = _SubjectGradeLevel.GradeSubjectID.ToString();
            linkeShowteacher.Enabled = true;
        }
        public void Reset()
        {
            _subjectGradeLevelID = null;
            _SubjectGradeLevel = null;

            lblSubjectGradeLevelID.Text = "[????]";
            lblSubjectID.Text = "[????]";
            lblGradeLevelID.Text = "[????]";
            lblFees.Text = "[????]";
            lblSubjectName.Text = "[????]";
            lblGradeLevelName.Text = "[????]";

            linkeShowteacher.Enabled = false;
        }
        public void LoadSubjectGradeLevelInfo(int? subjectGradeLevelID)
        {

            if (!subjectGradeLevelID.HasValue)
            {
                clsShowMessage.ShowMissingDataMessage("Subject-GradeLevel", _subjectGradeLevelID);

                Reset();

                return;
            }
            _subjectGradeLevelID = subjectGradeLevelID;
            _SubjectGradeLevel = clsGradeSubjectBusiness.FindGradeSubjectIDBy(_subjectGradeLevelID, clsGradeSubjectBusiness.enFindBy.GradeSubjectID);
            if (_SubjectGradeLevel == null)
            {
                clsShowMessage.ShowMissingDataMessage("Subject-GradeLevel", _subjectGradeLevelID);

                Reset();

                return;
            }
            _FillSubjectData();
        }
        private void linkeShowteacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTeachersTeachSubjectBySubjectID frmTeachersTeachSubjectBySubjectID = new frmTeachersTeachSubjectBySubjectID(_SubjectGradeLevel.SubjectID);
            frmTeachersTeachSubjectBySubjectID.ShowDialog();
        }
    }
}
