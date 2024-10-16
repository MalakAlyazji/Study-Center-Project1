using System.ComponentModel;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlAddGrade : UserControl
    {
        int? _GradeLevelID = null;
        public int? GradeLevelID => _GradeLevelID;
        clsGradeLevelBusiness _GradeLevel = null;
        public clsGradeLevelBusiness GradeLevel => _GradeLevel;
        public ctrlAddGrade()
        {
            InitializeComponent();
        }
        void _FillGrade()
        {
            txtGradeName.Text = _GradeLevel.GradeLevelName;
        }
        public void Reset()
        {
            lblGradeID.Text = "[????]";
            txtGradeName.Text = null;
        }
        public void LoadGradeLevelInfo(int? GradeLevelID)
        {
            _GradeLevelID = GradeLevelID;
            if (_GradeLevelID == null)
            {
                clsShowMessage.IdNotFound("Grade Level", GradeLevelID);
                Reset();
                return;
            }
            _GradeLevel = clsGradeLevelBusiness.findlevel(GradeLevelID);
            if (_GradeLevel == null)
            {
                clsShowMessage.IdNotFound("Grade Level", GradeLevelID);
                Reset();
                return;
            }
            _FillGrade();
        }
        private void txtClassName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGradeName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtGradeName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtGradeName, null);
            }
        }

    }
}
