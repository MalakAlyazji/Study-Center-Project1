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
    public partial class ctrlAddClass : UserControl
    {
        int? _ClassID=null;
        public int? ClassID => _ClassID;
        clsClassBusiness _Class = null;
        public clsClassBusiness Class => _Class;
        public ctrlAddClass()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            _ClassID = null;
            _Class = null;
            lblClassID.Text = "[????]";
            txtCapacity.Text = "";
            txtClassName.Text = "";
        }
        private void _FillToUpdate()
        {
            txtCapacity.Text= _Class.Capacity.ToString();
            txtClassName.Text= _Class.ClassName.ToString();
            lblClassID.Text= _Class.ClassID.ToString();
        }
        public void LoadClassByClassID(int? ClassID)
        {
            _ClassID= ClassID;
            if (_ClassID == null)
            {
                clsShowMessage.IdNotFound("Class", ClassID);
                Reset();
                return;
            }
            _Class=clsClassBusiness.FindClassByClassID(ClassID);
            if (_Class == null)
            {
                clsShowMessage.IdNotFound("Class", ClassID);
                Reset();
                return;
            }
            _FillToUpdate();
        }
        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtClassName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClassName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtClassName, null);
            }
        }

        private void txtCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapacity.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCapacity, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCapacity, null);
            }
        }
    }
}
