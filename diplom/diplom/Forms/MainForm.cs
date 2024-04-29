using diplom.Classes;
using diplom.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GlobalHelper.Main = MainBTN;
            GlobalHelper.Student = StudentsBTN;
            GlobalHelper.Classroom = InClassroomBTN;
            GlobalHelper.Progress = ProgressBTN;
        }

        private void ResetColor()
        {
            foreach(Guna2Button button in flowLayoutPanel1.Controls)
            {
                if (button.FillColor == Color.MidnightBlue)
                {
                    button.FillColor = Color.RoyalBlue;
                }
            }
        }

        private Form activeform = null;
        private void openForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainContentPanel.Controls.Add(childForm);
            MainContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void StudentsBTN_Click(object sender, EventArgs e)
        {
            openForm(new StudentsForm());
            ResetColor();
            StudentsBTN.FillColor = Color.MidnightBlue;
        }

        private void InClassroomBTN_Click(object sender, EventArgs e)
        {
            InClassroomForm inClassroom = new InClassroomForm();
            inClassroom.ShowDialog();
            ResetColor();
            InClassroomBTN.FillColor = Color.MidnightBlue;
        }

        private void ProgressBTN_Click(object sender, EventArgs e)
        {
            openForm(new ProgressForm());
            ResetColor();
            ProgressBTN.FillColor = Color.MidnightBlue;
        }

        private void MainBTN_Click(object sender, EventArgs e)
        {
            openForm(new FirstLoadForm());
            ResetColor();
            MainBTN.FillColor = Color.MidnightBlue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openForm(new FirstLoadForm());
            ResetColor();
            MainBTN.FillColor = Color.MidnightBlue;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {          
            SelectCorp selectCorp = new SelectCorp();
            selectCorp.Show();
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
