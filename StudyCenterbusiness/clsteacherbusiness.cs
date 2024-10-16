using System;
using System.Collections.Generic;
using System.Text;
using StudyCenterBuisness;
using StudyCenterBusinesss;
using StudyCenterData;
using System.Data;
using StudyCenterData.GlobalClasses;
namespace StudyCenterBusinesss
{
    public class clsteacherbusiness:clspeoplebusiness
    {
        private enum enMode { add,update}
        enMode _mode;
        public int? TeacherID { get; set; }
        public int? PersonID { get; set; }
        public DateTime? HireDate { get; set; }
        public string Qualification { get; set; }
        public decimal? Salary { get; set; }
        public int?  UserID { get; set; }
        public string GetUserName { get;private set; }
        public enum enFindBy {personid,teacherid };
        public clsteacherbusiness()
        {
            _mode = enMode.add;
            this.TeacherID=null;
            this.PersonID =null;
            this.HireDate = null;
            this.Qualification = null;
            this.Salary = null;
            this.UserID = null;
        }
        public clsteacherbusiness(int? TeacherID, int? PersonID, DateTime? DateTime, string Qualification, decimal? Salary, int? UserID, string firstName, string lastName, EnGender gender,
                          DateTime? dateOfBirth, string phoneNumber, string email, string address) :base(PersonID, firstName, lastName, gender, dateOfBirth, address, phoneNumber, email)
        {
            _mode = enMode.update;
            this.TeacherID= TeacherID;
            this.PersonID= PersonID;
            this.HireDate= DateTime;
            this.Qualification =  Qualification;
            this.Salary = Salary;
            this.UserID = UserID;
            this.FirstName = firstName;
            this.BirthDate = dateOfBirth;
            this.LastName = lastName;
            this.Gender = gender;       
            this.Email = email;
            this.Address = address;
            this.Phone= phoneNumber;
            GetUserName = clsuserbusiness.FindUserBy(UserID, clsuserbusiness.EnFindUserBy.UserID).UserName;
        }
        private static clsteacherbusiness _findbyteacherid(int? TeacherID)
        {
            int? PersonID=null;
            DateTime? DateTime = null;
            string Qualification=null;
            decimal? Salary = null;
            int? UserID = null;
            bool isfound = false;
           isfound = clsteacherdata.findteacherbyTEACHERID( TeacherID, ref  PersonID, ref  DateTime, ref Qualification, ref Salary, ref UserID);
            if (isfound)
            {
                clspeoplebusiness p = clspeoplebusiness.Find(PersonID);
                if (p != null)
                {
                    return new clsteacherbusiness(TeacherID,  PersonID,  DateTime,  Qualification,  Salary,  UserID,
                        p.FirstName,p.LastName,p.Gender,p.BirthDate,p.Phone,p.Email,p.Address);
                }return null;
            }return null;
        }
        private static clsteacherbusiness _findbypersonid( int? PersonID)
        {
            int? TeacherID = null;
            DateTime? hire = null;
            string Qualification = null;
            decimal? Salary = null;
            int? UserID = null;
            bool isfound = false;
            isfound = clsteacherdata.FindTeacherByPersonID(ref TeacherID, PersonID, ref hire, ref Qualification, ref Salary, ref UserID);
            if (isfound)
            {
                clspeoplebusiness p = clspeoplebusiness.Find(PersonID);
                if (p != null)
                {
                    return new clsteacherbusiness(TeacherID, PersonID, hire, Qualification, Salary, UserID,
                        p.FirstName, p.LastName, p.Gender, p.BirthDate, p.Phone, p.Email, p.Address);
                }
                return null;
            }
            return null;
        }
        public static clsteacherbusiness FindBy<T>(T SelectedID,enFindBy way)
        {
            switch (way)
            {
                case enFindBy.personid:
                    {
                        return _findbypersonid(Convert.ToInt16( SelectedID));
                    }
                case enFindBy.teacherid:
                    {
                        return _findbyteacherid(Convert.ToInt16( SelectedID));
                    }
                    default: return null;   
            }
        }
        private bool _addteacher()
        {
            this.TeacherID = clsteacherdata.AddTeacher(PersonID.Value,HireDate,Qualification,Salary,UserID.Value);
            return this.TeacherID.HasValue;
        }
        private bool _update() => clsteacherdata.updateteacher(this.TeacherID,this.PersonID,this.HireDate,this.Qualification,this.Salary,this.UserID);
        public bool saveteacher()
        {
            switch (_mode)
            {
                case enMode.add:
                    {
                        if (_addteacher())
                        {
                            _mode = enMode.update;
                            return true;
                        }
                        return false;
                    }
                case enMode.update:
                    {
                        return _update();
                    }
            }return false;
        }
        public  bool IsTeacherExistByPersonID() => clsteacherdata.IsTeacherExistByPersonID(this.PersonID);
        public static DataTable listbypage(short rowsperpage, int numberofpages) => clsteacherdata.listbypage(rowsperpage, numberofpages);
        public static int CountTeachers() => clsteacherdata.count();
        public static bool DeleteTeacher(int? TeacherID) => clsteacherdata.Deleteteacher(TeacherID);
        public static bool IsTeacherExistByPersonID(int? PersonID)=>clsteacherdata.IsTeacherExistByPersonID(PersonID);
    }
}
