namespace WorksNow
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.richTextBox_discription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time_start = new System.Windows.Forms.Label();
            this.label_time_stop = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_discription
            // 
            this.richTextBox_discription.BackColor = System.Drawing.Color.White;
            this.richTextBox_discription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_discription.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_discription.Enabled = false;
            this.richTextBox_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_discription.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_discription.Location = new System.Drawing.Point(12, 68);
            this.richTextBox_discription.Name = "richTextBox_discription";
            this.richTextBox_discription.Size = new System.Drawing.Size(276, 171);
            this.richTextBox_discription.TabIndex = 0;
            this.richTextBox_discription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчёт";
            // 
            // lable_Name
            // 
            this.lable_Name.AutoSize = true;
            this.lable_Name.BackColor = System.Drawing.Color.Bisque;
            this.lable_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lable_Name.Location = new System.Drawing.Point(59, 13);
            this.lable_Name.Name = "lable_Name";
            this.lable_Name.Size = new System.Drawing.Size(35, 13);
            this.lable_Name.TabIndex = 2;
            this.lable_Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "За период:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "по";
            // 
            // label_time_start
            // 
            this.label_time_start.AutoSize = true;
            this.label_time_start.BackColor = System.Drawing.Color.Gainsboro;
            this.label_time_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_time_start.Location = new System.Drawing.Point(91, 41);
            this.label_time_start.Name = "label_time_start";
            this.label_time_start.Size = new System.Drawing.Size(52, 13);
            this.label_time_start.TabIndex = 6;
            this.label_time_start.Text = "time_start";
            // 
            // label_time_stop
            // 
            this.label_time_stop.AutoSize = true;
            this.label_time_stop.BackColor = System.Drawing.Color.Gainsboro;
            this.label_time_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_time_stop.Location = new System.Drawing.Point(165, 41);
            this.label_time_stop.Name = "label_time_stop";
            this.label_time_stop.Size = new System.Drawing.Size(52, 13);
            this.label_time_stop.TabIndex = 7;
            this.label_time_stop.Text = "time_stop";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(237, 41);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 8;
            this.label_date.Text = "Date";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 251);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_time_stop);
            this.Controls.Add(this.label_time_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_discription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_discription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time_start;
        private System.Windows.Forms.Label label_time_stop;
        private System.Windows.Forms.Label label_date;
    }
}