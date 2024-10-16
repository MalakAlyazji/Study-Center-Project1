using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowGroupsInClass : Form
    {
        public frmShowGroupsInClass(int? ClassID)
        {
            InitializeComponent();
            ctrlShowGroupsInClass1.LoadGroupsInClass(ClassID);
        }
    }
}
