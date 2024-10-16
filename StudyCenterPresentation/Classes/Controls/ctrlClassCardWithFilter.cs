using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlClassCardWithFilter : UserControl
    {
        public class SelectedClassEventArgs : EventArgs
        {
            public int? ClassID { get; }
            public SelectedClassEventArgs(int? ClassID)
            {
                this.ClassID = ClassID;
            }
        }
        public event EventHandler<SelectedClassEventArgs> OnClassSelected;
        public bool FilterEnabled
        {
            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }
        public void FilterFocus()=>ctrlFilter1.Focus();
        public int? ClassID=>ctrlClassInfo1.ClassID;
        public clsClassBusiness ClassInfo=>ctrlClassInfo1.ClassInfo;
        public ctrlClassCardWithFilter()
        {
            InitializeComponent();
            ctrlFilter1.FillComboBox(new[] { ("Class ID", true) });
        }
        public void LoadClassInfoByClassID(int ? ClassID)
        {
            ctrlFilter1.txtfilter.Text = ClassID.ToString();    
            ctrlFilter1.cbfilter.SelectedIndex = 0;
            ctrlClassInfo1.LoadClassInfoByClassID(ClassID);
            if (OnClassSelected !=null)
            {
                OnClassSelected.Invoke(this,new SelectedClassEventArgs(ClassID));
            }
        }
        private void ctrlFilter1_OnSearchClick(object sender, ctrlFilter.SearchClickEventArgs e)
        {
            switch (e.FieldName)
            {
                case "Class ID":
                    LoadClassInfoByClassID(e?.Value); break;
            }
        }
        private void ctrlFilter1_OnAddClick(object sender, EventArgs e)
        {
            frmAddClass frmAddClass= new frmAddClass();
            frmAddClass.ClassIDBack += LoadClassInfoByClassID;
            frmAddClass.ShowDialog();
        }
        private void ctrlClassCardWithFilter_Load(object sender, EventArgs e)=>ctrlFilter1.Focus();
        public void Reset()=>ctrlClassInfo1.Reset();
    }
}
