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
    public partial class frmShowClassCard : Form
    {
        public frmShowClassCard(int? ClassID)
        {
            InitializeComponent();
            ctrlClassCardWithFilter1.LoadClassInfoByClassID(ClassID);
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
