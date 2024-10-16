using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmListTeacherSubjects : Form
    {
        public frmListTeacherSubjects(int? TeacherID)
        {
            InitializeComponent();
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherSubjectByTeacherID(TeacherID);
        }

    }
}
