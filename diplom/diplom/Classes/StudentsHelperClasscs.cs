using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.Common;
using System.IO;

namespace diplom.Classes
{
    public static class StudentsHelperClasscs
    {
        public static string sqlConnection = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = zavotdeleniem; Integrated Security=True";
        private static SqlConnection Sqlconnection = null;
        public static DataTable table = null;
        private static SqlDataAdapter adapter = null;

        public static void Select1(Guna2DataGridView dataGridView)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string command = $"Select * from Students where Corpus = {GlobalHelper.CorpusName}";
            Sqlconnection.Open();

            adapter = new SqlDataAdapter(command, Sqlconnection);
            table = new DataTable();

            adapter.Fill(table);
            dataGridView.DataSource = table;

            Sqlconnection.Close();
        }

        public static void Select(Guna2DataGridView dataGridView)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string sqlcommand = $"Select * from Students where Corpus = @Corpus";

            Sqlconnection.Open();

            using(SqlCommand command = new SqlCommand(sqlcommand, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);

                adapter = new SqlDataAdapter(command);
                table = new DataTable();

                adapter.Fill(table);
                dataGridView.DataSource = table;
            }

            Sqlconnection.Close();
        }

        public static void Search(string searchItem, string search)
        {
            DataView dataView = new DataView();
            if(searchItem != string.Empty)
            {
                dataView = table.DefaultView;
                if (searchItem == "Code" && search != string.Empty)
                {
                    try
                    {
                        dataView.RowFilter = $"{searchItem} = {Convert.ToInt32(search)}";
                    }
                    catch
                    {
                        
                    }
                }
                else
                {
                    try
                    {
                        dataView.RowFilter = $"{searchItem} like '%" + search + "%'";
                    }
                    catch
                    {
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран параметр для поиска","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Add(string name, string status, string department, string birthday, string finance, string specialization, string date, int num_card, int cource, string group_name, string form_education)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string command = "insert into Students (Fio, Status, Department, Birthday, Finance, Specialization, Year, NumberCard, Course, StudentGroup, EducationForm)" +
                "values (@name, @status, @department, @birthday, @finance, @specialization, @date, @num_card, @course, @group_name, @form_education)";
            Sqlconnection.Open();
            using (SqlCommand sqlcommand = new SqlCommand(command, Sqlconnection))
            {
                sqlcommand.Parameters.AddWithValue("@name", name);
                sqlcommand.Parameters.AddWithValue("@status", status);
                sqlcommand.Parameters.AddWithValue("@department", department);
                sqlcommand.Parameters.AddWithValue("@birthday", birthday);
                sqlcommand.Parameters.AddWithValue("@finance", finance);
                sqlcommand.Parameters.AddWithValue("@specialization", specialization);
                sqlcommand.Parameters.AddWithValue("@date", date);
                sqlcommand.Parameters.AddWithValue("@num_card", num_card);
                sqlcommand.Parameters.AddWithValue("@course", cource);
                sqlcommand.Parameters.AddWithValue("@group_name", group_name);
                sqlcommand.Parameters.AddWithValue("@form_education", form_education);

                sqlcommand.ExecuteNonQuery();
            }
            Sqlconnection.Close();
        }     
        
        public static void SetDataTextBox(Guna2DataGridView dataGridView, Guna2TextBox Fio, Guna2TextBox Status, Label code, Guna2TextBox Department, Guna2TextBox Birthday, Guna2ComboBox Finance,
            Guna2TextBox Specialization, Guna2TextBox Year, Guna2TextBox NumberCard, Guna2ComboBox Course, Guna2TextBox StudentGroup, Guna2ComboBox EducationForm)
        {
            Fio.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Status.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            code.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Department.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Birthday.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Finance.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Specialization.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Year.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
            NumberCard.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Course.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
            StudentGroup.Text = dataGridView.SelectedRows[0].Cells[10].Value.ToString();
            EducationForm.Text = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
        }

        public static void DeleteStudents(string code)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string command = $"delete from Students where Code = {code}";
            Sqlconnection.Open();

            SqlCommand sqlCommand = new SqlCommand(command, Sqlconnection);
            sqlCommand.ExecuteNonQuery();

            Sqlconnection.Close();
        }

        public static void CountStudents(Guna2TextBox textbox1)
        {
            string SelectAll = "select count(*) from Students where Corpus = @Corpus";

            Sqlconnection = new SqlConnection(sqlConnection);
            Sqlconnection.Open();

            SqlCommand sqlCommand1 = new SqlCommand(SelectAll, Sqlconnection);

            sqlCommand1.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);

            SqlDataReader reader = sqlCommand1.ExecuteReader();
            if (reader.Read())
                textbox1.Text = reader.GetInt32(0).ToString();
            reader.Close();
           
            Sqlconnection.Close();
        }

        public static void SelectFree(Guna2TextBox textbox)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string query = $"select Count(*) from Students where Finance = N'Бюджетное' and Corpus = N'{GlobalHelper.CorpusName}'";

            Sqlconnection.Open();

            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textbox.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }

            Sqlconnection.Close();
        }

        public static void SelectMoney(Guna2TextBox textbox)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string query = $"select Count(*) from Students where Finance = N'Коммерческое' and Corpus = N'{GlobalHelper.CorpusName}'";

            Sqlconnection.Open();

            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textbox.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }

            Sqlconnection.Close();
        }

        public static void SelectO(Guna2TextBox textbox)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string query = $"select Count(*) from Students where EducationForm = N'Очная' and Corpus = N'{GlobalHelper.CorpusName}'";

            Sqlconnection.Open();

            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textbox.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }

            Sqlconnection.Close();
        }

        public static void SelectZ(Guna2TextBox textbox)
        {
            Sqlconnection = new SqlConnection(sqlConnection);

            string query = $"select Count(*) from Students where EducationForm = N'Заочная' and Corpus = N'{GlobalHelper.CorpusName}'";

            Sqlconnection.Open();

            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textbox.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }

            Sqlconnection.Close();
        }

        public static void Update(string fio, string status, string code, string department, string birthday, string finance, string specialization, string year, string numbercard, string course, string studentgroup, string edicationform)
        {
            Sqlconnection = new SqlConnection(sqlConnection);
            string command = $"update Students set Fio = @Fio, Status = @Status, Department = @Department, Birthday = @Birthday, Finance = @Finance, Specialization = @Specialization, Year = @Year, NumberCard = @NumberCard, Course = @Course, StudentGroup = @StudentGroup, EducationForm = @EducationForm where Code = @Code";
            Sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, Sqlconnection);

            sqlCommand.Parameters.AddWithValue("@Fio", fio);
            sqlCommand.Parameters.AddWithValue("@Status", status);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            sqlCommand.Parameters.AddWithValue("@Department", department);
            sqlCommand.Parameters.AddWithValue("@Birthday", birthday);
            sqlCommand.Parameters.AddWithValue("@Finance", finance);
            sqlCommand.Parameters.AddWithValue("@Specialization", specialization);
            sqlCommand.Parameters.AddWithValue("@Year", year);
            sqlCommand.Parameters.AddWithValue("@NumberCard", numbercard);
            sqlCommand.Parameters.AddWithValue("@Course", course);
            sqlCommand.Parameters.AddWithValue("@StudentGroup", studentgroup);
            sqlCommand.Parameters.AddWithValue("@EducationForm", edicationform);

            sqlCommand.ExecuteNonQuery();
            Sqlconnection.Close();
        }

        
    }
}
