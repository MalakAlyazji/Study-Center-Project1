using System;
using System.Data;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsMeetingBusiness
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public int? MeetingID { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public clsMeetingBusiness.enDays? MeetingDays { get; set; }
        public enum enDays { Daily, STT, MW }
        public clsMeetingBusiness()
        {
            MeetingID = null;
            StartTime = null;
            EndTime = null;
            MeetingDays = null;
        }
        public clsMeetingBusiness(int? MeetingID, TimeSpan? StartTime, TimeSpan? EndTime, clsMeetingBusiness.enDays? MeetingDays)
        {
            this.MeetingID = MeetingID;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.MeetingDays = MeetingDays;
            _Mode = enMode.Update;
        }
        bool? _AddMeeting()
        {
            MeetingID = clsMeetingData.AddMeeting(StartTime, MeetingDays.ToString());
            return MeetingID != null;
        }
        bool? _UpdateMeeting() => clsMeetingData.UpdateMeeting(MeetingID, StartTime, MeetingDays.ToString());
        public bool? SaveMeeting()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if ((bool)_AddMeeting())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateMeeting();
                    }
            }
            return false;
        }
        public static clsMeetingBusiness FindMeeting(int? MeetingID)
        {
            TimeSpan? StartTime = null;
            TimeSpan? EndTime = null;
            string MeetingDaysString = null;
            bool IsFound = clsMeetingData.FindMeetingByMeetingID(MeetingID, ref StartTime, ref EndTime, ref MeetingDaysString);
            clsMeetingBusiness.enDays? MeetingDays = null;
            if (!string.IsNullOrEmpty(MeetingDaysString))
            {
                if (Enum.TryParse<clsMeetingBusiness.enDays>(MeetingDaysString, out var parsedMeetingDays))
                {
                    MeetingDays = parsedMeetingDays;
                }
            }
            return IsFound ? new clsMeetingBusiness(MeetingID, StartTime, EndTime, MeetingDays) : null;
        }
        public static DataTable ListMeetings() => clsMeetingData.ListMeetings();
        public static bool? DeleteMeeting(int? MeetingID) => clsMeetingData.DeleteMeeting(MeetingID);
        public static DataTable ListMeetingByPages(short PageNumber, int PageSize) => clsMeetingData.ListMeetingsByPages(PageNumber, PageSize);
        public static DataTable ListMeetingsByCLassAndTeacher(int? ClassID, int? TeacherID) => clsMeetingData.ListMeetingsByCLassAndTeacher(ClassID, TeacherID);
        public static DataTable ListMeetingBySeletedMeetingID(int? SeletedMeetingID) => clsMeetingData.ListMeetingBySeletedMeetingID(SeletedMeetingID);
        public static bool? IsMeetingExistByDayAndDate(TimeSpan? StartTime, clsMeetingBusiness.enDays? MeetingDays) => clsMeetingData.IsMeetingExistByDayAndDate(StartTime, MeetingDays.ToString());
        public static int? CountMeetings() => clsMeetingData.CountMeetings();
    }
}
