using System;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class frmAddGradeLevel : Form
    {
        enum enMode { Add, Update }
        enMode _Mode;
        int? _GradeLevelID;
        clsGradeLevelBusiness _GradeLevel;
        public Action<int?> GradeIDBack;
        public frmAddGradeLevel()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddGradeLevel(int? GradeLevelID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GradeLevelID = GradeLevelID;
        }
        void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                Text = "Add New Grade Level";
                lbltitle.Text = "Add New Grade Level";
                _GradeLevel = new clsGradeLevelBusiness();
                ctrlAddGrade1.Reset();
            }
            else
            {
                Text = "Update Grade Level Info";
                lbltitle.Text = "Update Grade Level Info";
            }
        }
        void _LoadGradeInfo()
        {
            _GradeLevel = clsGradeLevelBusiness.findlevel(_GradeLevelID);
            if (_GradeLevel == null)
            {
                clsShowMessage.IdNotFound("GradeLevel", _GradeLevelID);
                Close();
                return;
            }
            _FillGradeToUpdte();
        }
        private void frmAddGradeLevel_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                _LoadGradeInfo();
            }
        }
        void _FillGradeToUpdte()
        {
            ctrlAddGrade1.lblGradeID.Text = _GradeLevelID.ToString();
            ctrlAddGrade1.LoadGradeLevelInfo(_GradeLevelID);
        }
        void _FillGradeToSave()
        {
            _GradeLevel.GradeLevelName = ctrlAddGrade1.txtGradeName.Text;
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _SaveGrade()
        {
            _FillGradeToSave();
            if (_GradeLevel.SaveGradeLevel())
            {
                Text = "UpdateGrade Level";
                lbltitle.Text = "Update Grade Level";
                _Mode = enMode.Update;
                ctrlAddGrade1.lblGradeID.Text = _GradeLevel.GradeLevelID.ToString();
                clsShowMessage.OperationDoneSuccessfully("Saved");
                GradeIDBack.Invoke(_GradeLevel.GradeLevelID);
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }
            _SaveGrade();
        }
    }
}
