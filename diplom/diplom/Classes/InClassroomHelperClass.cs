using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace diplom.Classes
{
    public class InClassroomHelperClass
    {
        public static string _Path = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = zavotdeleniem; Integrated Security=True";

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

        public static void SelectURL(object parameter)
        {
            parameter.ToString();
            SqlConnection sqlConnection = new SqlConnection(_Path);
            string query = $"select * from InClassroomCheck where Name = {parameter}";
            sqlConnection.Open();

            using(SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   GlobalHelper.URL = reader.GetString(1);
                }
            }
            sqlConnection.Close();
        }

        public static void InsertURL(string group, string url)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_Path);
                string query = $"insert into InClassroomCheck(Name, URL) values (@Group, @URL)";
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Group", group);
                    command.Parameters.AddWithValue("@URL", url);
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
                MessageBox.Show("Ссылка успешно добалвена!", "Сообщение", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("При добавлении возникла ошибка!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }

    
}
