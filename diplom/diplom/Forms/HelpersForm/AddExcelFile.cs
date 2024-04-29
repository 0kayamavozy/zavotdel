using diplom.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom.Forms.HelpersForm
{
    public partial class AddExcelFile : Form
    {
        public AddExcelFile()
        {
            InitializeComponent();
        }

        private void AddExcelFile_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InClassroomHelperClass.InsertURL(group.Text, url.Text);
        }
    }
}
