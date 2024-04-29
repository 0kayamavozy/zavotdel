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
using System.Threading;
using System.Diagnostics;
using diplom.Forms.HelpersForm;

namespace diplom.Forms
{
    public partial class InClassroomForm : Form
    {
        public InClassroomForm()
        {
            InitializeComponent();
            GlobalHelper.browser = webView21;
        }
        public async Task Init()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void Browser(string connect)
        {
            await Init();
            webView21.CoreWebView2.Navigate(connect);
        }

        private void InClassroomForm_Load(object sender, EventArgs e)
        {
            GlobalHelper.Main.Enabled = false;
            GlobalHelper.Classroom.Enabled = false;
            GlobalHelper.Student.Enabled = false;
            GlobalHelper.Progress.Enabled = false;

            string query = "Select * from InClassroomCheck";
            InClassroomHelperClass.loadElementToComboBox(query, "Name", SearchItem);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            Thread.Sleep(5000);
            Close();
            GlobalHelper.Main.Enabled = true;
            GlobalHelper.Classroom.Enabled = true;
            GlobalHelper.Student.Enabled = true;
            GlobalHelper.Progress.Enabled = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddExcelFile addExcelFile = new AddExcelFile();
            addExcelFile.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InClassroomHelperClass.SelectURL(SearchItem.Text);
            Browser(GlobalHelper.URL);
        }
    }
}
