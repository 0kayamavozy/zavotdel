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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsHelperClasscs.Add(nameTB.Text, statusTB.Text, departmentTB.Text, birthbayTB.Text, financeTB.Text, spqcializationTB.Text, yearTB.Text, int.Parse(cardTB.Text), int.Parse(courseTB.Text), groupTB.Text, formTB.Text);
                var result = MessageBox.Show("Студент успешно добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При добавлении студента произошла ошибка! {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
