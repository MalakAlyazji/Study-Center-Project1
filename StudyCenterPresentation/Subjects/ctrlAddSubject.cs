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
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class ctrlAddSubject : UserControl
    {
       int? _SubjectID=null;
        clsSubjectBusiness _Subject = null;
        public int? SubjectID => _SubjectID;
        public clsSubjectBusiness Subject => _Subject;
        public ctrlAddSubject()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            lblSubjectID.Text = "[????]";
            txtSubjectName.Text = null;
        }
        void _FillSubjectToUpdate()
        {
            lblSubjectID.Text=_Subject.SubjectID.ToString();
            txtSubjectName.Text= _Subject.SubjectName.ToString();
        }
        public void LoadSubjectInfo(int ? SubjectID)
        {
            _SubjectID = SubjectID;
            if (_SubjectID == null)
            {
                Reset();
                clsShowMessage.IdNotFound("Subject",SubjectID);
                return;
            }
            _Subject = clsSubjectBusiness.FindSubject(_SubjectID);
            _FillSubjectToUpdate();
        }
        private void txtSubjectName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSubjectName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSubjectName, null);
            }
        }
    }
}
