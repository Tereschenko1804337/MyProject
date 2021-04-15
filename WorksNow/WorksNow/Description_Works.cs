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
    public partial class Description_Works : Form
    {
        string TurnName_Name;
        SqlConnection SqlConnection;

        public Description_Works(string TNN)
        {
            InitializeComponent();
            TurnName_Name = TNN;
        }

        private async void write_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.TextLength > 20)
            {
                string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
                SqlConnection = new SqlConnection(CONNECTION_STRING);
                await SqlConnection.OpenAsync();

                string time_date = DateTime.Now.ToString("HH:mm:ss");
                //time_date = DateTime.Parse(time_date).ToShortTimeString();
                
                SqlCommand SQL_COMMAND = new SqlCommand("UPDATE TableDescription SET Description = @Description, Time_Stop = @Time_Stop WHERE Id in (SELECT MAX(Id) FROM [TableDescription] WHERE Name = @Name)", SqlConnection);

                SQL_COMMAND.Parameters.AddWithValue("Name", TurnName_Name);
                SQL_COMMAND.Parameters.AddWithValue("Description", textBox1.Text);
                SQL_COMMAND.Parameters.AddWithValue("Time_Stop", time_date);
                await SQL_COMMAND.ExecuteNonQueryAsync();
                SqlConnection.Close();

            }
            else
            {
                string error_text = "Заполните информацию о рабочем дне!";
                MessageBox.Show(error_text, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Cancle_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Description_Works_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
                SqlConnection.Close();
        }
    }
}
