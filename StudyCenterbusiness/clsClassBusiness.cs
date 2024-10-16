using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using StudyCenterData;
namespace StudyCenterbusiness
{
    public class clsClassBusiness
    {
        enum enmode { Add, Update }
        enmode _mode = enmode.Add;
        public int? ClassID { get; set; }
        public string ClassName { get; set; }
        public int? Capacity { get; set; }
        public clsClassBusiness()
        {
            _mode = enmode.Add;
            ClassID = null;
            ClassName = string.Empty;
            Capacity = null;
        }
        public clsClassBusiness(int? ClassID, string ClassName, int? Capacity)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            this.Capacity = Capacity;
            _mode = enmode.Update;
        }
        public static clsClassBusiness FindClassByClassID(int? ClassID)
        {
            string ClassName = string.Empty;
            int? Capacity = null;
            bool isfound = clsClassData.FindClass(ClassID, ref ClassName, ref Capacity);
            if (isfound)
            {
                return new clsClassBusiness(ClassID, ClassName, Capacity);
            } return null;
        }
        public bool _AddClass()
        {
            this.ClassID = clsClassData.AddClass(ClassName, Capacity);
            return this.ClassID.HasValue;
        }
        public bool _UpdateClass() => clsClassData.UpdateClass(ClassID, ClassName, Capacity);
        public bool SaveClass()
        {
            switch (_mode)
            {
                case enmode.Add:
                    {
                        if (_AddClass())
                        {
                            _mode = enmode.Update;
                            return true;
                        }
                        else return false;
                    }
                    case enmode.Update:
                    {
                        return _UpdateClass();
                    }
            }return false;
        }
        public static bool DeleteClass(int ? ClassID)=>clsClassData.DeleteClass(ClassID);
        public static bool IsClassExistByClassID(int? ClassID) => clsClassData.IsClassExistByClassID(ClassID);
        public static DataTable ListClass()=>clsClassData.ListClasses();
        public static DataTable ListClassByPages(short PageNumber, int PageSize) => clsClassData.ListClassesByPages(PageNumber, PageSize);
        public static int? CountClasses()=>clsClassData.CountClasses();
    }
}
