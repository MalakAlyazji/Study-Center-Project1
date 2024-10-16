using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class ctrlUserCard : UserControl
    {
        private int? _UserID = null;
        private clsuserbusiness _User = null;
        public int? UserID => _UserID;
        public clsuserbusiness UserInfo => _User;

        public int? PersonID => ctrlpersoninfo1.personid;
        public clspeoplebusiness PersonInfo => ctrlpersoninfo1.PersonInfo;
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        private void _FillUserData()
        {
            ctrlpersoninfo1.loadpersoninfo(_User.PersonID);
            ctrlUserInfo1.LoadUserInfoByUserID(_User.UserID);
        }
        public void Reset()
        {
            _UserID = null;
            _User = null;
            ctrlpersoninfo1.Reset();
            ctrlUserInfo1.ResetUser();
        }
        public void LoadUserInfoByUserID(int? userID)
        {
            if (!userID.HasValue)
            {
                clsShowMessage.ShowMissingDataMessage("User", userID);
                Reset();
                return;
            }
            _User = clsuserbusiness.FindUserBy(userID, clsuserbusiness.EnFindUserBy.UserID);
            _UserID = userID;
            if (_User == null)
            {
                clsShowMessage.ShowMissingDataMessage("user", userID);
                Reset();
                return;
            }
            _FillUserData();
        }
        public void LoadUserInfoByPersonID(int? personID)
        {
            if (!personID.HasValue)
            {
                MessageBox.Show("There is no a user!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();
                return;
            }
            _User = clsuserbusiness.FindUserBy(personID, clsuserbusiness.EnFindUserBy.PersonID);
            if (_User == null)
            {
                MessageBox.Show($"There is no a user with Person ID = {personID} !",
                    "Missing user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }
            _FillUserData();
        }
    }
}
