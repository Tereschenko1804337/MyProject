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
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load_method()
        {
            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);

            await SqlConnection.OpenAsync();

            SqlDataReader SQL_READER = null;

            SqlCommand SQL_COMMAND = new SqlCommand("Select * from [TableName]", SqlConnection);

            try
            {
                SQL_READER = await SQL_COMMAND.ExecuteReaderAsync();

                while (await SQL_READER.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(SQL_READER["TurnName"]) + " " + Convert.ToString(SQL_READER["Name"]) + " " + Convert.ToString(SQL_READER["MiddleName"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SQL_READER != null)
                    SQL_READER.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Load_method();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
                SqlConnection.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string TNN = listBox1.SelectedItem.ToString();

            TIME_DESCRIPTION TIME_DESCRIPTION = new TIME_DESCRIPTION(TNN);
            TIME_DESCRIPTION.ShowDialog();
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            Add_User_Form add_User_Form = new Add_User_Form();
            add_User_Form.ShowDialog();
            listBox1.Items.Clear();
            Form1_Load_method();
        }
    }
}
