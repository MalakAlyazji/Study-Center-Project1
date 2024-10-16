using System.Data;
using StudyCenterData;
namespace StudyCenterbusiness
{
    public class clsGradeLevelBusiness
    {
        public int? GradeLevelID { get; set; }
        public string GradeLevelName { get; set; }
        enum enMode { add, update }
        enMode _mode;
        public clsGradeLevelBusiness()
        {
            GradeLevelID = null;
            GradeLevelName = null;
            _mode = enMode.add;
        }
        public clsGradeLevelBusiness(int? GradeLevelID, string GradeLevelName)
        {
            this.GradeLevelID = GradeLevelID;
            this.GradeLevelName = GradeLevelName;
            _mode = enMode.update;
        }
        bool addlevel()
        {
            GradeLevelID = clsGradeLevelData.addlevel(GradeLevelName);
            return GradeLevelID != null;
        }
        bool updatelevel() => clsGradeLevelData.update(GradeLevelID, GradeLevelName);
        public bool SaveGradeLevel()
        {
            switch (_mode)
            {
                case enMode.add:
                    {
                        if (addlevel())
                        {
                            _mode = enMode.update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.update:
                    {
                        return updatelevel();
                    }
            }
            return false;
        }
        public static clsGradeLevelBusiness findlevel(int? GradeLevelID)
        {
            string GradeLevelName = string.Empty;
            bool isFound = clsGradeLevelData.findlevel(GradeLevelID, ref GradeLevelName);
            return isFound ? new clsGradeLevelBusiness(GradeLevelID, GradeLevelName) : null;
        }
        public static int? GetGradeLevelIDbyName(string gradeName)
                    => clsGradeLevelData.GetGradeIDByName(gradeName);
        public static DataTable GetLevelsName() => clsGradeLevelData.GetLevelsName();
        public static int? CountGradeLevels() => clsGradeLevelData.CountGradeLevels();
    }
}
