using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int? UserID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfoByUserID(UserID);
        }
    }
}
