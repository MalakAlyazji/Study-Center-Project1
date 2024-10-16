using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace StudyCenterPresentation
{
    public class clshelper
    {
        public static void FillComboBox(Guna2ComboBox comboBox, DataTable dataTable, string displayMember)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
        }
    }
}
