using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmTeachersTeachSubjectBySubjectID : Form
    {
        public frmTeachersTeachSubjectBySubjectID(int? SubjectID)
        {
            InitializeComponent();
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherSubjectBySelectedSubjectID(SubjectID);
        }
    }
}
