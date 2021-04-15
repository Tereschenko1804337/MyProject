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
    public partial class TIME_DESCRIPTION : Form
    {
        SqlConnection SqlConnection;
        //string stdDetails = "{0, -60}{1, -20}{2, -110}{3, -20}{4, -20}";
        string TurnName_Name;

        public TIME_DESCRIPTION(string TNN)
        {
            InitializeComponent();
            TurnName_Name = TNN;
        }

        private async void restart_Form()
        {
            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);

            await SqlConnection.OpenAsync();

            SqlDataReader SQL_READER_discription = null;

            SqlCommand SQL_COMMAND_Description = new SqlCommand("Select * from [TableDescription]", SqlConnection);

            SQL_READER_discription = await SQL_COMMAND_Description.ExecuteReaderAsync();

            while (await SQL_READER_discription.ReadAsync())
            {
                if (Convert.ToString(SQL_READER_discription["Name"]) == TurnName_Name &&
                Convert.ToString(SQL_READER_discription["Time_Start"]) != "" &&
                Convert.ToString(SQL_READER_discription["Time_Stop"]) == "")
                {
                    button_time_stop.Enabled = true;
                    button_time_start.Enabled = false;

                    string Name, Date, Description, Time_Start, Time_Stop;
                    Name = Convert.ToString(SQL_READER_discription["Name"]);
                    Date = Convert.ToString(SQL_READER_discription["Date"]);
                    Date = DateTime.Parse(Date).ToShortDateString();
                    Description = Convert.ToString(SQL_READER_discription["Description"]);
                    Time_Start = Convert.ToString(SQL_READER_discription["Time_Start"]);
                    Time_Stop = Convert.ToString(SQL_READER_discription["Time_Stop"]);

                    string[] list = { Name, Date, Description, Time_Start, Time_Stop };
                    listView1.Items.Add(new ListViewItem(list));
                }
                //Что бы ниже придумать?)
            }
            SqlConnection.Close();
        }

        private async void button_time_start_Click(object sender, EventArgs e)
        {
            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);
            await SqlConnection.OpenAsync();

            //Не, ну тут всё норм, а там не норм(ниже в запросе)
            string time_start_string = DateTime.Now.ToString("HH:mm:ss");
            string time_date = DateTime.Now.ToString("MM.dd.yyyy");
            //time_date = DateTime.Parse(time_date).ToShortDateString();
            //Надо сначала месяц, потом день, потом год

            //Заработай во имя Одина!!!!!!!!!!
            SqlCommand SQL_COMMAND = new SqlCommand("INSERT INTO [TableDescription] (Name, Date, Time_Start) VALUES (@Name, @Date, @time_start_string)", SqlConnection);
            SQL_COMMAND.Parameters.AddWithValue("Name", TurnName_Name);
            SQL_COMMAND.Parameters.AddWithValue("Date", time_date);
            SQL_COMMAND.Parameters.AddWithValue("time_start_string", time_start_string);

            await SQL_COMMAND.ExecuteNonQueryAsync();   //В чужом глазу соринку видишь, а в коде и бревна не различишь...
            SqlConnection.Close();

            //listView1.Clear();
            restart_Form();
        }

        private async void button_time_stop_Click(object sender, EventArgs e)
        {
            Description_Works description_Works = new Description_Works(TurnName_Name);
            description_Works.ShowDialog();

            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);
            await SqlConnection.OpenAsync();
            SqlDataReader SQL_READER_discription = null;
            SqlCommand SQL_COMMAND_Description = new SqlCommand("Select * from [TableDescription] WHERE Id in (SELECT MAX(Id) FROM [TableDescription] WHERE Name = @Name)", SqlConnection);
            SQL_COMMAND_Description.Parameters.AddWithValue("Name", TurnName_Name);

            await SQL_COMMAND_Description.ExecuteNonQueryAsync();

            SQL_READER_discription = await SQL_COMMAND_Description.ExecuteReaderAsync();

            while (await SQL_READER_discription.ReadAsync())
            {
                if (Convert.ToString(SQL_READER_discription["Description"]) != "")
                {
                    if (listView1.Items.Count > 0)
                        listView1.Items[listView1.Items.Count - 1].Remove();

                    string Name, Date, Description, Time_Start, Time_Stop;
                    Name = Convert.ToString(SQL_READER_discription["Name"]);
                    Date = Convert.ToString(SQL_READER_discription["Date"]);
                    Date = DateTime.Parse(Date).ToShortDateString();
                    Description = Convert.ToString(SQL_READER_discription["Description"]);
                    Time_Start = Convert.ToString(SQL_READER_discription["Time_Start"]);
                    Time_Stop = Convert.ToString(SQL_READER_discription["Time_Stop"]);

                    string[] list = { Name, Date, Description, Time_Start, Time_Stop };
                    listView1.Items.Add(new ListViewItem(list));

                    button_time_start.Enabled = true;
                    button_time_stop.Enabled = false;
                }
            }
        }

        private async void TIME_DESCRIPTION_Load(object sender, EventArgs e)
        {
            listView1.LabelWrap = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseWorksDataSet1.TableDescription". При необходимости она может быть перемещена или удалена.
            //this.tableDescriptionTableAdapter1.Fill(this.dataBaseWorksDataSet1.TableDescription);
            listView1.Items.Clear();
            //listView1.Items.Add(String.Format(stdDetails, "Name", "Date", "Description", "Time_Start", "Time_Stop"));

            string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentWorks\WorksNow\WorksNow\DataBaseWorks.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(CONNECTION_STRING);
            await SqlConnection.OpenAsync();

            SqlDataReader SQL_READER_discription = null;

            SqlCommand SQL_COMMAND_Description = new SqlCommand("Select * from [TableDescription]", SqlConnection);
            //SQL_COMMAND_Description.Parameters.AddWithValue("TurnName_Name", TurnName_Name);
            //SqlCommand SQL_COMMAND_Name = new SqlCommand("Select * from [TableName]", SqlConnection);

            try
            {
                SQL_READER_discription = await SQL_COMMAND_Description.ExecuteReaderAsync();
                //SQL_READER_name = await SQL_COMMAND_Name.ExecuteReaderAsync();

                while (await SQL_READER_discription.ReadAsync())
                {
                    if (Convert.ToString(SQL_READER_discription["Name"]) == TurnName_Name &&
                    Convert.ToString(SQL_READER_discription["Time_Start"]) != null &&
                    Convert.ToString(SQL_READER_discription["Time_Stop"]) == "")
                    {
                        button_time_stop.Enabled = true;
                        button_time_start.Enabled = false;
                    }

                    string READER = Convert.ToString(SQL_READER_discription["Name"]);
                    if (READER == TurnName_Name)
                    {
                        string Name, Date, Description, Time_Start, Time_Stop;
                        Name = Convert.ToString(SQL_READER_discription["Name"]);
                        Date = Convert.ToString(SQL_READER_discription["Date"]);
                        Date = DateTime.Parse(Date).ToShortDateString();
                        Description = Convert.ToString(SQL_READER_discription["Description"]);
                        Time_Start = Convert.ToString(SQL_READER_discription["Time_Start"]);
                        Time_Stop = Convert.ToString(SQL_READER_discription["Time_Stop"]);

                        string[] list = { Name, Date, Description, Time_Start, Time_Stop };
                        listView1.Items.Add(new ListViewItem(list));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SQL_READER_discription != null)
                    SQL_READER_discription.Close();
            }
            //restart_Form();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string D, TNN, TStart, TStop, Disc;

            D = listView1.FocusedItem.SubItems[1].Text;
            TNN = listView1.FocusedItem.SubItems[0].Text;
            TStart = listView1.FocusedItem.SubItems[3].Text;
            TStop = listView1.FocusedItem.SubItems[4].Text;
            Disc = listView1.FocusedItem.SubItems[2].Text;

            if (Disc != "")
            {
                Report report = new Report(D, TNN, TStart, TStop, Disc);
                report.ShowDialog();
            }
        }
    }
}
