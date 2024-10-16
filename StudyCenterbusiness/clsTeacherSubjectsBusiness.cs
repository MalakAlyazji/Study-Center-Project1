using System.Data;
using StudyCenterBusinesss;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsTeacherSubjectsBusiness
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public enum enFindBy { TeacherSubjectID, TeacherID, ClassID, SubjectID, Pages, listAll, GradeLevelSubjectID, Both }
        public int? TeacherSubjectID { get; set; }
        public int? TeacherID { get; set; }
        public int? GradeLevelSubjectID { get; set; }
        public clsteacherbusiness TeacherInfo { get; private set; }
        public clsGradeSubjectBusiness GradeSubjectInfo { get; private set; }
        public clsTeacherSubjectsBusiness(int? teacherSubjectID, int? teacherID, int? gradeLevelSubjectID)
        {
            TeacherSubjectID = teacherSubjectID;
            TeacherID = teacherID;
            GradeLevelSubjectID = gradeLevelSubjectID;
            _Mode = enMode.Update;
            TeacherInfo = clsteacherbusiness.FindBy(TeacherID, clsteacherbusiness.enFindBy.teacherid);
            GradeSubjectInfo = clsGradeSubjectBusiness.FindGradeSubjectIDBy(GradeLevelSubjectID, clsGradeSubjectBusiness.enFindBy.GradeSubjectID);
        }
        public clsTeacherSubjectsBusiness()
        {
            _Mode = enMode.Add;
            TeacherSubjectID = null;
            TeacherID = null;
            GradeLevelSubjectID = null;
        }
        static clsTeacherSubjectsBusiness _FindTeacherSubjectsByTeacherSubjectID(int? TeacherSubjectID)
        {
            int? TeacherID = null;
            int? GradeLevelSubjectID = null;
            bool IsFound = clsTeacherSubjectsData.FindTeacherSubjectsByTeacherSubjectID(TeacherSubjectID, ref TeacherID, ref GradeLevelSubjectID);
            return IsFound ? new clsTeacherSubjectsBusiness(TeacherSubjectID, TeacherID, GradeLevelSubjectID) : null;
        }
        static clsTeacherSubjectsBusiness _FindTeacherSubjectsByTeacherID(int? TeacherID)
        {
            int? TeacherSubjectID = null;
            int? GradeLevelSubjectID = null;
            bool IsFound = clsTeacherSubjectsData.FindTeacherSubjectsByTeachertID(ref TeacherSubjectID, TeacherID, ref GradeLevelSubjectID);
            return IsFound ? new clsTeacherSubjectsBusiness(TeacherSubjectID, TeacherID, GradeLevelSubjectID) : null;
        }
        static clsTeacherSubjectsBusiness _FindTeacherSubjectsBySubjectID(int? GradeLevelSubjectID)
        {
            int? TeacherSubjectID = null;
            int? TeacherID = null;
            bool IsFound = clsTeacherSubjectsData.FindTeacherSubjectsByGradeLevelSubjectID(ref TeacherSubjectID, ref TeacherID, GradeLevelSubjectID);
            return IsFound ? new clsTeacherSubjectsBusiness(TeacherSubjectID, TeacherID, GradeLevelSubjectID) : null;
        }
        public static clsTeacherSubjectsBusiness FindTeacherSubjectsBy(int? value, clsTeacherSubjectsBusiness.enFindBy Way)
        {
            switch (Way)
            {
                case enFindBy.TeacherSubjectID: { return _FindTeacherSubjectsByTeacherSubjectID(value); }
                case enFindBy.TeacherID: { return _FindTeacherSubjectsByTeacherID(value); }
                case enFindBy.GradeLevelSubjectID: { return _FindTeacherSubjectsBySubjectID(value); }
                default: return null;
            }
        }
        bool _AddTeacherSubjects()
        {
            TeacherSubjectID = clsTeacherSubjectsData.AddTeacherSubject(TeacherID, GradeLevelSubjectID);
            return TeacherSubjectID.HasValue;
        }
        bool _UpdateTeacherSubject() => clsTeacherSubjectsData.UpdateTeacherSubject(TeacherSubjectID, TeacherID, GradeLevelSubjectID);
        public bool SaveTeacherSubject()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddTeacherSubjects())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateTeacherSubject();
                    }
                default: return false;
            }
        }
        static bool IsTeacherSubjectExistByTeacherSubjectID(int? TeacherSubjectID) => clsTeacherSubjectsData.IsTeacherSubjectExistByTeacherSubjectID(TeacherSubjectID);
        static bool IsTeacherSubjectExistByTeacherID(int? TeacherID) => clsTeacherSubjectsData.IsTeacherSubjectExistByTeacherID(TeacherID);
        static bool IsTeacherSubjectExistBySubjectID(int? SubjectID) => clsTeacherSubjectsData.IsTeacherSubjectExistBySubjectID(SubjectID);
        static bool IsTeacherSubjectExistByTeachrAndSubjectID(int? TeacherID, int? SubjectID) => clsTeacherSubjectsData.IsTeacherSubjectExistByTeachrAndSubjectID(TeacherID, SubjectID);
        public static bool IsTeacherSubjectExistBy(int? value, clsTeacherSubjectsBusiness.enFindBy Way, int? value2 = null)
        {
            switch (Way)
            {
                case enFindBy.TeacherSubjectID: return IsTeacherSubjectExistByTeacherSubjectID(value);
                case enFindBy.TeacherID: return IsTeacherSubjectExistByTeacherID(value);
                case enFindBy.GradeLevelSubjectID: return IsTeacherSubjectExistBySubjectID(value);
                case enFindBy.Both: return IsTeacherSubjectExistByTeachrAndSubjectID(value, value2);
                default: return false;
            }
        }
        public static DataTable ListTeacherSubjectByPages(short pageNumber, int pageSize) => clsTeacherSubjectsData.ListTeacherSubjectByPages(pageNumber, pageSize);
        static DataTable ListTeacherSubjects() => clsTeacherSubjectsData.ListTeacherSubjects();
        static DataTable ListTeacherSubjectsByTeacherID(int? TeacherID) => clsTeacherSubjectsData.ListTeacherSubjectsByTeacherID(TeacherID);
        static DataTable ListTeacherSubjectsBySelectedTeacherSubjectID(int? SelectedTeacherSubjectID) => clsTeacherSubjectsData.ListTeacherSubjectsBySelectedTeacherSubjectID(SelectedTeacherSubjectID);
        static DataTable ListTeachersSubjectByClassID(int? ClassID) => clsTeacherSubjectsData.ListTeachersSubjectByClassID(ClassID);
        static DataTable ListTeachersSubjectBySubjectID(int? SubjectID) => clsTeacherSubjectsData.ListTeachersSubjectBySubjectID(SubjectID);
        public static DataTable ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy Way, int? Value = null)
        {
            switch (Way)
            {
                case enFindBy.TeacherSubjectID: return ListTeacherSubjectsBySelectedTeacherSubjectID(Value);
                case enFindBy.ClassID: return ListTeachersSubjectByClassID(Value);
                case enFindBy.TeacherID: return ListTeacherSubjectsByTeacherID(Value);
                case enFindBy.listAll: return ListTeacherSubjects();
                case enFindBy.SubjectID: return ListTeachersSubjectBySubjectID(Value);
                default: return null;
            }
        }
    }
}
