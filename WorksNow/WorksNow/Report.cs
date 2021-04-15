using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksNow
{
    public partial class Report : Form
    {
        string Date, TurnName_Name, Time_start, Time_Stop, Discription;

        public Report(string D, string TNN, string TStart, string TStop, string Disc)
        {
            Date = D;
            TurnName_Name = TNN;
            Time_start = TStart;
            Time_Stop = TStop;
            Discription = Disc;
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            lable_Name.Text = TurnName_Name;
            label_time_start.Text = Time_start;
            label_time_stop.Text = Time_Stop;
            label_date.Text = Date;

            richTextBox_discription.Text = Discription;
        }
    }
}
