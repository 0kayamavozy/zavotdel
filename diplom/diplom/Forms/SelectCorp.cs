using diplom.Classes;
using diplom.Forms;
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
    public partial class SelectCorp : Form
    {
        public SelectCorp()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            GlobalHelper.CorpusName = "Главный";

            MainForm firstLoadForm = new MainForm();
            firstLoadForm.Show();
            Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            GlobalHelper.CorpusName = "Первый";

            MainForm firstLoadForm = new MainForm();
            firstLoadForm.Show();
            Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            GlobalHelper.CorpusName = "Второй";

            MainForm firstLoadForm = new MainForm();
            firstLoadForm.Show();
            Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
