using System;
using System.Data;
using StudyCenterData;

namespace StudyCenterbusiness
{
    public class clsPaymentBusiness
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public enum enPaymentMethod { Cash, Online }
        public int? PaymentID { get; set; }
        public int? StudentGroupID { get; set; }
        public int? GradeSubjectID { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? UserID { get; set; }
        public clsPaymentBusiness.enPaymentMethod? PaymentMethods { get; set; }
        public clsPaymentBusiness()
        {
            PaymentID = null;
            StudentGroupID = null;
            GradeSubjectID = null;
            PaymentAmount = null;
            PaymentDate = null;
            UserID = null;
            PaymentMethods = null;
        }
        public clsPaymentBusiness(int? PaymentID, int? StudentGroupID, int? GradeSubjectID,
            decimal? PaymentAmount, DateTime? PaymentDate, int? UserID, clsPaymentBusiness.enPaymentMethod? PaymentMethods)
        {
            this.PaymentID = PaymentID;
            this.StudentGroupID = StudentGroupID;
            this.GradeSubjectID = GradeSubjectID;
            this.PaymentAmount = PaymentAmount;
            this.PaymentDate = PaymentDate;
            this.UserID = UserID;
            this.PaymentMethods = PaymentMethods;
            _Mode = enMode.Update;
        }
        bool _AddPayment()
        {
            PaymentID = clsPaymentData.AddPayment(StudentGroupID, GradeSubjectID, PaymentAmount,
                PaymentDate, UserID, PaymentMethods.ToString());
            return PaymentID != null;
        }
        bool _UpdatePayment() => clsPaymentData.UpdatePayment(PaymentID, StudentGroupID, GradeSubjectID, PaymentAmount,
                PaymentDate, UserID, PaymentMethods.ToString());
        public bool SavePayment()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddPayment())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdatePayment();
                    }
            }
            return false;
        }
        public static clsPaymentBusiness FindPayment(int? PaymentID)
        {
            int? StudentGroupID = null;
            int? GradeSubjectID = null;
            decimal? PaymentAmount = null;
            DateTime? PaymentDate = null;
            int? UserID = null;
            string PaymentMethodsAsString = null;
            bool IsFound = clsPaymentData.FindPaymentByPaymentID(PaymentID, ref StudentGroupID, ref GradeSubjectID, ref PaymentAmount,
               ref PaymentDate, ref UserID, ref PaymentMethodsAsString);
            clsPaymentBusiness.enPaymentMethod? PaymentMethods = null;
            if (!string.IsNullOrEmpty(PaymentMethodsAsString))
            {
                if (Enum.TryParse<clsPaymentBusiness.enPaymentMethod>(PaymentMethodsAsString, out var parsedMeetingDays))
                {
                    PaymentMethods = parsedMeetingDays;
                }
            }
            return IsFound ? new clsPaymentBusiness(PaymentID, StudentGroupID, GradeSubjectID, PaymentAmount,
                PaymentDate, UserID, PaymentMethods) : null;
        }
        public static DataTable ListPayment() => clsPaymentData.ListPayment();
        public static DataTable ListPaymentByPages(short PageNumber, int PageSize) => clsPaymentData.ListPaymentByPages(PageNumber, PageSize);
        public static bool DeletePayment(int? PaymentID) => clsPaymentData.DeletePayment(PaymentID);
        public static int CountPayments() => clsPaymentData.CountPayments();
    }
}
