using System;
using System.Data;
using StudyCenterData;
namespace StudyCenterBuisness
{
    public class clsstudentbusiness : clspeoplebusiness
    {
        public enum enMode { add = 0, update = 1 }
        private enMode _Mode { get; set; }
        public enum enfindby { studentid, personid }
        public int? StudentID { get; set; }
        public int? PersonID { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int? GradeLevelID { get; set; }
        public string EmergencyContactPhone { get; set; }
        public int? UserID { get; set; }
        public string GetUserName { get; private set; }
        public clsstudentbusiness() : base()
        {
            _Mode = enMode.add;
            StudentID = null;
            PersonID = null;
            EnrollmentDate = null;
            GradeLevelID = null;
            UserID = null;
            EmergencyContactPhone = string.Empty;
        }
        clsstudentbusiness(int? StudentID, int? PersonID, DateTime? EnrollmentDate, int? GradeLevelID, string EmergencyContactPhone
            , int? UserID, string FirstName, string LastName, DateTime? BirthDate, string Phone, string Email, string Address, EnGender gender)
            : base(PersonID, FirstName, LastName, gender, BirthDate, Phone, Email, Address)
        {
            _Mode = enMode.update;
            this.StudentID = StudentID;
            this.PersonID = PersonID;
            this.EnrollmentDate = EnrollmentDate;
            this.GradeLevelID = GradeLevelID;
            this.EmergencyContactPhone = EmergencyContactPhone;
            this.UserID = UserID;
            GetUserName = clsuserbusiness.FindUserBy(UserID, clsuserbusiness.EnFindUserBy.UserID).UserName;
        }
        static clsstudentbusiness FindStudentbyStudentID(int? StudentID)
        {
            int? PersonID = null;
            DateTime? EnrollmentDate = null;
            int? GradeLevelID = null;
            int? UserID = null;
            string EmergencyContactPhone = string.Empty;
            bool isfound = clsstudentdata.FindStudentbyStudentID(StudentID, ref PersonID, ref EnrollmentDate, ref GradeLevelID, ref EmergencyContactPhone, ref UserID);
            if (isfound)
            {
                clspeoplebusiness person = clspeoplebusiness.Find(PersonID);
                if (person != null)
                {
                    return new clsstudentbusiness(StudentID, PersonID, EnrollmentDate, GradeLevelID, EmergencyContactPhone, UserID, person.FirstName, person.LastName,
                                    person.BirthDate, person.Phone, person.Email, person.Address, person.Gender);
                }
                return null;
            }
            return null;
        }
        static clsstudentbusiness FindStudentbyPersonID(int? PersonID)
        {
            int? StudentID = null;
            DateTime? EnrollmentDate = null;
            int? GradeLevelID = null;
            int? UserID = null;
            string EmergencyContactPhone = string.Empty;
            bool isfound = clsstudentdata.FindStudentbyPersonID(ref StudentID, PersonID, ref EnrollmentDate, ref GradeLevelID, ref EmergencyContactPhone, ref UserID);
            if (isfound)
            {
                clspeoplebusiness person = clspeoplebusiness.Find(PersonID);
                if (person != null)
                {
                    return new clsstudentbusiness(StudentID, PersonID, EnrollmentDate, GradeLevelID, EmergencyContactPhone, UserID, person.FirstName, person.LastName,
                                    person.BirthDate, person.Phone, person.Email, person.Address, person.Gender);
                }
                return null;
            }
            return null;
        }
        public static clsstudentbusiness FindBy<t>(t value, enfindby way)
        {
            switch (way)
            {
                case enfindby.studentid:
                    {
                        return FindStudentbyStudentID(Convert.ToInt16(value));

                    }
                case enfindby.personid:
                    {
                        return FindStudentbyPersonID(Convert.ToInt16(value));
                    }
                default:
                    return null;
            }
        }
        public bool _addstudent()
        {
            StudentID = clsstudentdata.AddStudent(PersonID, EnrollmentDate, GradeLevelID, EmergencyContactPhone, UserID);
            return StudentID.HasValue;
        }
        public bool _updatestudent() => clsstudentdata.UpdateStudent(StudentID, PersonID, EnrollmentDate, GradeLevelID, EmergencyContactPhone, UserID);
        public bool SaveStudent()
        {
            switch (_Mode)
            {
                case enMode.add:
                    {
                        if (_addstudent())
                        {
                            _Mode = enMode.update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.update:
                    {
                        return _updatestudent();
                    }
            }
            return false;
        }
        public static bool IsStudentExistByStudentID(int? StudentID) => clsstudentdata.IsStudentExistByStudentID(StudentID);
        public static bool IsStudentExistByPersonID(int? PersonID) => clsstudentdata.IsStudentExistByPersonID(PersonID);
        public static DataTable ListByPages(short pageNumber, int pageSize) => clsstudentdata.ListByPage(pageNumber, pageSize);
        public static int StudentCount() => clsstudentdata.CountStudents();
        public static bool DeleteStudent(int? studentID) => clsstudentdata.DeleteStudent(studentID);

    }
}
