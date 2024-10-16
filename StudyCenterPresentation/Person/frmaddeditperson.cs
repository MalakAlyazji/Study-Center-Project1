using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using StudyCenterBuisness;

namespace StudyCenterPresentation.Person
{
    public partial class frmaddeditperson : Form
    {
        int? _personid = null;
        clspeoplebusiness _person=null;
        private enum _enMode { Add, Update }
        _enMode mode = _enMode.Add;
        public Action<int?> PersonIDBack;
        public frmaddeditperson()
        {
            InitializeComponent();
            mode = _enMode.Add;
        }
        public frmaddeditperson(int? personid)
        {
            InitializeComponent();
            mode= _enMode.Update;
            _personid = personid;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetTitles()
        {
            if (mode == _enMode.Add)
            {
                lbltitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _person=new clspeoplebusiness();
            }
            else if (mode == _enMode.Update)
            {
                lbltitle.Text = "Update Person Information";
                this.Text = "Update Person Information";
            }
        }
        private void _saveinput()
        {
            _person.FirstName=txtfirstname.Text;
            _person.LastName=txtlastname.Text;
            _person.Email=txtemail.Text;
            _person .Address =string.IsNullOrEmpty(  txtaddresss.Text)?null: txtaddresss.Text;
            _person.Phone = string.IsNullOrEmpty( txtphone.Text)?null: txtphone.Text;
            _person.Gender = rbMale.Checked ? clspeoplebusiness.EnGender.Male:clspeoplebusiness.EnGender.Female;
            _person.BirthDate = datebirth.Value;
        }
        private void _SavePerson()
        {
            _saveinput();
            if (_person.SavePerson())
            {
                mode = _enMode.Update;
                this.Text = "Update Person Info";
                lbltitle.Text = "Update Person Info";
                lblPersonID.Text = _person.PersonID.ToString();
                PersonIDBack?.Invoke(_person?.PersonID);
                clsShowMessage.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!_CheckCorrectData())
            {
                return;
            }
            if (!ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }
            _SavePerson();
        }
        private void _fillpersoninfo()
        {
            lblPersonID.Text = _person.PersonID.ToString(); 
            txtemail.Text=_person.Address.ToString();
            txtfirstname.Text = _person.FirstName.ToString();
            txtlastname.Text = _person.LastName.ToString();
            txtphone.Text = _person.Phone.ToString();
            txtemail.Text   = _person.Email.ToString();
            datebirth.Value = (DateTime)_person.BirthDate;
            rbMale.Checked = _person.Gender == 0 ? true : rbFemale.Checked = true;
        }
        private void _loadpersoninfo()
        {
            _person = clspeoplebusiness.Find(_personid);
            if (_person == null)
            {
                clsShowMessage.IdNotFound("Person", _personid); 
                this.Close();
                return;
            }
            _fillpersoninfo();
        }
        private void validatetextbox(object sender, CancelEventArgs e)
        {
            Guna2TextBox g= (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(g.Text))
            {
                e.Cancel=true;
                errorProvider1.SetError(g, "This field is required.");
            }
            else
            {
                errorProvider1.SetError(g, null);
            }
        }
        private void frmaddperson_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (mode == _enMode.Update) {
                _loadpersoninfo();
            }
        }
        private bool _CheckCorrectData()
        {
            if (!rbFemale.Checked && !rbMale.Checked)
            {
                errorProvider1.SetError(rbFemale, "You must select Gender");
                return false;
            }
            return true;
        }
        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsvalidation.ValidateEmail(txtemail.Text))
            {
                e.Cancel=true ;
                txtemail.Focus();
                errorProvider1.SetError(txtemail, "Invalid Email Address Format!");
            }
        }
    }
}
