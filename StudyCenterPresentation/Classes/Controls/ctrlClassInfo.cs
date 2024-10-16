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
    public partial class ctrlClassInfo : UserControl
    {
        int? _ClassID;
        clsClassBusiness _Class;
        public int? ClassID=>_ClassID;
        public clsClassBusiness ClassInfo=>_Class;
        public ctrlClassInfo()
        {
            InitializeComponent();
            if(!_ClassID.HasValue) lnkClassInfo.Enabled = false;
        }
         public void Reset()
        {
            _ClassID = null;
            _Class = null;
            lblClassID.Text =" [????]";
            lblClassName.Text = " [????]";
            blCapacity.Text = " [????]";
            lnkClassInfo.Enabled = false;
        }
        void _FillClassInfo()
        {
            lblClassID.Text = _Class.ClassID.ToString();
            lblClassName.Text = _Class.ClassName;
            blCapacity.Text = _Class. Capacity.ToString();
            lnkClassInfo.Enabled=true;
        }
        public void LoadClassInfoByClassID(int? ClassID)
        {
            if (!ClassID.HasValue)
            {
                clsShowMessage.IdNotFound("Class", ClassID);
                Reset();
                return;
            }
            _ClassID= ClassID;
            _Class=clsClassBusiness.FindClassByClassID(_ClassID);
            if (_Class == null)
            {
                clsShowMessage.GeneralErrorMessage("Class Not Found");
                Reset();
                return;
            }
            _FillClassInfo();
        }
        private void lnkClassInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddClass frmAddClass= new frmAddClass(_ClassID);
            frmAddClass.ClassIDBack += LoadClassInfoByClassID;
            frmAddClass.ShowDialog();
        }
    }
}
