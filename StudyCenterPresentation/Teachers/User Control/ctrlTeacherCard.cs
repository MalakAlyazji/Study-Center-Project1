using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCenterBusinesss;

namespace StudyCenterPresentation
{
    public partial class ctrlTeacherCard : UserControl
    {
        int? _TeacherID=null;
        int? _personID=null;
        clsteacherbusiness _Teacher=null;
        public clsteacherbusiness TeacherInfo => _Teacher;
        public int? TeacherID => _TeacherID;
        public int? PersonID => _personID;
        public ctrlTeacherCard()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            ctrlpersoninfo1.Reset();
            ctrlteacherinfo1.Reset();
        }
        
        public void LoadTeacherInfoByTeacherID(int? TeacherID)
        {
            if (!TeacherID.HasValue)
            {
                clsShowMessage.IdNotFound("Teacher", TeacherID);
                Reset();
                return;
            }
            _TeacherID = TeacherID;
            _Teacher =clsteacherbusiness .FindBy(TeacherID,clsteacherbusiness.enFindBy.teacherid);
            if(_Teacher == null )
            {
                clsShowMessage.ShowMissingDataMessage("Teacher", _TeacherID);
                Reset();
                return;
            }
            ctrlpersoninfo1.loadpersoninfo(_Teacher.PersonID);
            ctrlteacherinfo1.LoadTeacherInfoByTeacherID(_TeacherID);
        }
        public void LoadTeacherInfoByPersonID(int? PersonID)
        {
            if (!PersonID.HasValue)
            {
                clsShowMessage.IdNotFound("Person", PersonID);
                Reset();
                return;
            }
            _personID = PersonID;
            _Teacher = clsteacherbusiness.FindBy(PersonID, clsteacherbusiness.enFindBy.personid);
            if (_Teacher == null)
            {
                clsShowMessage.ShowMissingDataMessage("Teacher", _TeacherID);
                Reset();
                return;
            }
            ctrlpersoninfo1.loadpersoninfo(_Teacher.PersonID);
            ctrlteacherinfo1.LoadTeacherInfoByPersonID(_Teacher.PersonID);
        }
    }
}
