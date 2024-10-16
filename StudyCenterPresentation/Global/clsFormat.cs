using System;
using StudyCenterbusiness;
using static StudyCenterbusiness.clsMeetingBusiness;

namespace StudyCenterPresentation
{
    public class clsFormat
    {
        public static string DateToString(DateTime? dt)
        {
            return dt?.ToString("dd/mm/yyyy");
        }


        public static clsMeetingBusiness.enDays StringToenDays(string dayString)
        {
            if (Enum.TryParse(dayString, out enDays meetingDay))
            {
                return meetingDay;
            }
            else
            {
                return enDays.MW;
            }
        }
        public static string FormatTime(TimeSpan? startTime, TimeSpan? endTime)
        {
            if (startTime == null || endTime == null)
            {
                throw new ArgumentNullException("Start time and end time must not be null.");
            }

            // Convert TimeSpan to DateTime for comparison
            DateTime startDateTime = new DateTime(1, 1, 1, startTime.Value.Hours, startTime.Value.Minutes, 0);
            DateTime endDateTime = new DateTime(1, 1, 1, endTime.Value.Hours, endTime.Value.Minutes, 0);

            // Handle the case where end time is in the next hour
            if (endDateTime < startDateTime)
            {
                endDateTime = endDateTime.AddDays(1); // Adjust end time to the next day
            }

            if (endDateTime < startDateTime)
            {
                throw new ArgumentException("End time must be greater than or equal to start time");
            }

            // Format the times to "HH:mm" (24-hour format)
            string formattedStartTime = startTime.Value.ToString(@"hh\:mm");
            string formattedEndTime = endTime.Value.ToString(@"hh\:mm");

            return $"{formattedStartTime} - {formattedEndTime}";
        }
        public static TimeSpan ConvertDateToTimeSpan(DateTime date)
        {
            // Use the hour and minute from DateTime, which are in 24-hour format
            int hour = date.Hour;
            int minute = date.Minute;
            return new TimeSpan(hour, minute, 0);
        }

    }
}
