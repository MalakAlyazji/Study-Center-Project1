using System;
using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class ctrlStudentIfoFILTER : UserControl
    {
        public class SelectedStudentEventArgs : EventArgs
        {
            public int? StudentID = null;
            public SelectedStudentEventArgs(int? StudentId)
            {
                StudentID = StudentId;
            }
        }
        public event EventHandler<SelectedStudentEventArgs> OnStudentSelected;
        public int? StudentID => ctrlstudentcard1.StudentID;
        public clsstudentbusiness StudentInfo => ctrlstudentcard1.StudentInfo;
        public void Reset() => ctrlstudentcard1.Reset();
        public bool FilterEnabled
        {
            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }
        public ctrlStudentIfoFILTER()
        {
            InitializeComponent();
            ctrlFilter1.FillComboBox(new[] { ("Person ID", true), ("Student ID", true) });
        }
        public void LoadStudentInfoByStudentID(int? StudentID)
        {
            ctrlFilter1.cbfilter.SelectedIndex = 1;
            ctrlFilter1.txtfilter.Text = StudentID.ToString();
            ctrlstudentcard1.LoadStudentInfoByStudentID(StudentID);
            int? selectedStudentID = ctrlstudentcard1?.StudentID;
            if (selectedStudentID.HasValue && OnStudentSelected != null)
            {
                OnStudentSelected.Invoke(this, new SelectedStudentEventArgs(selectedStudentID));
            }
        }
        public void LoadStudentInfoByPersonID(int? PersonID)
        {
            ctrlstudentcard1.LoadStudentInfoByPersonID(PersonID);
            ctrlFilter1.cbfilter.SelectedIndex = 0;
            ctrlFilter1.txtfilter.Text = PersonID.ToString();
            int? selectedStudentID = ctrlstudentcard1?.StudentID;
            if (selectedStudentID.HasValue && OnStudentSelected != null)
            {
                OnStudentSelected.Invoke(this, new SelectedStudentEventArgs(selectedStudentID));
            }
        }
        private void ctrlFilter1_OnSearchClick(object sender, ctrlFilter.SearchClickEventArgs e)
        {
            switch (e?.FieldName)
            {
                case "Person ID":
                    LoadStudentInfoByPersonID(e?.Value);
                    break;
                case "Student ID":
                    LoadStudentInfoByStudentID(e?.Value);
                    break;

            }
        }
        private void ctrlFilter1_OnAddClick(object sender, EventArgs e)
        {
            frmaddstudent frmaddstudent = new frmaddstudent();
            frmaddstudent.ShowDialog();
            frmaddstudent.StudentIDBack += LoadStudentInfoByStudentID;
        }
        private void ctrlFilter1_Load(object sender, EventArgs e)
        {
            ctrlFilter1.FilterFocus();
        }
    }
}
