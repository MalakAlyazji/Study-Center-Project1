using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public partial class frmshowGroupInfo : Form
    {
        int? _GroupID;
        public frmshowGroupInfo(int? GroupID)
        {
            _GroupID=GroupID;
            InitializeComponent();
        }
        private void frmshowGroupInfo_Load(object sender, EventArgs e)
        {
            ctrlGroupCard1.LoadGroupInfoByGroupID(_GroupID);
        }
    }
}
