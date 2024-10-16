using System.Data;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsGradeSubjectBusiness
    {
        public enum enMode { add = 0, update = 1 }
        private enMode _Mode { get; set; }
        public enum enFindBy { GradeSubjectID, GradeID, SubjectID, Both }
        public int? GradeSubjectID { get; set; }
        public int? GradeID { get; set; }
        public int? SubjectID { get; set; }
        public decimal? Fees { get; set; }
        public string Titles { get; set; }
        public clsGradeSubjectBusiness GradeSubjectInfo { get; private set; }
        public clsGradeLevelBusiness GradeLevelInfo { get; private set; }
        public clsSubjectBusiness SubjectInfo { get; private set; }
        public clsGradeSubjectBusiness()
        {
            _Mode = enMode.add;
            GradeSubjectID = null;
            SubjectID = null;
            Fees = null;
            Titles = null;
            GradeID = null;
        }
        public clsGradeSubjectBusiness(int? GradeSubjectID, int? GradeID, int? SubjectID, decimal? Fees, string Titles)
        {
            _Mode = enMode.update;
            this.GradeSubjectID = GradeSubjectID;
            this.GradeID = GradeID;
            this.SubjectID = SubjectID;
            this.Fees = Fees;
            this.Titles = Titles;
            GradeLevelInfo = clsGradeLevelBusiness.findlevel(GradeID);
            SubjectInfo = clsSubjectBusiness.FindSubject(SubjectID);
        }
        static clsGradeSubjectBusiness FindGradeSubjectIDByGradeSubjectID(int? GradeSubjectID)
        {
            int? GradeID = null;
            int? SubjectID = null;
            decimal? Fees = null;
            string Titles = null;
            bool IsFound = clsGradeSubjectsData.FindGradeSubjectByGradeSubjectID(GradeSubjectID, ref GradeID, ref SubjectID, ref Fees, ref Titles);
            return IsFound ? new clsGradeSubjectBusiness(GradeSubjectID, GradeID, SubjectID, Fees, Titles) : null;
        }
        static clsGradeSubjectBusiness FindGradeSubjectIDByGradeID(int? GradeID)
        {
            int? GradeSubjectID = null;
            int? SubjectID = null;
            decimal? Fees = null;
            string Titles = null;
            bool IsFound = clsGradeSubjectsData.FindGradeSubjectByGradeID(ref GradeSubjectID, GradeID, ref SubjectID, ref Fees, ref Titles);
            return IsFound ? new clsGradeSubjectBusiness(GradeSubjectID, GradeID, SubjectID, Fees, Titles) : null;
        }
        static clsGradeSubjectBusiness FindGradeSubjectIDBySubjectID(int? SubjectID)
        {
            int? GradeSubjectID = null;
            int? GradeID = null;
            decimal? Fees = null;
            string Titles = null;
            bool IsFound = clsGradeSubjectsData.FindGradeSubjectBySubjectID(ref GradeSubjectID, ref GradeID, SubjectID, ref Fees, ref Titles);
            return IsFound ? new clsGradeSubjectBusiness(GradeSubjectID, GradeID, SubjectID, Fees, Titles) : null;
        }
        public static clsGradeSubjectBusiness FindGradeSubjectIDBy(int? value, clsGradeSubjectBusiness.enFindBy Way)
        {
            switch (Way)
            {
                case enFindBy.GradeSubjectID: return FindGradeSubjectIDByGradeSubjectID(value);
                case enFindBy.GradeID: return FindGradeSubjectIDByGradeID(value);
                case enFindBy.SubjectID: return FindGradeSubjectIDBySubjectID(value);
                default: return null;
            }
        }
        bool _AddGradeSubject()
        {
            GradeSubjectID = clsGradeSubjectsData.AddGradeSubject(GradeID, SubjectID, Fees);
            return GradeSubjectID.HasValue;
        }
        bool _UpdateGradeSubject() => clsGradeSubjectsData.UpdateGradeSubject(GradeSubjectID, GradeID, SubjectID, Fees);
        public bool SaveGradeSubject()
        {
            switch (_Mode)
            {
                case enMode.add:
                    {
                        if (_AddGradeSubject())
                        {
                            _Mode = enMode.update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.update:
                    {
                        return _UpdateGradeSubject();
                    }
                default: return false;
            }
        }
        static bool IsGradeSubjectExistByGradeSubject(int? GradeSubject) => clsGradeSubjectsData.IsGradeSubjectExistByGradeSubjectID(GradeSubject);
        static bool IsGradeSubjectExistByGradeID(int? GradeID) => clsGradeSubjectsData.IsGradeSubjectExistByGradeID(GradeID);
        static bool IsGradeSubjectExistBySubjectID(int? SubjectID) => clsGradeSubjectsData.IsGradeSubjectExistBySubjectID(SubjectID);
        public static bool IsGradeSubjectExistBy(int? value, clsGradeSubjectBusiness.enFindBy Way, int? value2 = null)
        {
            switch (Way)
            {
                case enFindBy.GradeSubjectID: return IsGradeSubjectExistByGradeSubject(value);
                case enFindBy.GradeID: return IsGradeSubjectExistByGradeID(value);
                case enFindBy.SubjectID: return IsGradeSubjectExistBySubjectID(value);
                case enFindBy.Both: return IsGradeSubjectExistByGradeAndSubject(value, value2);
                default: return false;
            }
        }
        public static DataTable ListGradeSubjectByPages(short pageNumber, int pageSize) => clsGradeSubjectsData.ListGradeSubjectByPages(pageNumber, pageSize);
        public static DataTable ListGradeSubject() => clsGradeSubjectsData.ListGradeSubject();
        public static int CountGradeSubjects() => clsGradeSubjectsData.CountGradeSubjects();
        static bool IsGradeSubjectExistByGradeAndSubject(int? GradeID, int? SubjectID) => clsGradeSubjectsData.IsGradeSubjectExistByGradeAndSubject(GradeID, SubjectID);
        public static DataTable ListGradeSubjectNotAssignedToTeacherID(int? TeacherID) => clsGradeSubjectsData.ListGradeSubjectNotAssignedToTeacherID(TeacherID);
    }
}
