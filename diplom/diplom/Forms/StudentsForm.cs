using diplom.Classes;
using diplom.Forms.HelpersForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace diplom.Forms
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in StudentsDG.Columns)
                column.Width = 500;
        }

        public static string sqlConnection = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = zavotdeleniem; Integrated Security=True";

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            StudentsHelperClasscs.Select(StudentsDG);
            StudentsHelperClasscs.CountStudents(countTB);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();
            addStudents.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StudentsHelperClasscs.table.Clear();
            StudentsHelperClasscs.Select(StudentsDG);
            StudentsHelperClasscs.CountStudents(countTB);
            //MessageBox.Show("Таблица обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            StudentsHelperClasscs.Search(SearchItem.Text, SearchBar.Text);
        }

        private void StudentsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentsHelperClasscs.SetDataTextBox(StudentsDG, nameTB, statusTB, number, departmentTB, birthbayTB, financeTB, spqcializationTB, yearTB, cardTB, courseTB, groupTB, formTB);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (number.Text == "0")
            {
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                var result = MessageBox.Show("Вы действительно хотите удалить запись?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    StudentsHelperClasscs.DeleteStudents(number.Text);
                    MessageBox.Show("Студент успешно удален", "Сообщение", MessageBoxButtons.OK);

                    foreach (System.Windows.Forms.Control control in ControlsPanel.Controls)
                    {
                        if (control is Guna2TextBox)
                            control.Text = string.Empty;
                    }
                    courseTB.SelectedIndex = -1;
                    formTB.SelectedIndex = -1;
                    financeTB.SelectedIndex = -1;
                    number.Text = string.Empty;
                }                  
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            StudentsHelperClasscs.Update(nameTB.Text, statusTB.Text, number.Text, departmentTB.Text, birthbayTB.Text, financeTB.Text, spqcializationTB.Text, yearTB.Text, cardTB.Text, courseTB.Text, groupTB.Text, formTB.Text);
            MessageBox.Show("Данные студента успешно обновлены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in ControlsPanel.Controls)
            {
                if (control is Guna2TextBox)
                    control.Text = string.Empty;
            }
            courseTB.SelectedIndex = -1;
            formTB.SelectedIndex = -1;
            financeTB.SelectedIndex = -1;
            number.Text = string.Empty;
        }
    }
}
