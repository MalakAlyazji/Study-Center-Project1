using System;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class frmAddNewMeeting : Form
    {
        int _MeetingID;
        clsMeetingBusiness _Meeting;
        enum enMoode { Add, update }
        enMoode _Mode = enMoode.Add;
        public Action<int?> MeetngIDBack;
        public frmAddNewMeeting()
        {
            InitializeComponent();
            _Mode = enMoode.Add;
        }
        public frmAddNewMeeting(int MeetingID)
        {
            _MeetingID = MeetingID;
            InitializeComponent();
            _Mode = enMoode.update;
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _ResetTitles()
        {
            if (_Mode == enMoode.Add)
            {
                lbltitle.Text = "Add New Meeting";
                ctrlAddMeeting1.cbMeetingDays.SelectedText = "Daily";
                _Meeting = new clsMeetingBusiness();
                ctrlAddMeeting1.Reset();
            }
            else
            {
                lbltitle.Text = "Update Meeting";
            }
            Text = lbltitle.Text;
        }
        clsMeetingBusiness.enDays StringToEnDays(string str)
        {
            switch (str)
            {
                case "Daily":
                    return clsMeetingBusiness.enDays.Daily;
                case "STT":
                    return clsMeetingBusiness.enDays.STT;
                case "MW":
                    return clsMeetingBusiness.enDays.MW;
                default: return clsMeetingBusiness.enDays.Daily;
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }
            if ((bool)clsMeetingBusiness.IsMeetingExistByDayAndDate(ctrlAddMeeting1.tpStartTime.Value.TimeOfDay, StringToEnDays(ctrlAddMeeting1.cbMeetingDays.SelectedText)))
            {
                MessageBox.Show("A meeting is already scheduled at this time. Please choose a different start time.",
                "Meeting Time Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SaveMeeting();
        }
        void _FillToSave()
        {
            _Meeting.StartTime = clsFormat.ConvertDateToTimeSpan(ctrlAddMeeting1.tpStartTime.Value);
            _Meeting.MeetingDays = clsFormat.StringToenDays(ctrlAddMeeting1.cbMeetingDays.SelectedItem.ToString());
        }
        void _SaveMeeting()
        {
            _FillToSave();
            if ((bool)_Meeting.SaveMeeting())
            {
                _Mode = enMoode.update;
                ctrlAddMeeting1.lblMeetingID.Text = _Meeting.MeetingID.ToString();
                Text = "Update Meeting";
                lbltitle.Text = "Update Meeting";
                MeetngIDBack?.Invoke(_Meeting.MeetingID);
                clsShowMessage.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        void _FillToUpdate()
        {
            ctrlAddMeeting1.LoadMeetingInfo(_MeetingID);
        }
        void _LoadMeetingInfo()
        {
            _Meeting = clsMeetingBusiness.FindMeeting(_MeetingID);
            if (_Meeting == null)
            {
                clsShowMessage.IdNotFound("GradeLevel", _MeetingID);
                Close();
                return;
            }
            _FillToUpdate();
        }
        private void frmAddNewMeeting_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMoode.update)
            {
                _LoadMeetingInfo();
            }
        }
    }
}
