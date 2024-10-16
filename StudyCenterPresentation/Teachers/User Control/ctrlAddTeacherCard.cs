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
using StudyCenterBusinesss;

namespace StudyCenterPresentation
{
    public partial class ctrlTeacherCard : UserControl
    {
        int? _teacherID = null;
        public int? TeacherID=> _teacherID;
        int? _PersonID = null;
        clspeoplebusiness _Person = null;
        public int? PersonID=> _PersonID;
        clsteacherbusiness _Teacher=null;
        public clsteacherbusiness TeacherInfo=> _Teacher;
        public clspeoplebusiness PersonInfo => _Person;
        public ctrlTeacherCard()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            ctrlpersoninfo1.Reset();
            ctrlEditTeacher1.Reset();
        }
        public void LoadTeacherInfoByPersonID(int? PersonID)
        {
            
            ctrlpersoninfo1.loadpersoninfo(PersonID);
            ctrlEditTeacher1.LoadTeacherByPersonID(PersonID);
        }
        public void LoadTeacherInfoByTeacherID(int? TeacherID)
        {
            _teacherID = TeacherID;
            if (_teacherID == null)
            {
                clsShowMessage.IdNotFound("Teacher", TeacherID);
                Reset();
                return;
            }
            _Teacher = clsteacherbusiness.FindBy(_teacherID, clsteacherbusiness.enFindBy.teacherid);
            if (_Teacher == null)
            {
                clsShowMessage.GeneralErrorMessage("Could'nt Find a Teacher!");
                Reset();
                return;
            }
            ctrlpersoninfo1.loadpersoninfo(_Teacher.PersonID);
            ctrlEditTeacher1.LoadTeacherByTeacherID(_teacherID);
        }

    }
}
