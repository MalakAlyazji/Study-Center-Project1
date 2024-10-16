using System;
using StudyCenterData;
namespace StudyCenterBuisness
{
    public class clspeoplebusiness
    {
        public enum EnMode : byte { AddNew = 0, Update = 1 };
        public EnMode Mode;
        public enum EnGender : byte { Male = 0, Female = 1 };
        public enum EnType : byte { student = 0, Teacher = 1, User = 2 };
        public int? PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);
        public DateTime? BirthDate { get; set; }
        public EnGender Gender { get; set; }
        public string GenderText => Gender.ToString();
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public clspeoplebusiness()
        {
            Mode = EnMode.AddNew;

            PersonID = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.Now;
            Gender = EnGender.Male;
            Address = null;
            Phone = string.Empty;
            Email = null;
        }
        public clspeoplebusiness(int? personID, string firstName, string lastName, EnGender gender,
            DateTime? dateOfBirth, string phoneNumber, string email, string address)
        {
            Mode = EnMode.Update;

            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phoneNumber;
            Email = email;
        }

        public static clspeoplebusiness Find(int? personID)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            bool? gender = null;
            DateTime? dateOfBirth = null;
            string phoneNumber = string.Empty;
            string email = null;
            string address = null;

            bool isFound = clspeopledata.findperson(personID, ref firstName, ref lastName,
            ref dateOfBirth, ref phoneNumber, ref email, ref address, ref gender);

            if (!isFound) return null;

            // Convert bool to EnGender
            EnGender genderValue = gender.HasValue ? (gender.Value ? EnGender.Female : EnGender.Male) : EnGender.Male;

            return new clspeoplebusiness(
                personID,
                firstName,
                lastName,
                genderValue,
                dateOfBirth,
                phoneNumber,
                email,
                address
            );

        }
        public static bool DoesPersonExist(int? personID) => clspeopledata.Exists(personID);
        private bool AddNewPerson()
        {
            PersonID = clspeopledata.addperson(FirstName,
                LastName, (byte)Gender, BirthDate, Phone, Email, Address);
            return PersonID.HasValue;
        }
        private bool UpdatePerson() =>
             clspeopledata.udateperson(PersonID, FirstName, LastName, (byte)Gender, BirthDate, Phone, Email, Address);
        public bool SavePerson()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (AddNewPerson())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdatePerson();

            }
            return false;
        }
        public static bool DeletePerson(int? personID) => clspeopledata.deleteperson(personID);
    }
}

