using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterPresentation.Person;

namespace StudyCenterPresentation
{
    public partial class ctrlpersoninfoFITER : UserControl
    {
        public class PersonSelectedEventArgs : EventArgs
        {
            public int? PersonID { get; }

            public PersonSelectedEventArgs(int? personID)
            {
                PersonID = personID;
            }
        }
        public event EventHandler<PersonSelectedEventArgs> OnPersonSelected;
        public int? PersonID => ctrlpersoninfo1.personid;
        public clspeoplebusiness PersonInfo => ctrlpersoninfo1.PersonInfo;
        public void FilterFocus() => ctrlFilter1.FilterFocus();
        public void Reset() => ctrlpersoninfo1.Reset();
        public bool FilterEnable
        {
            get=>ctrlFilter1.FilterEnabled;
            set=> ctrlFilter1.FilterEnabled=value;
        }
        public ctrlpersoninfoFITER()
        {
            InitializeComponent();
            ctrlFilter1.FillComboBox(new[] { ("Person ID", true) });
        }
        public void LoadPersonInfo(int? PersonID)
        {
            ctrlFilter1.cbfilter.SelectedIndex = 0;
            ctrlFilter1.txtfilter.Text=PersonID.ToString();
            ctrlpersoninfo1.loadpersoninfo(PersonID);
            if(OnPersonSelected!=null)
                OnPersonSelected?.Invoke(this, new PersonSelectedEventArgs(ctrlpersoninfo1.personid));
        }
        private void ctrlFilter1_OnAddClick(object sender, EventArgs e)
        {
            frmaddeditperson  frmaddeditperson = new frmaddeditperson();
            frmaddeditperson.ShowDialog();
            frmaddeditperson.PersonIDBack += LoadPersonInfo;
        }
        private void ctrlFilter1_OnSearchClick(object sender, ctrlFilter.SearchClickEventArgs e)
        {
            switch (e?.FieldName)
            {
                case "Person ID":
                    LoadPersonInfo(e?.Value);
                    break;
            }
        }
    }
}
