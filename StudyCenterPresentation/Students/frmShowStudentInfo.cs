using System;
using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowStudentInfo : Form
    {
        public frmShowStudentInfo(int? StudentID)
        {
            InitializeComponent();
            ctrlStudentIfoFILTER1.LoadStudentInfoByStudentID(StudentID);
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
