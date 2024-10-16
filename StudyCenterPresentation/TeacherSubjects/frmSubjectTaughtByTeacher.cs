using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class srmSubjectTaughtByTeacher : Form
    {
        public srmSubjectTaughtByTeacher(int? TeacherID)
        {
            InitializeComponent();
            ctrlTeacherCard1.LoadTeacherInfoByTeacherID(TeacherID);
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherSubjectByTeacherID(TeacherID);
        }

    }
}
