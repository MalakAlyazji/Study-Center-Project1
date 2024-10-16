using System;
using System.Collections.Generic;
using System.Data;
using StudyCenterData;
namespace StudyCenterBuisness
{
    public class clsuserbusiness : clspeoplebusiness
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public enum EnFindUserBy { PersonID = 0, UserID = 1, UserNameAndPassword = 2 }
        public enum enPermissions { All = -1, AddUser = 1, UpdateUser = 2, ListUsers = 4 }
        public int? UserID { get; set; }
        public int? PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int? Permissions { get; set; }
        public clspeoplebusiness PersonInfo { get; private set; }
        public clsuserbusiness()
        {
            UserID = null;
            PersonID = null;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            Permissions = null;
            Mode = enMode.AddNew;
        }
        private clsuserbusiness(int? userID, int? personID, string userName, string password, bool isActive, int? permissions, string firstName, string lastName, EnGender gender,
                          DateTime? dateOfBirth, string phoneNumber, string email, string address)
            :
            base(personID, firstName, lastName, gender, dateOfBirth, address, phoneNumber, email)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Permissions = permissions;
            Mode = enMode.Update;
            PersonInfo = clspeoplebusiness.Find(personID);
        }
        private bool _Add()
        {
            UserID = clsuserdata.AddUser(PersonID.Value, UserName, Password, IsActive, Permissions);
            return UserID.HasValue;
        }
        private bool _Update() => clsuserdata.UpdateUser(UserID.Value, PersonID, UserName, Password, IsActive, Permissions);
        public bool UpdatePassword(string Password) => clsuserdata.UpdatePassword(UserID, Password);
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }
        private static clsuserbusiness _FindUserByUserid(int? UserID)
        {
            int? personid = null;
            string pass = string.Empty;
            string username = string.Empty;
            bool isactive = false;
            int? Permissions = null;
            bool isfound = clsuserdata.FindUserByUserID(UserID, ref personid, ref username, ref pass, ref isactive, ref Permissions);
            if (isfound)
            {
                clspeoplebusiness person = clspeoplebusiness.Find(personid);
                if (person == null)
                {
                    return null;
                }
                return new clsuserbusiness(UserID, personid, username, pass, isactive, Permissions, person.FirstName, person.LastName, person.Gender, person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }
        private static clsuserbusiness _FindUserByPersonid(int? PersonID)
        {
            int? userid = null;
            string pass = string.Empty;
            string username = string.Empty;
            bool isactive = false;
            int? Permissions = null;
            bool isfound = clsuserdata.FindUserByPersonID(ref userid, PersonID, ref username, ref pass, ref isactive, ref Permissions);
            if (isfound)
            {
                clspeoplebusiness person = clspeoplebusiness.Find(PersonID);
                if (person != null)
                {
                    return new clsuserbusiness(userid, PersonID, username, pass, isactive, Permissions, person.FirstName,
                        person.LastName, person.Gender, person.BirthDate, person.Phone, person.Email, person.Address);
                }
                return null;
            }
            return null;
        }
        private static clsuserbusiness _FindByUserNameAndPassword(string userName, string password)
        {
            int? personID = null;
            int? userID = null;
            bool isActive = false;
            int? Permissions = null;
            bool isFound = clsuserdata.FindLog(ref userID, ref personID, userName, password, ref isActive, ref Permissions);
            if (isFound)
            {
                clspeoplebusiness person = clspeoplebusiness.Find(personID);

                if (person == null)
                    return null;

                return new clsuserbusiness(userID, personID, userName, password, isActive, Permissions, person.FirstName, person.LastName, person.Gender,
                                    person.BirthDate, person.Phone, person.Email, person.Address);
            }
            return null;
        }
        public static clsuserbusiness FindUserBy<T>(T searchValue, clsuserbusiness.EnFindUserBy findUserBy, T SecoundsearchValue = default(T))
        {
            switch (findUserBy)
            {
                case EnFindUserBy.PersonID:
                    return _FindUserByPersonid(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserID:
                    return _FindUserByUserid(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserNameAndPassword:
                    return _FindByUserNameAndPassword(Convert.ToString(searchValue), Convert.ToString(SecoundsearchValue));
                default:
                    return null;
            }
        }
        public static bool Delete(int? userID)
            => clsuserdata.deleteuser(userID.Value);
        public static bool IsUserExistBy(int? Value, clsuserbusiness.EnFindUserBy Way)
        {
            switch (Way)
            {
                case clsuserbusiness.EnFindUserBy.PersonID:
                    return IsUserExistByPersonID(Value);
                case clsuserbusiness.EnFindUserBy.UserID:
                    return IsUserExistByUserID(Value);
                default: return false;
            }
        }
        static bool IsUserExistByPersonID(int? PersonID)
            => clsuserdata.IsUserExistsByPersonID(PersonID.Value);
        static bool IsUserExistByUserID(int? userID)
            => clsuserdata.isuserexistbyuserid(userID.Value);
        public static DataTable ListUsers() => clsuserdata.ListUsers();
        public static int CountUsers() => clsuserdata.Count();
        public List<string> ListUserPermissions()
        {

            if (Permissions.Value == -1)
            {
                return new List<string>();
            }
            List<string> PermissionList = new List<string>() { "Admin" };
            if (((int?)enPermissions.AddUser & Permissions) == (int?)enPermissions.AddUser)
            {
                PermissionList.Add("Add User");
            }
            if (((int?)enPermissions.UpdateUser & Permissions) == (int?)enPermissions.UpdateUser)
            {
                PermissionList.Add("‘Update User");
            }
            if (((int?)enPermissions.ListUsers & Permissions) == (int?)enPermissions.ListUsers)
            {
                PermissionList.Add("List User");
            }
            return PermissionList;
        }
    }
}
