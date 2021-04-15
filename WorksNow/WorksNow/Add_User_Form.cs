using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksNow
{
    public partial class Add_User_Form : Form
    {

        SqlConnection SqlConnection;

        public Add_User_Form()
        {
            InitializeComponent();
        }

        private async void Save_button_Click(object sender, EventArgs e)
        {
            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);
            await SqlConnection.OpenAsync();
            if (TurnName_textBox.Text == "" || Name_textBox.Text == "" || MiddleName_textBox.Text == "")
            {
                string error_text = "Заполните ФИО полностью!";
                TurnName_textBox.BackColor = Color.Salmon;
                Name_textBox.BackColor = Color.Salmon;
                MiddleName_textBox.BackColor = Color.Salmon;

                MessageBox.Show(error_text, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand SQL_COMMAND = new SqlCommand("INSERT INTO [TableName] (TurnName, Name, MiddleName, Age) VALUES (@TurnName, @Name, @MiddleName, @Age)", SqlConnection);
                SQL_COMMAND.Parameters.AddWithValue("TurnName", TurnName_textBox.Text);
                SQL_COMMAND.Parameters.AddWithValue("Name", Name_textBox.Text);
                SQL_COMMAND.Parameters.AddWithValue("MiddleName", MiddleName_textBox.Text);
                SQL_COMMAND.Parameters.AddWithValue("Age", Age_textBox.Text);
                await SQL_COMMAND.ExecuteNonQueryAsync();

                SqlConnection.Close();

                this.Close();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
