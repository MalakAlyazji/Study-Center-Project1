using System;
using System.Windows.Forms;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class frmAddSubject : Form
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        int? _SubjectID = null;
        clsSubjectBusiness _Subject;
        public Action<int?> SubjectIDBack;
        public frmAddSubject()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddSubject(int? SubjectID)
        {
            _SubjectID = SubjectID;
            InitializeComponent();
            _Mode = enMode.Update;
        }
        void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                Text = "Add New Subject";
                lbltitle.Text = "Add New Subject";
                _Subject = new clsSubjectBusiness();
                ctrlAddSubject1.Reset();
            }
            else
            {
                Text = "Update Subject";
                lbltitle.Text = "Update Subject";
            }
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _FillToSave()
        {
            _Subject.SubjectName = ctrlAddSubject1.txtSubjectName.Text;
        }
        void _FillToUpdate()
        {
            ctrlAddSubject1.LoadSubjectInfo(_SubjectID);
        }
        void _SaveSubject()
        {
            _FillToSave();
            if (_Subject.SaveSubjects())
            {
                Text = "Update Subject";
                lbltitle.Text = "Update Subject";
                _Mode = enMode.Update;
                ctrlAddSubject1.lblSubjectID.Text = _Subject.SubjectID.ToString();
                SubjectIDBack?.Invoke(_Subject?.SubjectID);
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
                clsShowMessage.ShowValidationErrorMessage();
                return;
            }
            if (clsSubjectBusiness.IsSubjectExistBySubjectName(ctrlAddSubject1.txtSubjectName.Text.Trim()))
            {
                clsShowMessage.alreadyexist("This Subject Name Is Already Exist");
                ctrlAddSubject1.Reset();
                return;
            }
            _SaveSubject();
        }
        void _LoadSubjectInfo()
        {
            _Subject = clsSubjectBusiness.FindSubject(_SubjectID);
            if (_Subject == null)
            {
                clsShowMessage.IdNotFound("Subject", _SubjectID);
                Close();
                return;
            }
            _FillToUpdate();
        }
        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                _LoadSubjectInfo();
            }
        }
    }
}
