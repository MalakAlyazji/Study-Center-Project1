using System;
using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowTeacherInfo : Form
    {
        public frmShowTeacherInfo(int? TeacherID)
        {
            InitializeComponent();
            ctrlTeacherCardWithFilter1.LoadTeacherByTeacherID(TeacherID);
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
