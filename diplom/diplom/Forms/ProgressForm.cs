using diplom.Classes;
using diplom.Forms.HelpersForm;
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

namespace diplom.Forms
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            string query = "select * from ProgressGroup";
            ProgressClassHelper.loadElementToComboBox(query, "Group_Name", SearchItem);
            ProgressClassHelper.Select(guna2DataGridView1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ProgressClassHelper.Search(SearchItem.Text, guna2DataGridView1);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ProgressClassHelper.Select(guna2DataGridView1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AddGroupProgress addGroupProgress = new AddGroupProgress();
            addGroupProgress.ShowDialog();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgressClassHelper.Cell(guna2DataGridView1, nameTB, profileTB, baseTB, middleTB, deductedTB, arrearsTB);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                middleTB.Text = ((Convert.ToDouble(profileTB.Text) + Convert.ToDouble(baseTB.Text)) / 2).ToString();
            }
            catch { }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ProgressClassHelper.DeleteGroup(nameTB.Text);
            MessageBox.Show("Запись успешно удалена", "Сообщение", MessageBoxButtons.OK);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            nameTB.Text = string.Empty;
            profileTB.Text = string.Empty;
            baseTB.Text = string.Empty;
            middleTB.Text = string.Empty;
            deductedTB.Text = string.Empty;
            arrearsTB.Text = string.Empty;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ProgressClassHelper.Update(nameTB.Text, Convert.ToDouble(profileTB.Text), Convert.ToDouble(baseTB.Text), Convert.ToDouble(middleTB.Text), Convert.ToInt32(deductedTB.Text), Convert.ToInt32(arrearsTB.Text));
            MessageBox.Show("Запись успешно изменена", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
