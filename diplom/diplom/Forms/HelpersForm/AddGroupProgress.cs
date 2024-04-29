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
    public partial class AddGroupProgress : Form
    {
        public AddGroupProgress()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ProgressClassHelper.Insert(nameTB.Text, Convert.ToDouble(statusTB.Text), Convert.ToDouble(birthbayTB.Text), Convert.ToDouble(guna2TextBox1.Text), Convert.ToInt32(guna2TextBox2.Text), Convert.ToInt32(guna2TextBox3.Text));
            var result = MessageBox.Show("Запись была успешно добавлена!", "Сообщение", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = ((Convert.ToDouble(statusTB.Text) + Convert.ToDouble(birthbayTB.Text)) / 2).ToString();
        }
    }
}
