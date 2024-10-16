using System;
using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class ctrlTeacherCardWithFilter : UserControl
    {
        public class TeacherSelectedEventArgs : EventArgs
        {
            public int? TeacherID { get; }

            public TeacherSelectedEventArgs(int? teacherID)
            {
                TeacherID = teacherID;
            }
        }
        public event EventHandler<TeacherSelectedEventArgs> OnTeacherSelected;
        public int? TeacherID => ctrlTeacherCard1.TeacherID;
        public bool FilterEnabled { get => ctrlFilter1.Enabled; set => ctrlFilter1.Enabled = value; }
        public ctrlTeacherCardWithFilter()
        {
            InitializeComponent();
            ctrlFilter1.FillComboBox(new[] { ("Teacher ID", true), ("Person ID", true) });
        }
        public void Reset() => ctrlTeacherCard1.Reset();
        public void LoadTeacherByTeacherID(int? TeacherID)
        {
            ctrlFilter1.cbfilter.SelectedItem = "Teacher ID";
            ctrlFilter1.txtfilter.Text = TeacherID.ToString();
            ctrlTeacherCard1.LoadTeacherInfoByTeacherID(TeacherID);
            ctrlFilter1.Enabled = false;
            if (OnTeacherSelected != null)
            {
                OnTeacherSelected?.Invoke(this, new TeacherSelectedEventArgs(ctrlTeacherCard1?.TeacherID));
            }
        }
        public void LoadTeacherByPersonID(int? PersonID)
        {
            ctrlFilter1.cbfilter.SelectedItem = "Person ID";
            ctrlFilter1.txtfilter.Text = PersonID.ToString();
            ctrlTeacherCard1.LoadTeacherInfoByPersonID(PersonID);
            if (OnTeacherSelected != null)
            {
                OnTeacherSelected?.Invoke(this, new TeacherSelectedEventArgs(ctrlTeacherCard1?.TeacherID));
            }
        }
        private void ctrlTeacherCard1_Load(object sender, EventArgs e)
        {
            ctrlFilter1.FilterFocus();
        }
        private void ctrlFilter1_OnAddClick(object sender, EventArgs e)
        {
            frmaddteacher frmaddteacher = new frmaddteacher();
            frmaddteacher.TeacherIDBack += LoadTeacherByTeacherID;
            frmaddteacher.ShowDialog();
        }
        private void ctrlFilter1_OnSearchClick(object sender, ctrlFilter.SearchClickEventArgs e)
        {
            switch (e.FieldName)
            {
                case "Teacher ID":
                    LoadTeacherByTeacherID(e?.Value); break;
                case "Person ID":
                    LoadTeacherByPersonID(e?.Value);
                    break;
            }
        }
    }
}
