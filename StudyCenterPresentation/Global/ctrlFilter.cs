using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class ctrlFilter : UserControl
    {
        public void FilterFocus() => txtfilter.Focus();
        public class SearchClickEventArgs : EventArgs
        {
            public int Value { get; }
            public string FieldName { get; }

            public SearchClickEventArgs(int value, string fieldName)
            {
                Value = value;
                FieldName = fieldName;
            }
        }
        public event EventHandler<SearchClickEventArgs> OnSearchClick;
        public event EventHandler OnAddClick;
        private bool _filterEnable;
        public bool FilterEnabled
        {
            get => _filterEnable;
            set => gbfilter.Enabled = _filterEnable = value;
        }
        public ctrlFilter()
        {
            InitializeComponent();
        }
        private void txtfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnsearch_Click(this, EventArgs.Empty);
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields contain invalid data. Please correct the errors indicated by the red icons.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtfilter.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cbfilter.Text))
                return;
            if (OnSearchClick != null)
                OnSearchClick?.Invoke(sender, new SearchClickEventArgs(int.Parse(txtfilter.Text), cbfilter.Text));
        }
        private void btnaddperson_Click(object sender, EventArgs e)
        {
            OnAddClick?.Invoke(sender, e);
        }
        public void FillComboBox((string name, bool isnumeric)[] items)
        {
            cbfilter.Items.Clear();

            if (items == null || items.Length == 0) return;

            foreach (var (name, _) in items)
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    cbfilter.Items.Add(name);
                }
            }
            if (cbfilter.Items.Count > 0)
            {
                cbfilter.SelectedIndex = 0;
            }
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilter.Clear();
            txtfilter.Focus();
        }
        private void txtfilter_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtfilter, "This field cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtfilter, null);
            }
        }
        private void txtfilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtfilter, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtfilter, null);
            }
        }
    }
}
