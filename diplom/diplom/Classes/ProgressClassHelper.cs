using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Reflection;

namespace diplom.Classes
{
    public static class ProgressClassHelper
    {
        public static string _Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = zavotdeleniem; Integrated Security=True";
        private static SqlConnection Sqlconnection = null;
        public static DataTable table = null;
        private static SqlDataAdapter adapter = null;


        public static void Select(Guna2DataGridView guna2DataGridView)
        {
            Sqlconnection = new SqlConnection(_Path);
            Sqlconnection.Open();

            string query = "select * from ProgressGroup where Corpus = @Corpus";

            using(SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Corpus", GlobalHelper.CorpusName);

                adapter = new SqlDataAdapter(command);
                table = new DataTable();

                adapter.Fill(table);
                guna2DataGridView.DataSource = table;
            }

            Sqlconnection.Close();
        }

        public static void Search(string groupName, Guna2DataGridView guna2DataGridView)
        {
            Sqlconnection = new SqlConnection(_Path);
            Sqlconnection.Open();

            string query = $"select * from ProgressGroup where Group_Name = {groupName}";

            using (adapter = new SqlDataAdapter(query, Sqlconnection))
            {
                table = new DataTable();
                adapter.Fill(table);
                guna2DataGridView.DataSource = table;
            }

            Sqlconnection.Close();
        }

        public static void loadElementToComboBox(string query, string column, Guna2ComboBox combobox)
        {
            List<string> list = GetColumnValue(query, column);
            combobox.Items.AddRange(list.ToArray());
        }

        public static List<string> GetColumnValue(string query, string columnname)
        {
            List<string> list = new List<string>();
            SqlConnection sqlConnection = new SqlConnection(_Path);
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(columnname));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    list.Add(columnValue);
                }
                return list;
            }
        }

        public static void Insert(string Group, double Profile, double Base, double Middle, int Deducted, int Arrears)
        {
            Sqlconnection = new SqlConnection(_Path);
            string query = "insert into ProgressGroup(Group_Name, Profile_Level, Base_Level, Middle, Deducted, Arrears) values (@Group, @Profile, @Base, @Middle, @Deducted, @Arrears)";
            Sqlconnection.Open();
            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Group", Group);
                command.Parameters.AddWithValue("@Profile", Profile);
                command.Parameters.AddWithValue("@Base", Base);
                command.Parameters.AddWithValue("@Middle", Middle);
                command.Parameters.AddWithValue("@Deducted", Deducted);
                command.Parameters.AddWithValue("@Arrears", Arrears);

                command.ExecuteNonQuery();
            }
            Sqlconnection.Close();
        }

        public static void Cell(Guna2DataGridView dataGridView, Guna2TextBox textBox1, Guna2TextBox textBox2, Guna2TextBox textBox3, Guna2TextBox textBox4, Guna2TextBox textBox5, Guna2TextBox textBox6)
        {
            textBox1.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        public static void DeleteGroup(string group)
        {
            Sqlconnection = new SqlConnection(_Path);

            string command = $"delete from ProgressGroup where Group_Name = {group}";
            Sqlconnection.Open();

            SqlCommand sqlCommand = new SqlCommand(command, Sqlconnection);
            sqlCommand.ExecuteNonQuery();

            Sqlconnection.Close();
        }

        public static void Update(string Group, double Profile, double Base, double Middle, int Deducted, int Arrears)
        {
            Sqlconnection = new SqlConnection(_Path);
            string query = "update ProgressGroup set Profile_Level = @Profile, Base_Level = @Base, Middle = @Middle, Deducted = @Deducted, Arrears = @Arrears where Group_Name = @Group";
            Sqlconnection.Open();

            using (SqlCommand command = new SqlCommand(query, Sqlconnection))
            {
                command.Parameters.AddWithValue("@Group", Group);
                command.Parameters.AddWithValue("@Profile", Profile);
                command.Parameters.AddWithValue("@Base", Base);
                command.Parameters.AddWithValue("@Middle", Middle);
                command.Parameters.AddWithValue("@Deducted", Deducted);
                command.Parameters.AddWithValue("@Arrears", Arrears);

                command.ExecuteNonQuery();
            }
            Sqlconnection.Close();
        }

        
    }
}
