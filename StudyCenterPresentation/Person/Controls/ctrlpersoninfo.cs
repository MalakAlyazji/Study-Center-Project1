using System;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterPresentation.Person;

namespace StudyCenterPresentation
{
    public partial class ctrlpersoninfo : UserControl
    {
        private int? _personid;
        public int? personid => _personid;
        private clspeoplebusiness _person = null;
        public clspeoplebusiness PersonInfo => _person;
        public ctrlpersoninfo()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            _person = null;
            _personid = null;
            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAddress.Text = "[????]";
            lblage.Text = "[????]";
            linkeditperson.Enabled = false;
        }
        private void _fillpersoninfo()
        {
            lblPersonID.Text = _person.PersonID.ToString();
            lblFullName.Text = _person.FullName.ToString();
            lblGender.Text = _person.GenderText;
            lblEmail.Text = _person.Email.ToString();
            lblPhone.Text = _person.Phone.ToString();
            lblDateOfBirth.Text = clsFormat.DateToString(_person.BirthDate);
            lblAddress.Text = _person.Address.ToString();
            lblage.Text = (DateTime.Now.Year - _person.BirthDate.Value.Year).ToString();
            linkeditperson.Enabled = true;
        }
        public void loadpersoninfo(int? personid)
        {
            _personid = personid;
            if (!_personid.HasValue)
            {
                clsShowMessage.IdNotFound("Person", personid);
                Reset();
                return;
            }
            _person = clspeoplebusiness.Find(personid);
            if (_person == null)
            {
                clsShowMessage.IdNotFound("Person", _personid.Value);
                Reset();
                return;
            }
            _fillpersoninfo();
        }
        private void linkeditperson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddeditperson frmaddperson = new frmaddeditperson(_personid);
            frmaddperson.ShowDialog();
            loadpersoninfo(_personid);
        }


    }
}
