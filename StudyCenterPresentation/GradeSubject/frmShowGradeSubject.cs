using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowGradeSubject : Form
    {
        public frmShowGradeSubject(int? GradeSubjectID)
        {
            InitializeComponent();
            ctrlGradeSubjectCard1.LoadSubjectGradeLevelInfo(GradeSubjectID);
        }
    }
}
