using System;
using System.ComponentModel;
using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ValidatingOfTextBoxes(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(((TextBox)sender), "This field is required!");
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), null);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ShowValidationErrorMessage();
                return;
            }
            string username = txtuserid.Text;
            string pass = txtpass.Text;
            clsuserbusiness User = clsuserbusiness.FindUserBy(username.Trim(), clsuserbusiness.EnFindUserBy.UserNameAndPassword, pass.Trim());
            if (User == null)
            {
                txtuserid.Focus();
                clsShowMessage.ShowWrongCredentials();
                return;
            }
            if (chkremember.Checked)
            {
                clsGlobal.RememberUSernameAndPass(username.Trim(), clsGlobal.Encrypt(pass.Trim()));
            }
            else
            {
                clsGlobal.RememberUSernameAndPass(null, null);
            }
            if (!User.IsActive)
            {
                clsShowMessage.GeneralErrorMessage("Your Account is not Active!");
                return;
            }
            clsGlobal.LogInUser = User;
            Hide();
            MainForm Main = new MainForm(this);
            Main.ShowDialog();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            if (clsGlobal.GetStoredcredential(ref username, ref password))
            {
                txtuserid.Text = username;
                txtpass.Text = clsGlobal.Decrypt(password);
                chkremember.Checked = true;
            }
            else
                chkremember.Checked = false;
        }
    }
}
