using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCenterbusiness;
using System.Configuration;
using static StudyCenterbusiness.clsMeetingBusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlAddMeeting : UserControl
    {
        public int? MeetingID=> _MeetingID;
        int? _MeetingID;
        clsMeetingBusiness _Meeting;
        public clsMeetingBusiness Meeting => _Meeting;
        public ctrlAddMeeting()
        {
            InitializeComponent();
        }
        public void _FillMeetingDays()
        {
            cbMeetingDays.Items.Clear();
            foreach(var item in Enum.GetValues(typeof(clsMeetingBusiness.enDays)))
            {
                cbMeetingDays.Items.Add(item);
            }
        }
        public  DateTime StringToDate(string stringDate)
        {
            return DateTime.ParseExact(stringDate, "hh:mm tt", null);
        }
        public void Reset()
        {
            _FillMeetingDays();
            lblMeetingID.Text = "[????]";
            cbMeetingDays.SelectedIndex = 0;
            tpStartTime.MinDate=StringToDate(ConfigurationManager.AppSettings["OpeningTime"]);
            DateTime ClosingTime = StringToDate(ConfigurationManager.AppSettings["CloseTime"]);
            tpStartTime.MaxDate = ClosingTime.AddHours(-Math.Ceiling(_GetLectureDuration("MW")));
        }
        private float _GetLectureDuration(string lectureType)
        {
            if (float.TryParse(ConfigurationManager.AppSettings[lectureType], out float lectureDuration))
            {
                return lectureDuration;
            }

            return 0;
        }
        void _FillMeetingInfoToUpdate()
        {
            lblMeetingID.Text =_Meeting.MeetingID.ToString();
            cbMeetingDays.SelectedItem = _Meeting.MeetingDays;
            tpStartTime.Value = DateTime.MinValue.Add(_Meeting.StartTime.Value);//convert timespan to datetime
            lblEndTime.Text=_Meeting.EndTime.ToString();    
        }
        public void LoadMeetingInfo(int? MeetingID)
        {
            _MeetingID = _MeetingID;
            if (_MeetingID == null)
            {
                clsShowMessage.IdNotFound("Meeting", MeetingID);
                Reset();
                return;
            }
            _Meeting = clsMeetingBusiness.FindMeeting(MeetingID);
            if (_Meeting == null)
            {
                clsShowMessage.IdNotFound("Meeting", _MeetingID);
                Reset();
                return;
            }
            _FillMeetingInfoToUpdate();
        }
        void _UpdateEndTime(DateTime StartTime)
        {
            float duration = _GetLectureDuration(cbMeetingDays.SelectedItem.ToString());
            DateTime EndTime = StartTime.AddHours(duration);
            lblEndTime.Text = EndTime.ToString(@"hh\:mm");
       } 
        void _RoundedDateTimePicker()
        {
            DateTime selectedTime = tpStartTime.Value;
            int minutes = selectedTime.Minute;
            int roundedMinutes;
            int roundedHour = selectedTime.Hour;

            if (minutes < 15)
            {
                roundedMinutes = 0; // Round down to 00
            }
            else if (minutes < 45)
            {
                roundedMinutes = 30; // Round to 30
            }
            else
            {
                roundedMinutes = 0; // Round up to 00
                roundedHour = (roundedHour + 1) % 24; // Increment hour and wrap around if needed
            }

            // Create the new rounded time
            DateTime roundedTime = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day,
                                                 roundedHour, roundedMinutes, 0);

            // Update the DateTimePicker value if it has changed
            if (tpStartTime.Value != roundedTime)
            {
                tpStartTime.Value = roundedTime; // Update to rounded time
            }
        }
        private void tpStartTime_ValueChanged(object sender, EventArgs e)
        {
            _RoundedDateTimePicker();
            _UpdateEndTime(tpStartTime.Value);
        }

        private void cbMeetingDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateEndTime(tpStartTime.Value);
        }
    }
}
