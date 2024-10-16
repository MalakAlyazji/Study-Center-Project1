using System.Data;
using StudyCenterData;
namespace StudyCenterbusiness
{
    public class clsSubjectBusiness
    {
        enum enMode { Add, Update }
        enMode _Mode;
        public int? SubjectID { get; set; }
        public string SubjectName { get; set; }
        public clsSubjectBusiness(int? subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            _Mode = enMode.Update;
        }
        public clsSubjectBusiness()
        {
            SubjectID = null;
            SubjectName = null;
            _Mode = enMode.Add;
        }
        public static clsSubjectBusiness FindSubject(int? subjectID)
        {
            string SubjectName = string.Empty;
            bool IsFound = clsSubjectsData.FindSubject(subjectID, ref SubjectName);
            if (IsFound)
            {
                return new clsSubjectBusiness(subjectID, SubjectName);
            }
            else
            {
                return null;
            }
        }
        bool _AddSubject()
        {
            SubjectID = clsSubjectsData.AddSubject(SubjectName);
            return SubjectID.HasValue;
        }
        bool _UpdateSubject()
        {
            return clsSubjectsData.UpdateSubject(SubjectID, SubjectName);
        }
        public bool SaveSubjects()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {

                        if (_AddSubject())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _UpdateSubject();
                    }
                default
                :
                    {
                        return false;
                    }
            }
        }
        public static string GetSubjectNameByID(int? SubjectID) => clsSubjectsData.GetSubjectNameByID(SubjectID);
        public static int? GetSubjecIDByName(string SubjectName) => clsSubjectsData.GetSubjectIDByName(SubjectName);
        public static bool DeleteSubject(int? SubjectID) => clsSubjectsData.DeleteSubject(SubjectID);
        public static bool IsSubjectExistBySubjectID(int? SubjectID) => clsSubjectsData.IsSubjectExistBySubjectID(SubjectID);
        public static bool IsSubjectExistBySubjectName(string SubjectName) => clsSubjectsData.IsSubjectExistBySubjectName(SubjectName);
        public static DataTable ListSubjects() => clsSubjectsData.ListSubjects();
        public static DataTable GetSubjectNames() => clsSubjectsData.GetSubjectNames();
        public static int? CountSubjects() => clsSubjectsData.CountSubjects();
    }
}
