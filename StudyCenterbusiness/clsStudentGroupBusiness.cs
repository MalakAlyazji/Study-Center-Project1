using System;
using System.Data;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsStudentGroupBusiness
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public enum enFindBy { StudentGroupID, StudentID, GroupID, Both }
        public int? StudentGroupID { get; set; }
        public int? StudentID { get; set; }
        public int? GroupID { get; set; }
        public int? UserID { get; set; }
        public TimeSpan? StartDate { get; set; }
        public TimeSpan? EndDate { get; set; }
        public int? PaymentID { get; set; }
        clsPaymentBusiness.enPaymentMethod paymentMethod { get; set; }
        public clsPaymentBusiness PaymentsInfo { get; private set; }
        public clsStudentGroupBusiness()
        {
            _Mode = enMode.Add;
            StudentGroupID = null;
            StudentID = null;
            GroupID = null;
            UserID = null;
            StartDate = null;
            EndDate = null;
        }
        public clsStudentGroupBusiness(int? StudentGroupID, int? StudentID, int? GroupID, int? UserID, TimeSpan? StartDate, TimeSpan? EndDate)
        {
            _Mode = enMode.Update;
            this.StudentGroupID = StudentGroupID;
            this.StudentID = StudentID;
            this.GroupID = GroupID;
            this.UserID = UserID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            PaymentsInfo = clsPaymentBusiness.FindPayment(PaymentID);
        }
        static clsStudentGroupBusiness _FindStudentGroupByStudentGroupID(int? StudentGroupID)
        {
            int? StudentID = null;
            int? GroupID = null;
            int? UserID = null;
            TimeSpan? StartDate = null;
            TimeSpan? EndDate = null;
            bool IsFound = clsStudentGroupData.FindStudentGroupByStudentGroupID(StudentGroupID, ref StudentID, ref GroupID, ref UserID, ref StartDate, ref EndDate);
            return IsFound ? new clsStudentGroupBusiness(StudentGroupID, StudentID, GroupID, UserID, StartDate, EndDate) : null;
        }
        static clsStudentGroupBusiness _FindStudentGroupByStudentID(int? StudentID)
        {
            int? StudentGroupID = null;
            int? GroupID = null;
            int? UserID = null;
            TimeSpan? StartDate = null;
            TimeSpan? EndDate = null;
            bool IsFound = clsStudentGroupData.FindTeacherSubjectsByStudentID(ref StudentGroupID, StudentID, ref GroupID, ref UserID, ref StartDate, ref EndDate);
            return IsFound ? new clsStudentGroupBusiness(StudentGroupID, StudentID, GroupID, UserID, StartDate, EndDate) : null;
        }
        static clsStudentGroupBusiness _FindStudentGroupByGroupID(int? GroupID)
        {
            int? StudentID = null;
            int? StudentGroupID = null;
            int? UserID = null;
            TimeSpan? StartDate = null;
            TimeSpan? EndDate = null;
            bool IsFound = clsStudentGroupData.FindStudentGroupByGroupID(ref StudentGroupID, ref StudentID, GroupID, ref UserID, ref StartDate, ref EndDate);
            return IsFound ? new clsStudentGroupBusiness(StudentGroupID, StudentID, GroupID, UserID, StartDate, EndDate) : null;
        }
        public static clsStudentGroupBusiness FindStudentGroupBy(int? value, clsStudentGroupBusiness.enFindBy Way)
        {
            switch (Way)
            {
                case enFindBy.StudentGroupID: return _FindStudentGroupByStudentGroupID(value);
                case enFindBy.StudentID: return _FindStudentGroupByStudentID(value);
                case enFindBy.GroupID: return _FindStudentGroupByGroupID(value);
                default: return null;
            }
        }
        bool _AddStudentGroup(string paymentMethod)
        {
            StudentGroupID = clsStudentGroupData.AddStudentGroup(StudentID, GroupID, UserID);
            return StudentGroupID.HasValue;
        }
        bool _UpdateStudentGroup() => clsStudentGroupData.UpdateStudentGroup(StudentGroupID, StudentID, GroupID, UserID);
        public bool SaveStudentGroup(string paymentMethod = null)
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        var (success, studentGroupID, paymentID) = _AddStudentGroup2(paymentMethod);
                        if (success)
                        {
                            StudentGroupID = studentGroupID; // Capture the student group ID
                            PaymentID = paymentID;                       // You can also handle the payment ID if needed
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    return _UpdateStudentGroup();
                default:
                    return false;
            }
        }
        (bool success, int? studentGroupID, int? paymentID) _AddStudentGroup2(string paymentMethod)
        {
            var result = clsStudentGroupData.AddStudentGroupWithPayment(StudentID, GroupID, UserID, paymentMethod);

            StudentGroupID = result.StudentGroupID; // Capture StudentGroupID
                                                    // Optionally, you can capture PaymentID if needed
            int? paymentID = result.PaymentID; // Capture PaymentID

            return (StudentGroupID.HasValue, StudentGroupID, paymentID); // Return success status, StudentGroupID, and PaymentID
        }
        public static DataTable ListStudentGroup() => clsStudentGroupData.ListStudentGroups();
        public static DataTable ListStudentGroupByPages(short PageNumbers, int PageSize) => clsStudentGroupData.ListStudentGroupByPages(PageNumbers, PageSize);
        static bool IsStudentGroupExistByStudentGroupID(int? StudentGroup) => clsStudentGroupData.IsStudentGroupExistByStudentGroupID(StudentGroup);
        static bool IsStudentGroupExistByStudentID(int? StudentID) => clsStudentGroupData.IsStudentGroupExistByStudentID(StudentID);
        static bool IsStudentGroupExistByGroupID(int? GroupID) => clsStudentGroupData.IsStudentGroupExistByGroupID((int)GroupID);
        static bool IsStudentAssignedToGroup(int? StudentID, int? GroupID) => clsStudentGroupData.IsStudentAssignedToGroup(StudentID, GroupID);
        public static bool IsStudentGroupExistBy(int? value, clsStudentGroupBusiness.enFindBy Way, int? value2 = null)
        {
            switch (Way)
            {
                case enFindBy.StudentGroupID: return IsStudentGroupExistByStudentGroupID(value);
                case enFindBy.StudentID: return IsStudentGroupExistByStudentID(value);
                case enFindBy.GroupID: return IsStudentGroupExistByGroupID(value);
                case enFindBy.Both: return IsStudentAssignedToGroup(value, value2);
                default: return false;
            }
        }
        public static DataTable ListGroupStudentNotAssignedIn(int? TeacherID) => clsStudentGroupData.ListGroupStudentNotAssignedIn(TeacherID);
        public static decimal GetGradeSubjectFeesByGroupID(int? GroupID) => clsStudentGroupData.GetGradeSubjectFeesByGroupID(GroupID);
        public static int? GetGradeLevelIDByStudentID(int? StudentID) => clsStudentGroupData.GetGradeLevelIDByStudentID(StudentID);
        public static DataTable ListStudentGroupByGroupID(int? GroupID) => clsStudentGroupData.ListStudentGroupByGroupID(GroupID);
    }
}
