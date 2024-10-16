using System;
using System.Windows.Forms;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class frmAddClass : Form
    {
        enum enMode { Add, Update }
        enMode _Mode;
        int? _ClassID;
        clsClassBusiness _Class;
        public Action<int?> ClassIDBack;
        public frmAddClass()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddClass(int? ClassID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ClassID = ClassID;
        }
        void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                Text = "Add New Class";
                lbltitle.Text = "Add New Class";
                _Class = new clsClassBusiness();
                ctrlAddClass1.Reset();
            }
            else
            {
                Text = "Update Class";
                lbltitle.Text = "Update Class";
            }
        }
        void _LoadClassInfo()
        {
            _Class = clsClassBusiness.FindClassByClassID(_ClassID);
            if (_Class == null)
            {
                clsShowMessage.IdNotFound("Class", _ClassID);
                Close();
                return;
            }
            ctrlAddClass1.LoadClassByClassID(_ClassID);
            btsave.Enabled = true;
        }
        private void frmAddClass_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                _LoadClassInfo();
            }
        }
        void _FillToSave()
        {
            _Class.Capacity = int.Parse(ctrlAddClass1.txtCapacity.Text);
            _Class.ClassName = ctrlAddClass1.txtClassName.Text;
        }
        void _SaveClass()
        {
            _FillToSave();
            if (_Class.SaveClass())
            {
                Text = "Update Class";
                lbltitle.Text = "Update Class";
                _Mode = enMode.Update;
                ctrlAddClass1.lblClassID.Text = _Class.ClassID.ToString();
                ClassIDBack?.Invoke(_Class?.ClassID);
                clsShowMessage.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }
            _SaveClass();
        }
    }
}
