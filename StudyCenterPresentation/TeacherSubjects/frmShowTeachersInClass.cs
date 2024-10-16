using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowTeachersInClass : Form
    {
        public frmShowTeachersInClass(int? ClassID)
        {
            InitializeComponent();
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherInClass(ClassID);
        }


    }
}
