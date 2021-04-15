namespace WorksNow
{
    partial class TIME_DESCRIPTION
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIME_DESCRIPTION));
            this.column_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time_stop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseWorksDataSet = new WorksNow.DataBaseWorksDataSet();
            this.tableDescriptionTableAdapter = new WorksNow.DataBaseWorksDataSetTableAdapters.TableDescriptionTableAdapter();
            this.button_time_start = new System.Windows.Forms.Button();
            this.button_time_stop = new System.Windows.Forms.Button();
            this.tableDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableDescriptionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseWorksDataSet1 = new WorksNow.DataBaseWorksDataSet();
            this.tableDescriptionTableAdapter1 = new WorksNow.DataBaseWorksDataSetTableAdapters.TableDescriptionTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseWorksDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // column_date
            // 
            this.column_date.Tag = "c_date";
            this.column_date.Text = "Дата";
            this.column_date.Width = 86;
            // 
            // column_description
            // 
            this.column_description.Tag = "c_description";
            this.column_description.Text = "Описание работы";
            this.column_description.Width = 293;
            // 
            // column_time_start
            // 
            this.column_time_start.Tag = "c_time_start";
            this.column_time_start.Text = "Время начала";
            this.column_time_start.Width = 102;
            // 
            // column_time_stop
            // 
            this.column_time_stop.Tag = "c_time_stop";
            this.column_time_stop.Text = "Время окончания";
            this.column_time_stop.Width = 126;
            // 
            // tableDescriptionBindingSource
            // 
            this.tableDescriptionBindingSource.DataMember = "TableDescription";
            this.tableDescriptionBindingSource.DataSource = this.dataBaseWorksDataSet;
            // 
            // dataBaseWorksDataSet
            // 
            this.dataBaseWorksDataSet.DataSetName = "DataBaseWorksDataSet";
            this.dataBaseWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDescriptionTableAdapter
            // 
            this.tableDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // button_time_start
            // 
            this.button_time_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_time_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_time_start.Location = new System.Drawing.Point(12, 12);
            this.button_time_start.Name = "button_time_start";
            this.button_time_start.Size = new System.Drawing.Size(130, 23);
            this.button_time_start.TabIndex = 0;
            this.button_time_start.Text = "Начало работы";
            this.button_time_start.UseVisualStyleBackColor = true;
            this.button_time_start.Click += new System.EventHandler(this.button_time_start_Click);
            // 
            // button_time_stop
            // 
            this.button_time_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_time_stop.Enabled = false;
            this.button_time_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_time_stop.Location = new System.Drawing.Point(658, 12);
            this.button_time_stop.Name = "button_time_stop";
            this.button_time_stop.Size = new System.Drawing.Size(130, 23);
            this.button_time_stop.TabIndex = 1;
            this.button_time_stop.Text = "Окончание работы";
            this.button_time_stop.UseVisualStyleBackColor = true;
            this.button_time_stop.Click += new System.EventHandler(this.button_time_stop_Click);
            // 
            // tableDescriptionBindingSource1
            // 
            this.tableDescriptionBindingSource1.DataMember = "TableDescription";
            this.tableDescriptionBindingSource1.DataSource = this.dataBaseWorksDataSet;
            // 
            // tableDescriptionBindingSource2
            // 
            this.tableDescriptionBindingSource2.DataMember = "TableDescription";
            this.tableDescriptionBindingSource2.DataSource = this.dataBaseWorksDataSet1;
            // 
            // dataBaseWorksDataSet1
            // 
            this.dataBaseWorksDataSet1.DataSetName = "DataBaseWorksDataSet";
            this.dataBaseWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDescriptionTableAdapter1
            // 
            this.tableDescriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_name,
            this.column_date,
            this.column_description,
            this.column_time_start,
            this.column_time_stop});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 397);
            this.listView1.TabIndex = 4;
            this.listView1.TileSize = new System.Drawing.Size(168, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // column_name
            // 
            this.column_name.Tag = "c_name";
            this.column_name.Text = "Имя";
            this.column_name.Width = 165;
            // 
            // TIME_DESCRIPTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_time_stop);
            this.Controls.Add(this.button_time_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TIME_DESCRIPTION";
            this.Text = "Список отчётов";
            this.Load += new System.EventHandler(this.TIME_DESCRIPTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDescriptionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseWorksDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataBaseWorksDataSet dataBaseWorksDataSet;
        private System.Windows.Forms.BindingSource tableDescriptionBindingSource;
        private DataBaseWorksDataSetTableAdapters.TableDescriptionTableAdapter tableDescriptionTableAdapter;
        private System.Windows.Forms.Button button_time_start;
        private System.Windows.Forms.Button button_time_stop;
        private System.Windows.Forms.BindingSource tableDescriptionBindingSource1;
        private DataBaseWorksDataSet dataBaseWorksDataSet1;
        private System.Windows.Forms.BindingSource tableDescriptionBindingSource2;
        private DataBaseWorksDataSetTableAdapters.TableDescriptionTableAdapter tableDescriptionTableAdapter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_name;
        private System.Windows.Forms.ColumnHeader column_date;
        private System.Windows.Forms.ColumnHeader column_description;
        private System.Windows.Forms.ColumnHeader column_time_start;
        private System.Windows.Forms.ColumnHeader column_time_stop;
    }
}