using System.Data;
using StudyCenterBuisness;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsGroupBusiness
    {
        enum enMode { add, Update }
        enMode _Mode = enMode.add;
        public int? GroupID { get; set; }
        public int? TeacherSubjectID { get; set; }
        public int? GradeSubjectID { get; set; }
        public int? StudentCount { get; set; }
        public int? GradeLevelID { get; set; }
        public string GroupName { get; set; }
        public bool? IsActive { get; set; }
        public int? ClassID { get; set; }
        public int? UserID { get; set; }
        public int? MeetingID { get; set; }
        public clsClassBusiness ClassInfo { get; private set; }
        public clsMeetingBusiness MeetingInfo { get; private set; }
        public clsuserbusiness UserInfo { get; private set; }
        public clsTeacherSubjectsBusiness TeacherSubjectsInfo { get; private set; }
        public clsGroupBusiness()
        {
            _Mode = enMode.add;
            GroupID = null;
            TeacherSubjectID = null;
            GradeSubjectID = null;
            StudentCount = null;
            GradeLevelID = null;
            GroupName = null;
            IsActive = null;
            ClassID = null;
            UserID = null;
            MeetingID = null;
        }
        public clsGroupBusiness(int? groupId, int? teacherSubjectID, int? gradeSubjectID, int? StudentCount, int? GradeLevelID
            , string GroupName, bool? IsActive, int? ClassID, int? UserID, int? MeetingID)
        {
            _Mode = enMode.Update;
            GroupID = groupId;
            TeacherSubjectID = teacherSubjectID;
            this.StudentCount = StudentCount;
            this.GradeLevelID = GradeLevelID;
            this.GroupName = GroupName;
            this.IsActive = IsActive;
            this.ClassID = ClassID;
            this.UserID = UserID;
            this.MeetingID = MeetingID;
            GradeSubjectID = gradeSubjectID;
            ClassInfo = clsClassBusiness.FindClassByClassID(ClassID);
            MeetingInfo = clsMeetingBusiness.FindMeeting(MeetingID);
            UserInfo = clsuserbusiness.FindUserBy(UserID, clsuserbusiness.EnFindUserBy.UserID);
            TeacherSubjectsInfo = clsTeacherSubjectsBusiness.FindTeacherSubjectsBy(teacherSubjectID, clsTeacherSubjectsBusiness.enFindBy.TeacherSubjectID);
        }
        public static clsGroupBusiness FindGroup(int? GroupID)
        {
            int? TeacherSubjectID = null;
            int? StudentCount = null;
            int? GradeSubjectID = null;
            int? GradeLevelID = null;
            string GroupName = null;
            bool? IsActive = null;
            int? ClassID = null;
            int? UserID = null;
            int? MeetingID = null;
            bool IsFound = clsGroupData.FindGroupByGroupID(GroupID, ref TeacherSubjectID, ref GradeSubjectID,
                ref StudentCount, ref GradeLevelID, ref GroupName, ref IsActive
                , ref ClassID, ref UserID, ref MeetingID);
            return IsFound ? new clsGroupBusiness(GroupID, TeacherSubjectID, GradeSubjectID, StudentCount, GradeLevelID, GroupName, IsActive
                , ClassID, UserID, MeetingID) : null;
        }
        bool _AddGroup()
        {
            GroupID = clsGroupData.AddGroup(TeacherSubjectID, GradeSubjectID, GradeLevelID, ClassID, UserID, MeetingID);
            return GroupID.HasValue;
        }
        bool _UpdateGroup() => clsGroupData.UpdateGroup(GroupID, TeacherSubjectID, GradeSubjectID, StudentCount, GradeLevelID, GroupName, IsActive, ClassID, UserID, MeetingID);
        public bool SaveGroup()
        {
            switch (_Mode)
            {
                case enMode.add:
                    {
                        if (_AddGroup())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateGroup();
                    }
                default: return false;
            }
        }
        public static DataTable ListGroupsByPages(short PageNumber, int PageSize) => clsGroupData.ListGroupByPages(PageNumber, PageSize);
        public static DataTable ListGroups() => clsGroupData.ListGroup();
        public static DataTable ListGroupsByClassID(int? ClassID) => clsGroupData.ListGroupsByClassID(ClassID);
        public static int? CountGroups() => clsGroupData.CountGroups();
        public static bool DeleteGroup(int GroupID) => clsGroupData.DeleteGroup(GroupID);
        public static DataTable GetGroupsNames() => clsGroupData.GetGroupsNames();
    }
}
